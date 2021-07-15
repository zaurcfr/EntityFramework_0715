using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_0715.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? EstablishDate { get; set; }
        public decimal? AnnualIncome { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
