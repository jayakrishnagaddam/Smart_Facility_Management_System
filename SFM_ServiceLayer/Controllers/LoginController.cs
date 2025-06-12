using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SFM_DataAccessLayer;

namespace SFM_ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly Repository _repository;

        public LoginController(Repository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public JsonResult AuthenticateUser([FromBody] IUserCredentials userCredentials)
        {
            if (userCredentials == null)
            {
                return Json(new { success = false, message = "Invalid user credentials." });
            }
            var isAuthenticated = _repository.AuthenticateUser(userCredentials);
            return Json(new { success = isAuthenticated, message = isAuthenticated ? "Login successful." : "Invalid email or password." });

        }
    }
}
