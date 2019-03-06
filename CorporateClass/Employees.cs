using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Employees
    {
        //Properties
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employees(string name, string title, DateTime startDate)
        {
            Name = name;
            Title = title;
            StartDate = startDate;
        }
    }
    
}
