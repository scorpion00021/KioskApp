using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Utilities
{
    public static class MockUtilities
    {
        public static List<Employee> GenerateMockEmployeeList()
        {
            List<Employee> Employees = new List<Employee>
            {
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Richard",
                    LastName = "OConnell",
                    Email = "richard.oconnell@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Chris",
                    LastName = "Larsen",
                    Email = "chris.larsen@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Scott",
                    LastName = "Monnig",
                    Email = "scott.monnig@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Vanessa",
                    LastName = "Soro",
                    Email = "vanessa.soro@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Tony",
                    LastName = "Robinson",
                    Email = "tony.robinson@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Samanta",
                    LastName = "Balasamy",
                    Email = "samanta.balasamy@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Kyle",
                    LastName = "Conoly",
                    Email = "kyle.conoly@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Sean",
                    LastName = "Free",
                    Email = "sean.free@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Josh",
                    LastName = "McGinnis",
                    Email = "josh.mcginnis@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Chris",
                    LastName = "Grant",
                    Email = "chris.grant@ruralsourcing.com"
                },
            };

            return Employees;
        }
    }
}