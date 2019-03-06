using System;
using System.Collections.Generic;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Bangazon = new Company("Bangazon", DateTime.UtcNow);
            Employees mary = new Employees("Mary", "Assistant", DateTime.Now);
            Employees john = new Employees("John", "Clerk", DateTime.Now);
            Employees rachel = new Employees("Rachel", "Director", DateTime.Now);
            List<Employees> companyEmployees = new List<Employees>();
            // var newAddingEmployee = new Employees("Mary", "assistant", DateTime.Now);
            // addEmployees.Add(newAddingEmployee);
            companyEmployees.Add(mary);
            companyEmployees.Add(john);
            companyEmployees.Add(rachel);

            Bangazon.employees = companyEmployees;

            foreach (Employees emp in companyEmployees)
            {
                Console.WriteLine($"{emp.Name} started working on {emp.StartDate} as {emp.Title} at {Bangazon.Name}");
            }
            
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
        //class Company
        //{
        //    public string Name { get; }
        //    public DateTime CreatedOn { get; }
        //    public List<Employees> employees { get; set; }

        //    public Company(string name, DateTime createdOn)
        //    {
        //        Name = name;
        //        CreatedOn = createdOn;
        //    }
          

           

        //}
    }


}
