using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getandset
{
    class Movie
    {
        public string title;
        public string instruktør;
        private string rating;

        public Movie(string atitle, string ainstruktør, string arating)
        {
            title = atitle;
            instruktør = ainstruktør;
            Rating = arating;

        }

        public string Rating
        {
            get { return rating; }
            set 
            { 
                if(value == "G" || value =="PG"|| value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
