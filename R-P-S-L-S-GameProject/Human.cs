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
        




        //constructor
        public Human()
        {

           

        }



        //member methods
        public override void SetName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();


        }
        public override void ChooseGesture()
        {
            //Disply Gesture List Choices with string capture of "number" for each index

            Console.WriteLine("\n 1) Rock\n 2) Paper\n 3) Scissors\n 4) Lizard\n 5) Spock\n");
            gesture = Console.ReadLine();

            //if....user validation
            //else 

        }


        //public override string "ChooseGesture" method...must return result
            //"userInput" variable to hold value for "player.gesture" index

    }
}
