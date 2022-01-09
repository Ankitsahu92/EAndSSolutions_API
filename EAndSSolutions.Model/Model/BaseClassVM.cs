using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Model.Model
{
    public class BaseClassVM
    {
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [MaxLength(25)]
        public string? CreatedByIP { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        [MaxLength(25)]
        public string? ModifiedByIP { get; set; }
        public bool isActive { get; set; } = true;
    }
}
