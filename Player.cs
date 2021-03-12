using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_RPSLS_JAN_29
{
    class Player  /*A player will play "the Game". Player can choose from a list of "Gestures", so one variable will be a list of gestures. 
                   The player will also "assign" a gesture, so at least one method will be called "AssignGesture".  
                   As gestures have their own set of variables and  methods, I will have another class, "Gesture"*/
    {
        //Variables HAS
        public List<Gesture> gestureOptions;
        public Gesture chosenGesture;
       public int scorePlayer;

     
       
        public Player()
        {
            gestureOptions = new List<Gesture>();
            Gesture gestureChoice1 = new Gesture("Rock");
            Gesture gestureChoice2 = new Gesture("Paper");
            Gesture gestureChoice3 = new Gesture("Scissors");
            Gesture gestureChoice4 = new Gesture("Lizard");
            Gesture gestureChoice5 = new Gesture("Spock");

            gestureOptions.Add(gestureChoice1);
            gestureOptions.Add(gestureChoice2);
            gestureOptions.Add(gestureChoice3);
            gestureOptions.Add(gestureChoice4);
            gestureOptions.Add(gestureChoice5);
            gestureOptions.Add(gestureChoice5);
        }

            public virtual void AssignGesture()//does not need to return a result, so "void"
            {
             
            
                       
            }
            public void SelectGesture()
            {

            }


            public void CompareGestures()
            {

            }
        public void LoopKeepScore()
           
        {

        }





    }




        //Constructor Spawn


        //Method  CAN DO
    
}
