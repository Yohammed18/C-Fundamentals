using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Rat
    {
        // Properties
        public string? Name { get; set; }
        public int Number { get; set; }
        public bool IsRadioActive { get; set; }





        // Functions





        //oveeride function
        public override string ToString()
        {
            return $"Name: {Name}\nNumber: {Number}\nIsRadioActive: {IsRadioActive}";
        }
    }
}
