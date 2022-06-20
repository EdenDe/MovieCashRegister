using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjEden_and_Ofir
{
    class Sellers : IComparable
    {
      
        public int Sells { get; set; }

        public string Name { get; set; }


        public Sellers(string name, int sells)
        {
            Name = name;
            Sells = sells;
        }

  
        public int CompareTo(object obj)
        {
            if (obj is Sellers)
            {
                Sellers s = obj as Sellers;
                return Sells.CompareTo(s.Sells);
            }

            return 0;     

        }

     
    }
}
