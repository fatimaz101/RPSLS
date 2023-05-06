﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the game rules:" +
                "Rock crushes Scissors" +
                "Scissors cuts Paper" +
                "Paper covers Rock " +
                "Rock crushes Lizard" +
                "Lizard poisons Spock" +
                "Spock smashes Scissors" +
                "Scissors decapitates Lizard" +
                "Lizard eats Paper" +
                "Paper disproves Spock" +
                "Spock vaporizes Rock");

            
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Choose how many players ?(max 2)");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            if(numberOfPlayers ==1 || numberOfPlayers == 2)
            {
                return numberOfPlayers;
            }else if(numberOfPlayers > 2)
            {
                Console.WriteLine("Too many players, try again.");
                ChooseNumberOfHumanPlayers();
                return numberOfPlayers;
            }else if (numberOfPlayers < 1)
            {
                Console.WriteLine("Not enough players, try again.");
                ChooseNumberOfHumanPlayers();
                return numberOfPlayers;
            }

            return numberOfPlayers;
            
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
          //Step 1. Display the rules of the game
          //Step 2. Ask how many human players will be playing
          //Step 3. Get the names from the players
          //Step 4. Let each player choose a gesture
          //Step 5. Compare the gestures of each player and give one a point
          //Step 6. Loop step 4 and 5 until a player reaches 2 points
          //Step 7. Display winner 
          
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
        }
    }
}
