using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Employee
    {
        //Fiels
        private string name { get; set; }
        private int employeeId { get;  }
        private double salary { get; }

        public Employee() { }

        public Employee(string name, int employeeId, double salary) { 
            this.name = name;
            this.employeeId = employeeId;
            this.salary = salary;
        }

        // Properties to access get and seters

      
    }
}
