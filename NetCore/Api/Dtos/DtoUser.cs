using Api.Entities;
using System;

namespace Api.Dtos
{
    public class DtoUser
    {
        public long Id { get; set; }
        public Guid? Uuid { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public User DtoToEntity()
        {
            return new User
            {
                Id = Id,
                Uuid = Uuid,
                Name = Name,
                Username = Username,
                Password = Password,
                CreatedBy = CreatedBy,
                UpdatedBy = UpdatedBy,
                CreationDate = CreationDate,
                UpdateDate = UpdateDate
            };
        }

        public static DtoUser EntityToDto(User user)
        {
            return new DtoUser
            {
                Id = user.Id,
                Uuid = user.Uuid,
                Name = user.Name,
                Username = user.Username,
                Password = user.Password,
                CreatedBy = user.CreatedBy,
                UpdatedBy = user.UpdatedBy,
                CreationDate = user.CreationDate,
                UpdateDate = user.UpdateDate
            };
        }
    }
}
