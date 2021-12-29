using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Model.RequestModel
{
    public class MasterDataRequest
    {
        public MasterDataRequest()
        {
            Name = "";
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool isActive { get; set; }
    }
}
