using System;
using System.Collections.Generic;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //create company
            Company Bangazon = new Company("Bangazon", DateTime.UtcNow);
            //create employees
            Employees mary = new Employees("Mary", "Assistant", DateTime.Now);
            Employees john = new Employees("John", "Clerk", DateTime.Now);
            Employees rachel = new Employees("Rachel", "Director", DateTime.Now);
            Employees sam = new Employees("Sam", "Developer", DateTime.Now);
            List<Employees> companyEmployees = new List<Employees>();
            //add and remove employees from the list
            companyEmployees.Add(mary);
            companyEmployees.Add(john);
            companyEmployees.Add(rachel);
            companyEmployees.Add(sam);
            companyEmployees.Remove(sam);
            //set employees property of the company to the created list
            Bangazon.employees = companyEmployees;

            //iteration over the list to display emloyee in the company
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
