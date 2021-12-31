using EAndSSolutions.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.BAL.IService
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeVM>> GetAll();
        Task<EmployeeVM> GetById(int id);
        Task<EmployeeVM?> AddAndUpdateUser(EmployeeVM obj);
    }
}
