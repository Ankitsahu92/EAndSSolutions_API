using API_EAndSSolutions.Filters;
using EAndSSolutions.BAL.IService;
using EAndSSolutions.Model.Model;
using EAndSSolutions.Model.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_EAndSSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService service;

        public UsersController(IUserService service)
        {
            this.service = service;
        }

        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticateRequest model)
        {
            //var ip = this.IpAddress();
            var response = await service.Authenticate(model);
            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(response);
        }



        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await service.GetAll());
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await service.GetById(id));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post([FromBody] UserVM userObj)
        {
            userObj.Id = 0;
            return Ok(await service.AddAndUpdateUser(userObj));
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Put([FromBody] UserVM userObj)
        {
            return Ok(await service.AddAndUpdateUser(userObj));
        }
    }
}
