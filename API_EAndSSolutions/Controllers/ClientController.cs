using EAndSSolutions.BAL.IService;
using EAndSSolutions.Model.Model;
using EAndSSolutions.Model.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_EAndSSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService service;

        public ClientController(IClientService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClientVM obj)
        {
            obj.Id = 0;
            var response = new InsertUpdateResponse<ClientVM>();
            var result = await service.AddAndUpdateClient(obj);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Clent Added Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ClientVM obj)
        {
            var response = new InsertUpdateResponse<ClientVM>();
            var result = await service.AddAndUpdateClient(obj);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Clent Updated Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }
    }
}
