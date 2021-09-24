using Api.Dtos;
using Api.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ServiceUserGet _serviceGet;
        private ServiceUserPost _servicePost;
        private ServiceUserEditById _serviceEditById;
        private ServiceUserDeleteById _serviceDeleteById;

        public UserController(ServiceUserGet serviceGet, ServiceUserPost servicePost, 
            ServiceUserEditById serviceEditById, ServiceUserDeleteById serviceDeleteById)
        {
            _serviceGet = serviceGet;
            _servicePost = servicePost;
            _serviceEditById = serviceEditById;
            _serviceDeleteById = serviceDeleteById;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_serviceGet.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] DtoUser dto)
        {
            return Ok(_servicePost.Post(dto));
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] DtoUser dto)
        {
            return Ok(_serviceEditById.Edit(id, dto));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            return Ok(_serviceDeleteById.Delete(id));
        }
    }
}
