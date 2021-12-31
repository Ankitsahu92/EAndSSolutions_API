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
    public class EmployeeService : IEmployeeService
    {
        private readonly AppSettings appSettings;
        private readonly IEmployeeRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IOptions<AppSettings> _appSettings, IEmployeeRepository repository, IUnitOfWork unitOfWork)
        {
            appSettings = _appSettings.Value;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<EmployeeVM?> AddAndUpdateUser(EmployeeVM obj)
        {
            return await repository.AddAndUpdateEmployee(obj);
        }

        public async Task<IEnumerable<EmployeeVM>> GetAll()
        {
            return await unitOfWork.Employee.GetAll();
        }

        public async Task<EmployeeVM> GetById(int id)
        {
            return await unitOfWork.Employee.GetById(id);
        }

    }
}
