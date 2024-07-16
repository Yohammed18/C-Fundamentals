using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class RealEstate
    {
        public string? Address { get; set; }
        public int Price { get; set; }
        public int SquareFootage { get; set; }

        //2024 version of creating a function.
        public int CalculatePricePerSquareFoot() => Price / SquareFootage;
      




    }
}
