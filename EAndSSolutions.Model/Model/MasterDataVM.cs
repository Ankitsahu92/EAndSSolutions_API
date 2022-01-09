using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Model.Model
{
    public class MasterDataVM : BaseClassVM
    {
        public MasterDataVM()
        {
            Name = "";
        }

        [Required]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(Order = 2)]
        public string Name { get; set; }

        [Required]
        [Column(Order = 3)]
        public int Type { get; set; }

    }
}
