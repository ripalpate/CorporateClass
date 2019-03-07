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
       // public List<Employees> employees { get; set; }
        List<Employees> employees = new List<Employees>();
     
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

        public void addEmployee(Employees newEmployee)
        {
            employees.Add(newEmployee);
        }

        public void removeEmployee(Employees fireEmployee)
        {
            employees.Remove(fireEmployee);
        }

        public void ListEmployees()
        {
            foreach (Employees emp in employees)
            {
                Console.WriteLine($"{emp.Name} started working on {emp.StartDate} as {emp.Title} ");
            }
        }

}
}
