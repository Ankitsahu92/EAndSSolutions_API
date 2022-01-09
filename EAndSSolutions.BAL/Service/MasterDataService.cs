using EAndSSolutions.BAL.IService;
using EAndSSolutions.DAL.IRepository;
using EAndSSolutions.Model.Model;
using EAndSSolutions.Model.Model.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EAndSSolutions.Common.Enums.Enums;

namespace EAndSSolutions.BAL.Service
{
    public class MasterDataService : IMasterDataService
    {
        private readonly AppSettings appSettings;
        private readonly IMasterDataRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public MasterDataService(IOptions<AppSettings> _appSettings, IMasterDataRepository repository, IUnitOfWork unitOfWork)
        {
            appSettings = _appSettings.Value;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<MasterDataVM?> AddAndUpdateMasterData(MasterDataVM obj)
        {
            return await repository.AddAndUpdateMasterData(obj);
        }

        public async Task<IEnumerable<MasterDataVM>> GetGenderList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.Gender && f.isActive == true);
        }

        public async Task<IEnumerable<MasterDataVM>> GetStateList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.State && f.isActive == true);
        }

        public async Task<IEnumerable<MasterDataVM>> GetMaritalStatusList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.MaritalStatus && f.isActive == true);
        }

        public async Task<IEnumerable<MasterDataVM>> GetCaseCoordinatorList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.CaseCoordinator && f.isActive == true);
        }

        public async Task<IEnumerable<MasterDataVM>> GetNurseList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.Nurse && f.isActive == true);
        }

        public async Task<IEnumerable<MasterDataVM>> GetHRSupervisorList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.HRSupervisor && f.isActive == true);
        }
        public async Task<IEnumerable<MasterDataVM>> GetEthnicityList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.Ethnicity && f.isActive == true);
        }
        public async Task<IEnumerable<MasterDataVM>> GetClientStatusList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.ClientStatus && f.isActive == true);
        }
        public async Task<IEnumerable<MasterDataVM>> GetEmployeeStatusList()
        {
            return await unitOfWork.MasterData.Find(f => f.Type == (int)MasterDataEnums.EmployeeStatus && f.isActive == true);
        }
    }
}
