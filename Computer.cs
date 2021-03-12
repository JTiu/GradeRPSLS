using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_RPSLS_JAN_29
{
    class Computer : Player ///will need an override ofr a random assignment of the variable
        

        //variable
        
    {
        public override void AssignGesture()
        {
            Console.WriteLine("Now, the Computer will choose a gesture:  ");
            Console.WriteLine("");
            Random random = new Random();
            int computerRandomChoice = random.Next(5);

            chosenGesture = gestureOptions[computerRandomChoice];
            Console.WriteLine("The Computer's random-assigned gesture is NOT a secret: '" + chosenGesture.name + "' ... We can hide the Computer's gesture, later!");
            Console.ReadLine();
        }
    }
}
