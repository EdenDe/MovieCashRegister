using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjEden_and_Ofir
{
    class CompareSells : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Sellers && y is Sellers)
            {
                Sellers user1 = x as Sellers;
                Sellers user2 = y as Sellers;

                return user2.Sells.CompareTo(user1.Sells);
            }
            else
            {
                return 0;
            }
        }
    }
}
