using System;
using System.Collections.Generic;

namespace FinalProjEden_and_Ofir
{

    class AllAgesMovies : Movies
    {
      
        public int AgeLimit { get; set; }

        public AllAgesMovies(string name, int yearCreated, int duration, int grade, string creator, List<string> type, int ageLimit) : base(name, yearCreated, duration, grade, creator, type)
        {
            AgeLimit = ageLimit;
        }
   
 
        public override string ToString()
        {
            return base.ToString() + $"\nOnly those about the age {AgeLimit} can enter the movie";
        }

    }
}
