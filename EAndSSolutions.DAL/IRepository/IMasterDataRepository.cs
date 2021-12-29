using EAndSSolutions.Model.EntityModel;
using EAndSSolutions.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.DAL.IRepository
{
    public interface IMasterDataRepository : IGenericRepository<MasterData>
    {
        Task<MasterDataVM?> AddAndUpdateMasterData(MasterDataVM obj);
    }
}
