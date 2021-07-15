using EntityFramework_0715.Repository;
using EntityFramework_0715.Model;
using System;
using System.Collections.Generic;

namespace EntityFramework_0715
{
    class Program
    {
        static void Main(string[] args)
        {

            var company = new Company()
            {
                Name = "StepIT",
                Address = "Koroglu Rahimov 70",
                AnnualIncome = 123123,
                EstablishDate = new DateTime(2016, 9, 1),
                Employees = new List<Employee>()
            };

            using var db = new ApplicationContext();

            var employee = new Employee()
            {
                Name = "Mamed",
                Surname = "Mamedli",
                Salary = 1000,
                BirthDate = new DateTime(2000, 1, 1),
                Company = company
            };

            db.Companies.Add(company);
            db.Employees.Add(employee);
            db.SaveChanges();
        }
    }
}
