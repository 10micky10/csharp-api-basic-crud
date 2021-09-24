using Api.Dtos;
using Api.Repositories;
using Api.Responses;
using System;
using System.Net;

namespace Api.Services.Users
{
    public class ServiceUserPost
    {
        private IRepositoryGeneric<DtoUser> _repository;

        public ServiceUserPost(IRepositoryGeneric<DtoUser> repository)
        {
            _repository = repository;
        }

        public Response Post(DtoUser dto)
        {
            Response response;
            try
            {
                _repository.Create(dto);
                response = 
                    ResponseBuilder.Successfully(HttpStatusCode.Created, "Created Succesfully");
            }
            catch (Exception err)
            {
                response = ResponseBuilder.Error(HttpStatusCode.Conflict, err.Message);
            }
            return response;
        }
    }
}
