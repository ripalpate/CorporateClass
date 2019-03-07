using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employees> Employees { get; set; }
       
     
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employees>();
        }

        public void AddEmployee(Employees newEmployee)
        {
            Employees.Add(newEmployee);
        }

        public void RemoveEmployee(Employees fireEmployee)
        {
            Employees.Remove(fireEmployee);
        }

        public void ListEmployees()
        {
            foreach (Employees emp in Employees)
            {
                Console.WriteLine($"{emp.Name} started working on {emp.StartDate} as {emp.Title} ");
            }
        }

}
}
