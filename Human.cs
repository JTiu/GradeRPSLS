using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_RPSLS_JAN_29
{
    class Human : Player //will need an over-ride for select gesture
    
    {
        public override void AssignGesture()
        {
            //Assign typed choice a value by index position from the List, so that the [index] position can be compared to the other Player's choice  
            Console.WriteLine("Your gesture choices are 'Rock', 'Paper', 'Scissors', 'Lizard', or 'Spock' ...  Type your gesture, then press 'Enter'. Hint: Capitalize the first letter.");
            Console.WriteLine("");            
            string input = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"'{input}' .... is a great choice, IF and ONLY IF you typing skills are up-to-par ....! Press 'Enter' to check typing....");
            Console.ReadLine();
            
            if (input == "Rock")
            {
                chosenGesture = gestureOptions[0];
                Console.WriteLine("Your typing skills are excellent!");
                Console.ReadLine();
            }
            else if (input == "Paper")
            {
                  chosenGesture = gestureOptions[1];
                Console.WriteLine("Your typing skills are excellent!");
                Console.ReadLine();
            }
            else if (input == "Scissors")
            {
                chosenGesture = gestureOptions[2];
                Console.WriteLine("Your typing skills are excellent!");
                Console.ReadLine();
            }
            else if (input == "Lizard")
            {
               chosenGesture = gestureOptions[3];
                Console.WriteLine("Your typing skills are excellent!");
                Console.ReadLine();
            }
            else if (input == "Spock")
            {
               chosenGesture = gestureOptions[4];
                Console.WriteLine("Your typing skills are excellent!");
                Console.ReadLine();
            }
           

        }

    }
    
}
