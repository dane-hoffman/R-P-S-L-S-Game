﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S_GameProject
{
    class Computer : Player
    {


        //member variables
        string computerGestureChoice;





        //constructor
        public Computer()
        {


        }



        //member methods

        public override void SetName()
        {
            name = "Computer";
        }
        public override void ChooseGesture()
        {
            //random selection
            //random number generator for value of List gesture Index

        }

        //public override string "ChooseGesture" method...must return result
        // create random number generator to pick index of "player.gestures


    }
}
