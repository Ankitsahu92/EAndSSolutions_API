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
        [Column(Order = 1)]
        public string SSN { get; set; }
        [Required]
        [Column(Order = 2)]
        public string FirstName { get; set; }
        [Required]
        [Column(Order = 3)]
        public string MiddleName { get; set; }
        [Required]
        [Column(Order = 4)]
        public string LastName { get; set; }
        [Required]
        [Column(Order = 5)]
        public string CellPhone { get; set; }
        [Required]
        [Column(Order = 6)]
        public string HomePhone { get; set; }
        [Required]
        [Column(Order = 7)]
        public string Email { get; set; }
        [Required]
        [Column(Order = 8)]
        public DateTime DateOfHire { get; set; }
        [Required]
        [Column(Order = 9)]
        public DateTime DateOfFirstCase { get; set; }
        [Required]
        [Column(Order = 10)]
        public string EmployeeID { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Column(Order = 11)]
        public string HRSupervisor { get; set; }
        [Required]
        [Column(Order = 12)]
        public string Ethnicity { get; set; }
       
        [Required]
        [Column(Order = 13)]
        public string City { get; set; }
        [Required]
        [Column(Order = 14)]
        public string County { get; set; }
        [Required]
        [Column(Order = 15)]
        public string State { get; set; }
        [Required]
        [Column(Order = 16)]
        public string ZipCode { get; set; }
        [Required]
        [Column(Order = 17)]
        public string EmergencyPhone { get; set; }
        [Required]
        [Column(Order = 18)]
        public string EmergencyContact { get; set; }
        [Required]
        [Column(Order = 19)]
        public string MaritalStatus { get; set; }

        [Required]
        [Column(Order = 20)]
        public DateTime DOB { get; set; }
    }
}
