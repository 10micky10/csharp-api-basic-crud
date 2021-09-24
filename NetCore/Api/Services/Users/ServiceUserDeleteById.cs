using Api.Dtos;
using Api.Repositories;
using Api.Responses;
using System;
using System.Net;

namespace Api.Services.Users
{
    public class ServiceUserDeleteById
    {
        private IRepositoryGeneric<DtoUser> _repository;

        public ServiceUserDeleteById(IRepositoryGeneric<DtoUser> repository)
        {
            _repository = repository;
        }

        public Response Delete(long id)
        {
            Response response;
            try
            {
                if (_repository.Exist(_repository.FindById(id)))
                {
                    _repository.DeleteById(id);
                    response = 
                        ResponseBuilder.Successfully(HttpStatusCode.OK, "Deleted Successfully");
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
