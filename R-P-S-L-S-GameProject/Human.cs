using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S_GameProject
{
    public class Human : Player
    {


        //member variables
        string playerChoice;




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


        }


        //public override string "ChooseGesture" method...must return result
            //"userInput" variable to hold value for "player.gesture" index

    }
}
