﻿using System;
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
            //2.ChooseGameType***
                //a. Player vs Computer***
                //b. Player vs Player***
            //3. Get player name***
            //4.Players choose gestures***
                //a. playerOne.ChoosGesture***
                //b. playerTwo.ChooseGesture***
            //5.CompareGestures
            //6.Determine round winner
            //7. Determine IF there is a Game winner
                //if Yes; end game, declare winner, "play again?"
                //if No; loop back to step 4


            //DisplyRules Method
            string numberOfPlayers = ChooseGameType();
            CreatePlayers(numberOfPlayers);
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

        }

        //member methods

        public void DisplayRules()
        {
            //RULES OF RPSLS
            


        }

        public string ChooseGameType()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!\n\n\n How would you like to play ?\n\n 1) Player vs. Player\n 2) Player vs. Computer\n");
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
            if(playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Both players tied!");
                

            }
            else if(playerOne.gesture == "Rock" && (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Lizard"))
            {
                Console.WriteLine("Player One Wins the Round!");
                playerOne.score++;

            }
            //continue else if statements


        }
       

        public void DisplayWinner()
        {




        }

        


    }
}
