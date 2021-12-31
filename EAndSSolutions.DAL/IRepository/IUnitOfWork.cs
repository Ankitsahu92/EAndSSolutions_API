using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.DAL.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        IMasterDataRepository MasterData { get; }

        IEmployeeRepository Employee { get; }
        IClientRepository Client { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}
