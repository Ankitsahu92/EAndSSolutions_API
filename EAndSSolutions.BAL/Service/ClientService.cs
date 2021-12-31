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

namespace EAndSSolutions.BAL.Service
{
    public class ClientService : IClientService
    {
        private readonly AppSettings appSettings;
        private readonly IClientRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public ClientService(IOptions<AppSettings> _appSettings, IClientRepository repository, IUnitOfWork unitOfWork)
        {
            appSettings = _appSettings.Value;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ClientVM?> AddAndUpdateUser(ClientVM obj)
        {
            return await repository.AddAndUpdateClient(obj);
        }

        public async Task<IEnumerable<ClientVM>> GetAll()
        {
            return await unitOfWork.Client.GetAll();
        }

        public async Task<ClientVM> GetById(int id)
        {
            return await unitOfWork.Client.GetById(id);
        }

    }
}
