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
    public class MasterDataRepository : GenericRepository<MasterData>, IMasterDataRepository
    {
        private readonly IMapper mapper;
        private readonly EAndSSolutionsContext context;

        public MasterDataRepository(IMapper mapper, EAndSSolutionsContext context) : base(context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<MasterDataVM?> AddAndUpdateMasterData(MasterDataVM dataObj)
        {
            bool isSuccess = false;
            if (dataObj.Id > 0)
            {
                var obj = await context.MasterDatas.SingleOrDefaultAsync(u => u.Id == dataObj.Id);
                if (obj != null)
                {
                    obj.Name = dataObj.Name;
                    obj.Type = dataObj.Type;
                    obj.ModifiedBy = dataObj.ModifiedBy;
                    obj.ModifiedOn = DateTime.Now;
                    obj.ModifiedByIP = dataObj.ModifiedByIP;
                    obj.isActive = dataObj.isActive;
                    context.Update(obj);
                    isSuccess = await context.SaveChangesAsync() > 0;
                }
            }
            else
            {
                MasterData newObject = mapper.Map<MasterData>(dataObj);
                newObject.isActive = true;
                await context.MasterDatas.AddAsync(newObject);
                int id = await context.SaveChangesAsync();
                if(id > 0)
                {
                    isSuccess = true;
                    //dataObj.Id= id;
                }
                
            }

            return isSuccess ? dataObj : null;
        }
    }
}
