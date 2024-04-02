using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Classes 
    public class Movie
    {
        //noun
        private string title { get; set; }
        private string director { get; set; }
        private string rating { get; set; }

        //constructor
        public Movie() { }
        public Movie(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            this.rating = rating;
        }

        //action

    }
}
