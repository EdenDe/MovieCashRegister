using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjEden_and_Ofir
{
    abstract class Movies
    {
        public Movies(string movieName, int yearCreated, int movieDuration, int grade, string creator, List<string> type)
        {
            Name = movieName;
            YearCreated = yearCreated;
            MovieDuration = movieDuration;
            Grade = grade;
            Creator = creator;
            Type = type;
        }

        public List<string> Type { get; set; }
  
        public int MovieDuration { get; set; }

        public int Grade { get; set; }

        public string Name { get; set; }
        
        public string Creator { get; set; }

        public int YearCreated { get; set; }
        
        public override string ToString() {

            return $"The movie {Name} was Created by {Creator} in {YearCreated},\n{Name} is {MovieDuration} minutes long" +
                $"\nand its grade last time we checked was {Grade} ";
        }
                       

    }
}
