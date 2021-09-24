using Api.Dtos;
using Api.Repositories;
using Api.Responses;
using System;
using System.Net;

namespace Api.Services.Users
{
    public class ServiceUserEditById
    {
        private IRepositoryGeneric<DtoUser> _repository;

        public ServiceUserEditById(IRepositoryGeneric<DtoUser> repository)
        {
            _repository = repository;
        }

        public Response Edit(long id, DtoUser dto)
        {
            Response response;
            try
            {
                if (_repository.Exist(_repository.FindById(id)))
                {
                    DtoUser dtoFind = _repository.FindById(id);
                    dtoFind.Name = dto.Name;
                    dtoFind.Username = dto.Username;
                    dtoFind.Password = dto.Password;
                    dtoFind.UpdatedBy = dto.UpdatedBy;

                    _repository.UpdateById(id, dtoFind);
                    response =
                        ResponseBuilder.Successfully(HttpStatusCode.OK, "Updated Successfully");
                }
                else
                {
                    response =
                        ResponseBuilder.Error(HttpStatusCode.NotFound, "Not Found");
                }
            }
            catch (Exception ex)
            {
                response =
                        ResponseBuilder.Error(HttpStatusCode.Conflict, ex.Message);
            }
            return response;
        }
    }
}
