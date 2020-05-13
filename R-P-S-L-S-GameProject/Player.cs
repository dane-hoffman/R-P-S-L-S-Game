using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S_GameProject
{
    class Player
    {


        //member variables
        public List<string> gestures;



        //constructor
        public Player()
        {
            gestures = new List<string>();

            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");


        }



        //member methods
        //public abstract string "ChooseGesture" method

    }
}
