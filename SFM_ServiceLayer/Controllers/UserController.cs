using Microsoft.AspNetCore.Mvc;
using SFM_DataAccessLayer;
using SFM_DataAccessLayer.Models;
namespace SFM_ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly Repository _repository;

        public UserController(Repository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public JsonResult AddUser([FromBody] User user)
        {
            var result = _repository.AddUser(user);
            return Json(result);
        }

        [HttpGet]
        public JsonResult GetAllUsers()
        {
            var users = _repository.GetAllUsers();
            return Json(users);
        }

        [HttpPut]
        public JsonResult UpdateUser([FromBody] User user)
        {
            var result = _repository.UpdateUser(user);
            return Json(result);
        }

        [HttpDelete("RemoveUser/{userId}")]
        public JsonResult RemoveUser(int userId)
        {
            var result = _repository.RemoveUser(userId);
            return Json(new { success = result });
        }
    }
}
