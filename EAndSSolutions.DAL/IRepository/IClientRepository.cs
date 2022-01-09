using EAndSSolutions.Model.EntityModel;
using EAndSSolutions.Model.Model;

namespace EAndSSolutions.DAL.IRepository
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<ClientVM?> AddAndUpdateClient(ClientVM obj);
    }
}
