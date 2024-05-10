using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    public class Person
    {
        private string First { get; set; }
        private string Last { get; set; }
        private DateOnly Birthday { get; set; } 

        public Person() { }


        public Person(string firstname, string lastname, DateOnly dateOnly)
        {
            First = firstname;
            Last = lastname;
            Birthday = dateOnly;
        }
    }
}
