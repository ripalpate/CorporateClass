using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Company
    {
        /*
        Some readonly properties
    */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employees> employees { get; set; }
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }
        //  Company Bangazon = new Company();

}
}
