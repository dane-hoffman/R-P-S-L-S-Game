using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S_GameProject
{
    public class Human : Player
    {


        //member variables
        int humanNumber;




        //constructor
        public Human()
        {

           

        }



        //member methods
        public override void SetName()
        {
            Console.WriteLine("\nPlease enter your name:\n");
            name = Console.ReadLine();


        }
        public override void ChooseGesture()
        {
            //Disply Gesture List Choices with string capture of "number" for each index

            Console.WriteLine("\n   Rock\n   Paper\n   Scissors\n   Lizard\n   Spock\n");
            gesture = Console.ReadLine();
            

            //if....user validation
            //else 

        }


        //public override string "ChooseGesture" method...must return result
            //"userInput" variable to hold value for "player.gesture" index

    }
}
