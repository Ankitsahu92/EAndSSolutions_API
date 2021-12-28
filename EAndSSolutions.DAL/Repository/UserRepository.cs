﻿using AutoMapper;
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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly IMapper mapper;
        private readonly EAndSSolutionsContext context;

        public UserRepository(IMapper mapper, EAndSSolutionsContext context) : base(context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<UserVM> AddAndUpdateUser(UserVM userObj)
        {
            bool isSuccess = false;
            if (userObj.Id > 0)
            {
                var obj = await context.Users.SingleOrDefaultAsync(u => u.Id == userObj.Id);
                if (obj != null)
                {
                    obj.FirstName = userObj.FirstName;
                    obj.LastName = userObj.LastName;
                    obj.UserName = userObj.UserName;
                    obj.ModifiedBy = userObj.ModifiedBy;
                    obj.ModifiedOn = DateTime.Now;
                    obj.ModifiedByIP = userObj.ModifiedByIP;
                    obj.isActive = userObj.isActive;
                    if (!string.IsNullOrEmpty(userObj.Password))
                    {
                        obj.Password = userObj.Password;
                    }
                    context.Update(obj);
                    isSuccess = await context.SaveChangesAsync() > 0;
                }
            }
            else
            {
                User user = mapper.Map<User>(userObj);
                user.isActive = true;
                await context.Users.AddAsync(mapper.Map<User>(userObj));
                isSuccess = await context.SaveChangesAsync() > 0;
            }

            return isSuccess ? userObj : null;
        }

        /* public async Task<IEnumerable<CustomerSP>> getAllCustomersSP(int id)
         {
             //var param = new SqlParameter[] {
             //new SqlParameter("@id",id)
             //};
             //return await db.CustomerSP.FromSqlRaw($"exec USP_GetCustomers {string.Join(",", param.Select(s=>s.ParameterName).ToList())} ", param).ToListAsync();
             SqlParameter[] param = new SqlParameter[]{
                     new SqlParameter("@id",id)
             };
             DataSet ds = db.ExecuteProcedure("USP_GetCustomers", param);
             if (ds?.Tables?.Count > 0)
             {
                 return ds.Tables[0].AsEnumerable().Select(row =>
                      new CustomerSP
                      {
                          CustomerId = row.Field<int>("CustomerId"),
                          FirstName = row.Field<string>("FirstName"),
                          LastName = row.Field<string>("LastName"),
                          Address = row.Field<string>("Address")
                      }).ToList();
             }

             return null;
         }*/
    }
}
