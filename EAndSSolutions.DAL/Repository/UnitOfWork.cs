using AutoMapper;
using EAndSSolutions.DAL.IRepository;
using EAndSSolutions.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EAndSSolutionsContext context;
        private readonly IMapper mapper;

        public UnitOfWork(EAndSSolutionsContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

            User = new UserRepository(mapper, context);
            //Employee = new EmployeeRepository(mapper, context);
        }
        public IUserRepository User { get; private set; }
        //public IEmployeeRepository Employee { get; private set; }
        public int Complete()
        {
            return context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await context.SaveChangesAsync();
        }
        void IDisposable.Dispose()
        {
            context.Dispose();
        }
    }
}
