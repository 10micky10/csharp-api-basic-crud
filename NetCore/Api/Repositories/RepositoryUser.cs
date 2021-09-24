using Api.Dao;
using Api.Dtos;
using Api.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Api.Repositories
{
    public class RepositoryUser : IRepositoryGeneric<DtoUser>
    {
        public void Create(DtoUser dto)
        {
            DaoGeneric<dbcrudapiContext,User>.Create(dto.DtoToEntity());
        }

        public void DeleteById(long id)
        {
            DaoGeneric<dbcrudapiContext, User>.DeleteById(id);
        }

        public bool Exist(DtoUser dto)
        {
            return DaoGeneric<dbcrudapiContext, User>.Exist(dto.DtoToEntity());
        }

        public DtoUser FindById(long id)
        {
            User entityFind = DaoGeneric<dbcrudapiContext, User>.FindById(id);
            DtoUser dto = DtoUser.EntityToDto(entityFind);

            return dto;
        }

        public List<DtoUser> Read()
        {
            List<DtoUser> dtoList = DaoGeneric<dbcrudapiContext,User>.Read()
                .Select(entity => DtoUser.EntityToDto(entity))
                .ToList();

            return dtoList;
        }

        public void UpdateById(long id, DtoUser dto)
        {
            DaoGeneric<dbcrudapiContext, User>.UpdateById(id, dto.DtoToEntity());
        }
    }
}
