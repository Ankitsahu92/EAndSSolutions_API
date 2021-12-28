using AutoMapper;
using EAndSSolutions.Model.EntityModel;
using EAndSSolutions.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Common.AutoMapper
{
    public class AutoMapperRequestProfile : Profile
    {
        public AutoMapperRequestProfile()
        {
            CreateMap<User, UserVM>().ReverseMap();
            //CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
