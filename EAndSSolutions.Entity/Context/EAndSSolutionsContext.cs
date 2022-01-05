using EAndSSolutions.Model.EntityModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EAndSSolutions.Common.Enums.Enums;

namespace EAndSSolutions.Entity.Context
{
    public class EAndSSolutionsContext : DbContext
    {
        public EAndSSolutionsContext(DbContextOptions<EAndSSolutionsContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MasterData> MasterDatas { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "",
                    UserName = "System@gmail.com",
                    Password = "System@1234",
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now
                }
            );

            modelBuilder.Entity<MasterData>().HasData(
                new MasterData
                {
                    Id = 1,
                    Name = "Male",
                    Type = (int)MasterDataEnums.Gender,
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now
                },
                new MasterData
                {
                    Id = 2,
                    Name = "Female",
                    Type = (int)MasterDataEnums.Gender,
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now
                },
                new MasterData
                {
                    Id = 3,
                    Name = "Nurse 1",
                    Type = (int)MasterDataEnums.Nurse,
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now
                },
                new MasterData
                {
                    Id = 4,
                    Name = "Nurse 2",
                    Type = (int)MasterDataEnums.Nurse,
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now
                },
                new MasterData
                {
                    Id = 5,
                    Name = "New York",
                    Type = (int)MasterDataEnums.State,
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now
                },
                 new MasterData
                 {
                     Id = 6,
                     Name = "Case Coordinator 1",
                     Type = (int)MasterDataEnums.CaseCoordinator,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 7,
                     Name = "Case Coordinator 2",
                     Type = (int)MasterDataEnums.CaseCoordinator,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 8,
                     Name = "HR Supervisor 1",
                     Type = (int)MasterDataEnums.HRSupervisor,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 9,
                     Name = "HR Supervisor 2",
                     Type = (int)MasterDataEnums.HRSupervisor,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 10,
                     Name = "Ethnicity 1",
                     Type = (int)MasterDataEnums.Ethnicity,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 11,
                     Name = "Ethnicity 2",
                     Type = (int)MasterDataEnums.Ethnicity,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 12,
                     Name = "Married",
                     Type = (int)MasterDataEnums.MaritalStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 13,
                     Name = "Single",
                     Type = (int)MasterDataEnums.MaritalStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 14,
                     Name = "Divorced",
                     Type = (int)MasterDataEnums.MaritalStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 },
                 new MasterData
                 {
                     Id = 15,
                     Name = "Separated",
                     Type = (int)MasterDataEnums.MaritalStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 16,
                     Name = "Start of Care",
                     Type = (int)MasterDataEnums.ClientStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 17,
                     Name = "Admitted Date",
                     Type = (int)MasterDataEnums.ClientStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 18,
                     Name = "Inquiry",
                     Type = (int)MasterDataEnums.ClientStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 19,
                     Name = "Discharge",
                     Type = (int)MasterDataEnums.ClientStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 20,
                     Name = "Inactive",
                     Type = (int)MasterDataEnums.ClientStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 21,
                     Name = "Active",
                     Type = (int)MasterDataEnums.ClientStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 22,
                     Name = "Applicant",
                     Type = (int)MasterDataEnums.EmployeeStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 23,
                     Name = "Active",
                     Type = (int)MasterDataEnums.EmployeeStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 24,
                     Name = "Inactive",
                     Type = (int)MasterDataEnums.EmployeeStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 25,
                     Name = "Terminated",
                     Type = (int)MasterDataEnums.EmployeeStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }, new MasterData
                 {
                     Id = 26,
                     Name = "Quit",
                     Type = (int)MasterDataEnums.EmployeeStatus,
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now
                 }
            );
        }
    }
}
