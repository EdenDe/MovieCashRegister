using System;
using System.Collections.Generic;

namespace FinalProjEden_and_Ofir
{
    class KidsMovie : Movies
    {
  
        public bool IsDubbed { get; set; }

        public KidsMovie(string name, int yearCreated, int duration, int grade, string creator, List<string> type, bool isDubbed) : base(name, yearCreated, duration, grade, creator, type)
        {
            IsDubbed = isDubbed;
        }


        public override int GetHashCode()
        {
            return MovieDuration;
        }

        public override string ToString()
        {
            return base.ToString() + (IsDubbed? "\nThe movie is Dubbed!": "\nThe Movie isn't Dubbed!");
        }

        public override bool Equals(object obj)
        {
            if (obj is KidsMovie)
            {
                return obj.GetHashCode() == GetHashCode();
            }
            return false;
        }

    }
}
