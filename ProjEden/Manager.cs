using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjEden_and_Ofir
{
    class Manager : User
    {
        public int AccessCode { get; set; }

        public Manager(string name, int password, int accesscode) : base(name, password)
        {
            AccessCode = accesscode;
        }


        public override string ToString()
        {
            return base.ToString() + $", AccessCode ={AccessCode}";
        }

    }
}
