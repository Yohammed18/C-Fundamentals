using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Expert.Class
{
    public class Car
    {
        public string name { get; set; }
        public string model { get; set; }

        public int year { get; set; }

        public  decimal price { get; set; }

        public Car(string name, string model, int year, decimal price)
        {
            this.name = name;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public Car() { }



        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"Model: {model}\n" +
                $"Year: {year}\n" +
                $"Type: {price}\n" ;
        }
        


        
    }
}
