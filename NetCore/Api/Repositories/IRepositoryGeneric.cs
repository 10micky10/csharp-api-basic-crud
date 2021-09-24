using System.Collections.Generic;

namespace Api.Repositories
{
    public interface IRepositoryGeneric<TDto> where TDto : class
    {
        public void Create(TDto dto);
        public List<TDto> Read();
        public void UpdateById(long id, TDto dto);
        public void DeleteById(long id);
        public TDto FindById(long id);
        public bool Exist(TDto dto);
    }
}
