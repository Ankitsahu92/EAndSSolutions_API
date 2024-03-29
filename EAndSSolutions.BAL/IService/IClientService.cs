﻿using EAndSSolutions.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.BAL.IService
{
    public interface IClientService
    {
        Task<IEnumerable<ClientVM>> GetAll();
        Task<ClientVM> GetById(int id);
        Task<ClientVM?> AddAndUpdateClient(ClientVM obj);
    }
}
