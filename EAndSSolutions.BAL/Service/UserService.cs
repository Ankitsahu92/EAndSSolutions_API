﻿using EAndSSolutions.BAL.IService;
using EAndSSolutions.DAL.IRepository;
using EAndSSolutions.Model.Model;
using EAndSSolutions.Model.Model.Common;
using EAndSSolutions.Model.RequestModel;
using EAndSSolutions.Model.ResponseModel;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.BAL.Service
{
    public class UserService : IUserService
    {
        private readonly AppSettings appSettings;
        private readonly IUserRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IOptions<AppSettings> _appSettings, IUserRepository repository, IUnitOfWork unitOfWork)
        {
            appSettings = _appSettings.Value;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            //var hashPwd = BCrypt.HashPassword("test");
            var user = (await unitOfWork.User.Find(x => x.UserName == model.Username && x.Password == model.Password)).FirstOrDefault();
            //await db.Users.SingleOrDefaultAsync(x => x.Username == model.Username && x.Password == model.Password);

            // return null if user not found
            if (user == null || user.Password != model.Password) return null;

            // authentication successful so generate jwt token
            var token = await generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public async Task<IEnumerable<UserVM>> GetAll()
        {
            return await unitOfWork.User.GetAll();
        }

        public async Task<UserVM> GetById(int id)
        {
            return await unitOfWork.User.GetById(id);
        }

        public async Task<UserVM> AddAndUpdateUser(UserVM userObj)
        {
            return await repository.AddAndUpdateUser(userObj);
        }
        // helper methods
        private async Task<string> generateJwtToken(UserVM user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = await Task.Run(() =>
            {

                var key = Encoding.ASCII.GetBytes(appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()), new Claim("UserName", user.UserName.ToString()), new Claim("FirstName", user.FirstName.ToString()) }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                return tokenHandler.CreateToken(tokenDescriptor);
            });

            return tokenHandler.WriteToken(token);
        }
    }
}
