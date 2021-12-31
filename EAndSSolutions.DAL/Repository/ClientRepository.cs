using AutoMapper;
using EAndSSolutions.DAL.IRepository;
using EAndSSolutions.Entity.Context;
using EAndSSolutions.Model.EntityModel;
using EAndSSolutions.Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.DAL.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        private readonly IMapper mapper;
        private readonly EAndSSolutionsContext context;

        public ClientRepository(IMapper mapper, EAndSSolutionsContext context) : base(context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<ClientVM?> AddAndUpdateClient(ClientVM userObj)
        {
            bool isSuccess = false;
            if (userObj.Id > 0)
            {
                var obj = await context.Users.SingleOrDefaultAsync(u => u.Id == userObj.Id);
                if (obj != null)
                {
                    obj.FirstName = userObj.FirstName;
                    obj.LastName = userObj.LastName;
                    obj.ModifiedBy = userObj.ModifiedBy;
                    obj.ModifiedOn = DateTime.Now;
                    obj.ModifiedByIP = userObj.ModifiedByIP;
                    obj.isActive = userObj.isActive;
                    
                    context.Update(obj);
                    isSuccess = await context.SaveChangesAsync() > 0;
                }
            }
            else
            {
                Client user = mapper.Map<Client>(userObj);
                user.isActive = true;
                await context.Client.AddAsync(user);
                int id = await context.SaveChangesAsync();
                if (id > 0)
                {
                    isSuccess = true;
                    userObj.Id = id;
                }
            }

            return isSuccess ? userObj : null;
        }


    }
}
