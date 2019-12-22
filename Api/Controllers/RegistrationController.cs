using Application.Service;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController
    {
        //injecting service to controller
        public RegistrationController(RegistrationService registrationService)
        {

        }

        //Register User
        [HttpPost]
        public ActionResult<string> Register([FromBody] User user)
        {
            
            return "status";
        }

        //Get User
        [HttpGet("{id}")]
        public ActionResult<User> Get()
        {
            return null;
        }
        
    }
}