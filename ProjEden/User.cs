using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjEden_and_Ofir
{
    class User 
    {
        public string Username { get; set; }

        public int Password { get; set; }

        public int howManyTicketsSold { get; set; }


        public User(string name, int password)
        {
            Username = name;
            Password = password;

            howManyTicketsSold = 0;
        }


        public override string ToString()
        {
            return $"user Name ={Username}, password ={Password}";
        }

      
    }
}
