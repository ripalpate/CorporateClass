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
           
            //add and remove employees from the list
            Bangazon.addEmployee(mary);
            Bangazon.addEmployee(john);
            Bangazon.addEmployee(rachel);
            Bangazon.addEmployee(sam);
            Bangazon.removeEmployee(sam);

            Bangazon.ListEmployees();
            
            Console.ReadLine();
        }
    }


}
