using Api.Dtos;
using Api.Repositories;
using Api.Responses;
using System;
using System.Net;

namespace Api.Services.Users
{
    public class ServiceUserGet
    {
        private IRepositoryGeneric<DtoUser> _repository;

        public ServiceUserGet(IRepositoryGeneric<DtoUser> repository)
        {
            _repository = repository;
        }

        public Response Get()
        {
            Response response;
            try
            {
                response = ResponseBuilder
                    .Successfully(HttpStatusCode.OK, _repository.Read());
            }
            catch (Exception err)
            {
                response = ResponseBuilder
                    .Error(HttpStatusCode.Conflict, err.Message);
            }
            return response;
        }
    }
}
