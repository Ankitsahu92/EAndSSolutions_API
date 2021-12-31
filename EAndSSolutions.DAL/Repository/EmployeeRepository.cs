using AutoMapper;
using EAndSSolutions.DAL.IRepository;
using EAndSSolutions.Entity.Context;
using EAndSSolutions.Model.EntityModel;
using EAndSSolutions.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace EAndSSolutions.DAL.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly IMapper mapper;
        private readonly EAndSSolutionsContext context;

        public EmployeeRepository(IMapper mapper, EAndSSolutionsContext context) : base(context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<EmployeeVM?> AddAndUpdateEmployee(EmployeeVM empObj)
        {
            bool isSuccess = false;
            if (empObj.Id > 0)
            {
                var obj = await context.Users.SingleOrDefaultAsync(u => u.Id == empObj.Id);
                if (obj != null)
                {
                    obj.FirstName = empObj.FirstName;
                    obj.LastName = empObj.LastName;
                    obj.ModifiedBy = empObj.ModifiedBy;
                    obj.ModifiedOn = DateTime.Now;
                    obj.ModifiedByIP = empObj.ModifiedByIP;
                    obj.isActive = empObj.isActive;
                    
                    context.Update(obj);
                    isSuccess = await context.SaveChangesAsync() > 0;
                }
            }
            else
            {
                Employee emp = mapper.Map<Employee>(empObj);
                emp.isActive = true;
                await context.Employee.AddAsync(emp);
                int id = await context.SaveChangesAsync();
                if (id > 0)
                {
                    isSuccess = true;
                    empObj.Id = id;
                }
            }

            return isSuccess ? empObj : null;
        }
    }
}
