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
                var obj = await context.Employee.SingleOrDefaultAsync(u => u.Id == empObj.Id);
                if (obj != null)
                {
                    obj.ZipCode = empObj.ZipCode;
                    obj.Status = empObj.Status;
                    obj.State = empObj.State;
                    obj.SSN = empObj.SSN;
                    obj.CellPhone = empObj.CellPhone;
                    obj.City = empObj.City;
                    obj.County = empObj.County;
                    obj.DateOfFirstCase = empObj.DateOfFirstCase;
                    obj.DateOfHire = empObj.DateOfHire;
                    obj.DOB = empObj.DOB;
                    obj.Email = empObj.Email;
                    obj.EmergencyContact = empObj.EmergencyContact;
                    obj.EmergencyPhone = empObj.EmergencyPhone;
                    obj.EmployeeID = empObj.EmployeeID;
                    obj.Ethnicity = empObj.Ethnicity;
                    obj.FirstName = empObj.FirstName;
                    obj.Gender = empObj.Gender;
                    obj.LastName = empObj.LastName;
                    obj.HomePhone = empObj.HomePhone;
                    obj.HRSupervisor = empObj.HRSupervisor;
                    obj.isActive = empObj.isActive;
                    obj.MaritalStatus = empObj.MaritalStatus;
                    obj.MiddleName = empObj.MiddleName;
                    obj.ModifiedBy = empObj.ModifiedBy;
                    obj.ModifiedByIP = empObj.ModifiedByIP;
                    obj.ModifiedOn = DateTime.Now;
                    context.Update(obj);
                    isSuccess = await context.SaveChangesAsync() > 0;
                }
            }
            else
            {
                Employee emp = mapper.Map<Employee>(empObj);
                emp.isActive = true;
                emp.CreatedOn = DateTime.Now;
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
