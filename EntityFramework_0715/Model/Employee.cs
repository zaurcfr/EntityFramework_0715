using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_0715.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal? Salary { get; set; }
        public Company Company { get; set; }
    }
}
