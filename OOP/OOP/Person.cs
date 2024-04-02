using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person : User
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }
        public void talk()
        {
            Console.WriteLine($"{name} is talking.");
        }

        public void walk()
        {
            Console.WriteLine($"{name} is walking."); ;
        }
    }
}
