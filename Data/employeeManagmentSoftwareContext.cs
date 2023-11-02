using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using employeeManagmentSoftware.Models;

namespace employeeManagmentSoftware.Data
{
    public class employeeManagmentSoftwareContext : DbContext
    {
        public employeeManagmentSoftwareContext (DbContextOptions<employeeManagmentSoftwareContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 1,
                    EmployeeName = "John Gomez",
                    EmployeeId = 1,
                    Title = "Chief Executive Officer",
                    Salary = 250000.00,
                    Tenure = 5
                },
                new Employee()
                {
                    Id = 2,
                    EmployeeName = "Genesis Rea",
                    EmployeeId = 2,
                    Title = "Chief Operating Officer",
                    Salary = 250000.00,
                    Tenure = 5
                },
                new Employee()
                {
                    Id = 3,
                    EmployeeName = "Jane Doe",
                    EmployeeId = 3,
                    Title = "Senior Software Engineer",
                    Salary = 150000.00,
                    Tenure = 3
                },
                new Employee()
                {
                    Id=4,
                    EmployeeName = "John Doe",
                    EmployeeId = 4,
                    Title = "Engineering I",
                    Salary = 70000.00,
                    Tenure = 1
                },
                new Employee()
                {
                    Id = 5,
                    EmployeeName = "Ash Williams",
                    EmployeeId=5,
                    Title = "Marketing Specialist",
                    Salary = 85000.00,
                    Tenure = 3
                }

             );
        }

        public DbSet<employeeManagmentSoftware.Models.Employee> Employee { get; set; } = default!;
    }
}
