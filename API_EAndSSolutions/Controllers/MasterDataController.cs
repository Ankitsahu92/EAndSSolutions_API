using EAndSSolutions.BAL.IService;
using EAndSSolutions.Model.Model;
using EAndSSolutions.Model.RequestModel;
using EAndSSolutions.Model.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static EAndSSolutions.Common.Enums.Enums;

namespace API_EAndSSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class MasterDataController : ControllerBase
    {
        private readonly IMasterDataService service;

        public MasterDataController(IMasterDataService service)
        {
            this.service = service;
        }

        [HttpGet("GetGenderList")]
        public async Task<IActionResult> GetGenderList()
        {
            return Ok(await service.GetGenderList());
        }

        [HttpPost("AddUpdateGenderInfo")]
        public async Task<IActionResult> AddUpdateGenderInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.Gender
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Gender Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpGet("GetStateList")]
        public async Task<IActionResult> GetStateList()
        {
            return Ok(await service.GetStateList());
        }

        [HttpPost("AddUpdateStateInfo")]
        public async Task<IActionResult> AddUpdateStateInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.State
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "State Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpGet("GetMaritalStatusList")]
        public async Task<IActionResult> GetMaritalStatusList()
        {
            return Ok(await service.GetMaritalStatusList());
        }

        [HttpPost("AddUpdateMaritalStatusInfo")]
        public async Task<IActionResult> AddUpdateMaritalStatusInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.MaritalStatus
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "MaritalStatus Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpGet("GetNurseList")]
        public async Task<IActionResult> GetNurseList()
        {
            return Ok(await service.GetNurseList());
        }

        [HttpPost("AddUpdateNurseInfo")]
        public async Task<IActionResult> AddUpdateNurseInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.Nurse
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Nurse Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpGet("GetCaseCoordinatorList")]
        public async Task<IActionResult> GetCaseCoordinatorList()
        {
            return Ok(await service.GetCaseCoordinatorList());
        }

        [HttpPost("AddUpdateCaseCoordinatorInfo")]
        public async Task<IActionResult> AddUpdateCaseCoordinatorInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.CaseCoordinator
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Case Coordinator Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpGet("GetHRSupervisorList")]
        public async Task<IActionResult> GetHRSupervisorList()
        {
            return Ok(await service.GetHRSupervisorList());
        }

        [HttpPost("AddUpdateHRSupervisorInfo")]
        public async Task<IActionResult> AddUpdateHRSupervisorInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.HRSupervisor
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "HR Supervisor Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }
        
        [HttpGet("GetEthnicityList")]
        public async Task<IActionResult> GetEthnicityList()
        {
            return Ok(await service.GetEthnicityList());
        }

        [HttpPost("AddUpdateEthnicityInfo")]
        public async Task<IActionResult> AddUpdateEthnicityInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.Ethnicity
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Ethnicity Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpGet("GetClientStatusList")]
        public async Task<IActionResult> GetClientStatusList()
        {
            return Ok(await service.GetClientStatusList());
        }

        [HttpPost("AddUpdateClientStatusInfo")]
        public async Task<IActionResult> AddUpdateClientStatusInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.ClientStatus
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Client Status Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }

        [HttpGet("GetEmployeeStatusList")]
        public async Task<IActionResult> GetEmployeeStatusList()
        {
            return Ok(await service.GetEmployeeStatusList());
        }

        [HttpPost("AddUpdateEmployeeStatusInfo")]
        public async Task<IActionResult> AddUpdateEmployeeStatusInfo(MasterDataRequest obj)
        {
            MasterDataVM masterDataVM = new MasterDataVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                isActive = obj.isActive,
                Type = (int)MasterDataEnums.EmployeeStatus
            };
            var response = new InsertUpdateResponse<MasterDataVM>();
            var result = await service.AddAndUpdateMasterData(masterDataVM);
            if (result != null)
            {
                response.Success = true;
                response.Message = "Employee Status Added/Update Successfully !!!";
                response.Data = result;
            }
            return Ok(response);
        }
    }
}
