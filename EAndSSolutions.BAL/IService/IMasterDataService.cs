using EAndSSolutions.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.BAL.IService
{
    public interface IMasterDataService
    {
        Task<MasterDataVM?> AddAndUpdateMasterData(MasterDataVM obj);
        Task<IEnumerable<MasterDataVM>> GetGenderList();
        Task<IEnumerable<MasterDataVM>> GetStateList();
        Task<IEnumerable<MasterDataVM>> GetMaritalStatusList();
        Task<IEnumerable<MasterDataVM>> GetCaseCoordinatorList();
        Task<IEnumerable<MasterDataVM>> GetNurseList();
        Task<IEnumerable<MasterDataVM>> GetHRSupervisorList();
        Task<IEnumerable<MasterDataVM>> GetEthnicityList();
    }
}
