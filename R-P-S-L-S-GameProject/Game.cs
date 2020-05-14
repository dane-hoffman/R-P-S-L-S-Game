using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_P_S_L_S_GameProject
{
    class Game
    {

        //member variables
        public Player playerOne;
        public Player playerTwo;


        //constructor
        public Game()
        {
            


        }

        public void RunGame()
        {
            //1.Display rules
            //2.ChooseGameType
            //a. Player vs Computer
            //b. Player vs Player
            //3.Players choose gestures
            //a. playerOne.ChoosGesture
            //b. playerTwo.ChooseGesture
            //4.CompareGestures
            //5.Determine round winner
            //6. Determine IF there is a Game winner
            //if Yes; end game, declare winner, "play again?"
            //if No; loop back to step 3

            string numberOfPlayers = GetNumberOfPlayers();
            CreatePlayers(numberOfPlayers);
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

        }

        //member methods

        public void DisplayRules()
        {



        }

        public string GetNumberOfPlayers()//change to ChooseGameType
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!\n\n\n How would you like to play ?\n\n 1) Player vs. Player\n 2) Player vs. Computer");
            string input = Console.ReadLine();
            return input;

        }

        public void CreatePlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else if (numberOfPlayers == "2")
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }

        }


        public void CompareChoice()
        {
            //"Rock crushes Scissors:
            //"Scissors cuts Paper"
            //"Paper covers Rock"
            //"Rock crushes Lizard"
            //"Lizard poisons Spock"
            //"Spock smashes Scissors"
            //"Scissors decapitates Lizard"
            //"Lizard eats Paper"
            //"Paper disproves Spock"
            //"Spock vaporizes Rock"

         

        }
       

        public void DisplayWinner()
        {



        }

        


    }
}
