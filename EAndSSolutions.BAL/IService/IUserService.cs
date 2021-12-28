using EAndSSolutions.Model.Model;
using EAndSSolutions.Model.RequestModel;
using EAndSSolutions.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.BAL.IService
{
    public interface IUserService
    {
        Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        Task<IEnumerable<UserVM>> GetAll();
        Task<UserVM> GetById(int id);
        Task<UserVM> AddAndUpdateUser(UserVM userObj);
    }
}
