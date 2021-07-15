using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_0715.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTimeOffset CreationDate { get; set; }
    }
}
