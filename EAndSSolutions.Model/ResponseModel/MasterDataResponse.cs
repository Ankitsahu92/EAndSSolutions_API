using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Model.ResponseModel
{
    public class MasterDataResponse
    {
        public MasterDataResponse()
        {
            Name = "";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
