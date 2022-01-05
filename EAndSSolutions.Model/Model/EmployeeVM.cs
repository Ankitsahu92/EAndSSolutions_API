using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Model.Model
{
    public class EmployeeVM : BaseClassVM
    {
        [Required]
        [Column(Order = 0)]
        public int Id { get; set; }
        [Required]
        [Column(Order = 1),MaxLength(25)]
        public string SSN { get; set; }
        [Required]
        [Column(Order = 2), MaxLength(25)]
        public string FirstName { get; set; }

        [Column(Order = 3), MaxLength(25)]
        public string MiddleName { get; set; }
        [Required]
        [Column(Order = 4), MaxLength(25)]
        public string LastName { get; set; }
        [Required]
        [Column(Order = 5), MaxLength(15)]
        public string CellPhone { get; set; }
        [Required]
        [Column(Order = 6), MaxLength(15)]
        public string HomePhone { get; set; }
        [Required]
        [Column(Order = 7), MaxLength(25)]
        public string Email { get; set; }

        [Column(Order = 8)]
        public DateTime? DateOfHire { get; set; }
        [Column(Order = 9)]
        public DateTime? DateOfFirstCase { get; set; }
        [Required]
        [Column(Order = 10), MaxLength(25)]
        public string EmployeeID { get; set; }
        [Required, MaxLength(25)]
        public string Gender { get; set; }
        [Required]
        [Column(Order = 11), MaxLength(25)]
        public string HRSupervisor { get; set; }
        [Column(Order = 12), MaxLength(25)]
        public string Ethnicity { get; set; }
       
        [Required, MaxLength(25)]
        [Column(Order = 13)]
        public string City { get; set; }
        [Required]
        [Column(Order = 14), MaxLength(25)]
        public string County { get; set; }
        [Required]
        [Column(Order = 15), MaxLength(25)]
        public string State { get; set; }
        [Required]
        [Column(Order = 16), MaxLength(15)]
        public string ZipCode { get; set; }
        [Required]
        [Column(Order = 17), MaxLength(15)]
        public string EmergencyPhone { get; set; }
        [Required]
        [Column(Order = 18), MaxLength(15)]
        public string EmergencyContact { get; set; }
        [Required]
        [Column(Order = 19), MaxLength(25)]
        public string MaritalStatus { get; set; }

        [Required]
        [Column(Order = 20)]
        public DateTime DOB { get; set; }
    }
}
