using EAndSSolutions.Model.EntityModel;
using EAndSSolutions.Model.Model;

namespace EAndSSolutions.DAL.IRepository
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<EmployeeVM?> AddAndUpdateEmployee(EmployeeVM obj);
    }
}
