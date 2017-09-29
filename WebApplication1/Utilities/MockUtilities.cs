using System;
using System.Collections.Generic;
using System.Globalization;
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
                    Id = Guid.Parse("429298f0-48a6-426c-8d46-a5413c130a1b"),
                    FirstName = "Richard",
                    LastName = "OConnell",
                    Email = "richard.oconnell@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("bf19a6c8-bc2a-47a9-9427-7792301f01df"),
                    FirstName = "Chris",
                    LastName = "Larsen",
                    Email = "chris.larsen@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("34f48f9d-47e1-41f7-b3b4-ebdf98db6cb3"),
                    FirstName = "Scott",
                    LastName = "Monnig",
                    Email = "scott.monnig@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("04e51d5b-6fc5-486b-b38c-9f7ab5de64b1"),
                    FirstName = "Vanessa",
                    LastName = "Soro",
                    Email = "vanessa.soro@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("5d230673-5cd3-4c29-a8d0-befbc4f6d740"),
                    FirstName = "Tony",
                    LastName = "Robinson",
                    Email = "tony.robinson@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("02b27587-3547-4c68-a508-ac01a1f0600d"),
                    FirstName = "Samanta",
                    LastName = "Balasamy",
                    Email = "samanta.balasamy@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("3a6063a4-9e38-452c-88f1-2294dd0d1738"),
                    FirstName = "Kyle",
                    LastName = "Conoly",
                    Email = "kyle.conoly@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("3bc39d91-4d59-4e9a-9615-fddfa48e6a81"),
                    FirstName = "Sean",
                    LastName = "Free",
                    Email = "sean.free@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("414d48e2-c9ee-4191-bed1-7060dbaa2bf6"),
                    FirstName = "Josh",
                    LastName = "McGinnis",
                    Email = "josh.mcginnis@ruralsourcing.com"
                },
                new Employee
                {
                    Id = Guid.Parse("a3a40477-117d-4f40-9ba4-1f2a3e23caca"),
                    FirstName = "Chris",
                    LastName = "Grant",
                    Email = "chris.grant@ruralsourcing.com"
                },
            };

            return Employees;
        }

        public static List<QRToken> GenerateQRTokens()
        {
            List<QRToken> QRTokens = new List<QRToken>
            {
                new QRToken
                {
                    Id = Guid.Parse("90c11d2b-da60-40db-948d-19092eb2bb4b"),
                    Approver = Guid.Parse("04e51d5b-6fc5-486b-b38c-9f7ab5de64b1"),
                    Expiration = DateTime.ParseExact("12/25/2018", "MM/dd/yyyy", CultureInfo.InvariantCulture),
                    Value = "d879102e-df77-419a-8e00-dea53c3008d6",
                    VisitorName = "Bill Visitor"
                }
            };
            return QRTokens;
        }
    }
}