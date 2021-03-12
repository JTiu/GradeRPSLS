using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_RPSLS_JAN_29
{
    class Gesture
    {

        //Variables HAS A
         public string name;


        //Constructor: use below to create a gesture, with an incoming name, useful for the Player class

        public Gesture(string incomingName)
        {
            this.name = incomingName;
        }

    }
}
