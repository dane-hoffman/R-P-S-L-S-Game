using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S_GameProject
{
    class Computer : Player
    {
        Random random;


        //member variables





        //constructor
        public Computer()
        {
            random = new Random();


        }



        //member methods

        public override void SetName()
        {
            name = "Computer";
            Console.WriteLine("You are playing against the Computer!");
        }
        public override void ChooseGesture()
        {
            int randomNumber = random.Next(0, 4);
            gesture = gestures[randomNumber];

        }

        //public override string "ChooseGesture" method...must return result
        // create random number generator to pick index of "player.gestures


    }
}
