using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Car
    {
        private string brand {  get; set; }
        private string model { get; set; }
        private int year { get; set; }
        private string color { get; set; }

        public Car() { }

        public Car(string brand, string model, int year, string color)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
        }


        public string Color
        {
            get { return color; }
            set { this.color = value; }
        }

        public string Brand
        {
            set { this.brand = value; }
            get { return brand; }
        }

        public int Year
        {
            get { return year; }
            set { this.year = value; }
        }

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }





        public void drive()
        {
            Console.WriteLine($"Your {brand} is driving.\n");
        }

        override
        public string ToString()
        {
            return $"brand: {brand}\n" +
                $"model: {model}\n" +
                $"year: {year}\n";
        }


    }
}
