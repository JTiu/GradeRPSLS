using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_RPSLS_JAN_29
{
    class Program
    {//This is the class that starts the entire program, I started here, creating additional classes as I go. 
        //I reserved memory space for a "Game", that is, a "new" Game called "mygame." 
        //In that Game class, there is a method that is called "RunGame." 
        static void Main(string[] args)
        {
            Game mygame = new Game();
            mygame.RunGame();
            
        }
    }
}
