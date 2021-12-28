using EAndSSolutions.Model.EntityModel;
using EAndSSolutions.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.DAL.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<UserVM> AddAndUpdateUser(UserVM userObj);
    }
}
