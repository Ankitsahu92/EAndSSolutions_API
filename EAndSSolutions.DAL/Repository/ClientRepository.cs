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

        public async Task<ClientVM?> AddAndUpdateClient(ClientVM clientObj)
        {
            bool isSuccess = false;
            if (clientObj.Id > 0)
            {
                var obj = await context.Client.SingleOrDefaultAsync(u => u.Id == clientObj.Id);
                if (obj != null)
                {
                    obj.BillTo = clientObj.BillTo;
                    obj.CaseCoordinator = clientObj.CaseCoordinator;
                    obj.CaseWorkerEmail = clientObj.CaseWorkerEmail;
                    obj.CaseWorkerPhone = clientObj.CaseWorkerPhone;
                    obj.CellPhone = clientObj.CellPhone;
                    obj.City = clientObj.City;
                    obj.ClientID = clientObj.ClientID;
                    obj.County = clientObj.County;
                    obj.Email = clientObj.Email;
                    obj.EmergencyContact = clientObj.EmergencyContact;
                    obj.Ethnicity = clientObj.Ethnicity;
                    obj.FirstName = clientObj.FirstName;
                    obj.Gender = clientObj.Gender;
                    obj.InsurenceID = clientObj.InsurenceID;
                    obj.isActive = clientObj.isActive;
                    obj.LastName = clientObj.LastName;
                    obj.MaritalStatus = clientObj.MaritalStatus;
                    obj.MiddleName = clientObj.MiddleName;
                    obj.ModifiedBy = clientObj.ModifiedBy;
                    obj.ModifiedByIP = clientObj.ModifiedByIP;
                    obj.ModifiedOn = DateTime.Now;
                    obj.NoOfChildren = clientObj.NoOfChildren;
                    obj.Nurse = clientObj.Nurse;
                    obj.ReferredBy = clientObj.ReferredBy;
                    obj.SSN = clientObj.SSN;
                    obj.State = clientObj.State;
                    obj.Status = clientObj.Status;
                    obj.ZipCode = clientObj.ZipCode;
                    context.Update(obj);
                    isSuccess = await context.SaveChangesAsync() > 0;
                }
            }
            else
            {
                Client client = mapper.Map<Client>(clientObj);
                client.isActive = true;
                client.CreatedOn = DateTime.Now;
                await context.Client.AddAsync(client);
                int id = await context.SaveChangesAsync();
                if (id > 0)
                {
                    isSuccess = true;
                    clientObj.Id = id;
                }
            }

            return isSuccess ? clientObj : null;
        }


    }
}
