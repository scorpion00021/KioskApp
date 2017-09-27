using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class QRToken
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public DateTime Expiration { get; set; }
        public string VisitorName { get; set; }
        public Guid Approver { get; set; }
    }

    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    
}
