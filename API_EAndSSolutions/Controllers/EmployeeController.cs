using EAndSSolutions.BAL.IService;
using EAndSSolutions.Model.Model;
using EAndSSolutions.Model.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_EAndSSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
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
        public async Task<IActionResult> Post([FromBody] EmployeeVM obj)
        {
            obj.Id = 0;
            var response = new InsertUpdateResponse<EmployeeVM>();
            var result = await service.AddAndUpdateEmployee(obj);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Employee Added Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] EmployeeVM obj)
        {
            var response = new InsertUpdateResponse<EmployeeVM>();
            var result = await service.AddAndUpdateEmployee(obj);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Employee Updated Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }
    }
}
