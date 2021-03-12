using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_RPSLS_JAN_29
{
    public class Game //make this "public" so the computer can read this file from other classes. 
    {
        //Variables
        //the user story tells me there are two players, so, Player1 and Player2. 
        //As these players will have different variables, there is a separate class for "Players"
        Player Player1;
        Player Player2;


        //"RunGame" has several methods, including "Chose" "Select", "Compare", and "Declare"
        public void RunGame()
        {
            Console.WriteLine("Welcome to RPSLS! Shall we play a game? Press 'Enter'");
            Console.ReadLine();
            ChoosePlayers();

            do 
            {
                AssignGestures();
                CompareGestures();

            }
            while (Player1.scorePlayer < 2 && Player2.scorePlayer < 2);

            if (Player1.scorePlayer == 2)
            {
                Console.WriteLine("Player1 is the winner!!!");
                Console.ReadLine();
            }
            else if (Player2.scorePlayer == 2)
            {
                Console.WriteLine("Player2 is the winner!!!");
                Console.ReadLine();
            }
            
        }
        public void ChoosePlayers() //does not need to return a result, so "void"
        {
            Player1 = new Human();
            Console.WriteLine("In this game, Player1 is always a 'Human'.  You may choose either 'Computer' or 'Human' for Player2.");
            Console.WriteLine("");
            Console.WriteLine("If Player2 is a Human, enter '1', if you want to play the Computer, enter '2'.");
            string choiceInput = Console.ReadLine();
            if (choiceInput == "1")
            {
                Player2 = new Human();
                Console.WriteLine("");
                Console.WriteLine("Player2 is a Human.");
                Console.ReadLine();
            }
            else if (choiceInput == "2")
            {
                Player2 = new Computer();
                Console.WriteLine("");
                Console.WriteLine("Player2 is a Computer.");
                Console.ReadLine();
            }

        }  
        public void AssignGestures()
        {
            
            Player1.AssignGesture();
            Player2.AssignGesture();
        }
        public void CompareGestures()
        {
            
            
                if (Player1.chosenGesture.name == "Rock" && Player2.chosenGesture.name == "Scissors") //else if
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked rock, Player 2 picked scissors, Player 1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Rock" && Player2.chosenGesture.name == "Paper")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked rock, Player 2 picked paper, Player 2 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Rock" && Player2.chosenGesture.name == "Lizard")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked rock, Player 2 picked lizard, Player 1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Rock" && Player2.chosenGesture.name == "Spock")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked rock, Player 2 picked spock, Player 2 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Rock" && Player2.chosenGesture.name == "Rock")
                {

                    Console.WriteLine("Player 1 picked rock, Player 2 picked rock, it is a tie");
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Paper" && Player2.chosenGesture.name == "Scissors")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked paper, Player 2 picked scissors, Player 2 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Paper" && Player2.chosenGesture.name == "Lizard")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked paper, Player 2 picked lizard, Player 2 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Paper" && Player2.chosenGesture.name == "Spock")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked paper, Player 2 picked spock, Player 1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Paper" && Player2.chosenGesture.name == "Rock")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked paper, Player 2 picked rock, Player1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Paper" && Player2.chosenGesture.name == "Paper")
                {

                    Console.WriteLine("Player 1 picked paper, Player 2 picked paper, it is a tie");
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Scissors" && Player2.chosenGesture.name == "Lizard")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked scissors, Player 2 picked lizard, Player 1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Scissors" && Player2.chosenGesture.name == "Spock")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked scissors, Player 2 picked spock, Player 2 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Scissors" && Player2.chosenGesture.name == "Scissors")
                {

                    Console.WriteLine("Player 1 picked scissors, Player 2 picked scissors, it is a tie");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Scissors" && Player2.chosenGesture.name == "Rock")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked scissors, Player 2 picked rock, Player2");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Scissors" && Player2.chosenGesture.name == "Paper")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked scissors, Player 2 picked paper, Player 1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Lizard" && Player2.chosenGesture.name == "Spock")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked lizard, Player 2 picked spock, Player 1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }

                else if (Player1.chosenGesture.name == "Lizard" && Player2.chosenGesture.name == "Lizard")
                {

                    Console.WriteLine("Player 1 picked lizard, Player 2 picked lizard, it is a tie");
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Lizard" && Player2.chosenGesture.name == "Scissors")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked lizard, Player 2 picked spock, Player1");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Lizard" && Player2.chosenGesture.name == "Rock")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked lizard, Player 2 picked rock, Player2 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Lizard" && Player2.chosenGesture.name == "Paper")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked lizard, Player 2 picked paper, Player1");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Spock" && Player2.chosenGesture.name == "Spock")
                {

                    Console.WriteLine("Player 1 picked spock, Player 2 picked spock, it is a tie");
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Spock" && Player2.chosenGesture.name == "Lizard")
                {
                    Player2.scorePlayer++;
                    Console.WriteLine("Player 1 picked spock, Player 2 picked lizard, Player1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player2's score is " + Player2.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Spock" && Player2.chosenGesture.name == "Scissors")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked spock, Player 2 picked scissors, Player1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Spock" && Player2.chosenGesture.name == "Rock")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked spock, Player 2 picked rock, Player1 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else if (Player1.chosenGesture.name == "Spock" && Player2.chosenGesture.name == "Paper")
                {
                    Player1.scorePlayer++;
                    Console.WriteLine("Player 1 picked spock, Player 2 picked paper, Player2 wins");
                    Console.WriteLine("");
                    Console.WriteLine("Player1's score is " + Player1.scorePlayer);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please check your input");
                    Console.ReadLine();
                }
            
                       

        }

    }
}
