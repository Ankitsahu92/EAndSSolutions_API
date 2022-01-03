using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Model.Model
{
    public class ClientVM : BaseClassVM
    {
        [Required]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Required]
        [Column(Order = 2), MaxLength(25)]
        public string BillTo { get; set; }
        [Required]
        [Column(Order = 3), MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [Column(Order = 4), MaxLength(25)]
        public string MiddleName { get; set; }
        [Required]
        [Column(Order = 5), MaxLength(25)]
        public string LastName { get; set; }
        [Required]
        [Column(Order = 6), MaxLength(15)]
        public string CellPhone { get; set; }
        [Required]
        [Column(Order = 7), MaxLength(25)]
        public string Ethnicity { get; set; }
        [Required]
        [Column(Order = 8), MaxLength(25)]
        public string Email { get; set; }
        [Required]
        [Column(Order = 9), MaxLength(25)]
        public string InsurenceID { get; set; }
        [Required]
        [Column(Order = 10), MaxLength(25)]
        public string NoOfChildren { get; set; }
        [Required]
        [Column(Order = 11), MaxLength(25)]
        public string SSN { get; set; }
        [Required]
        [Column(Order = 12), MaxLength(25)]
        public string ClientID { get; set; }
        [Required]
        [Column(Order = 13), MaxLength(25)]
        public string Gender { get; set; }
        [Required]
        [Column(Order = 14), MaxLength(25)]
        public string Nurse { get; set; }
        [Required]
        [Column(Order = 15), MaxLength(25)]
        public string CaseCoordinator { get; set; }
        [Required]
        [Column(Order = 16), MaxLength(25)]
        public string MaritalStatus { get; set; }
        [Required]
        [Column(Order = 17), MaxLength(25)]
        public string City { get; set; }
        [Required]
        [Column(Order = 18), MaxLength(25)]
        public string County { get; set; }
        [Required]
        [Column(Order = 19), MaxLength(25)]
        public string State { get; set; }
        [Required]
        [Column(Order = 20), MaxLength(15)]
        public string ZipCode { get; set; }
        [Required]
        [Column(Order = 21), MaxLength(25)]
        public string ReferredBy { get; set; }
        [Required]
        [Column(Order = 22), MaxLength(15)]
        public string CaseWorkerPhone { get; set; }
        [Required]
        [Column(Order = 23), MaxLength(15)]
        public string EmergencyContact { get; set; }
        [Required]
        [Column(Order = 24), MaxLength(25)]
        public string CaseWorkerEmail { get; set; }
    }
}
