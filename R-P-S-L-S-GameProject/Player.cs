using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S_GameProject
{
    public abstract class Player
    {


        //member variables
        //public int score
        public string name;
        public int score;
        public string gesture;
        public List<string> gestures;



        //constructor
        public Player()
        {
            score = 0;
            gestures = new List<string>();


            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

            SetName();

        }



        //member methods
        public abstract void SetName();

        public abstract void ChooseGesture();

       

    }
}
