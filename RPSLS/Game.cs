using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
            Console.WriteLine("Welcome to RPSLS! Here are the game rules:");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");

            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine( "Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine( "Lizard eats Paper");
            Console.WriteLine( "Paper disproves Spock");
            Console.WriteLine( "Spock vaporizes Rock");

            
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
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Whats your name?");
                string playerOneName = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneName);
                playerTwo = new ComputerPlayer("Computer");
            }else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player one please write your name");
                string playerOneName = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneName);
                Console.WriteLine("Player two please write your name");
                string playerTwoName = Console.ReadLine();
                playerTwo = new HumanPlayer(playerTwoName);
            }
        }

        public void CompareGestures()
        {
            Console.WriteLine($"Player one chose {playerOne.chosenGesture} and Player two chose {playerTwo.chosenGesture} ");
            if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("Rock crushes Scissors");
                playerOne.score++;
            }
            else if (playerTwo.chosenGesture == "rock" && playerOne.chosenGesture == "scissors")
            {
                Console.WriteLine("Rock crushes Scissors");
                playerTwo.score++;
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("Scissors cuts Paper");
                playerOne.score++;
            }else if(playerTwo.chosenGesture == "scissors" && playerOne.chosenGesture == "paper")
            {

                Console.WriteLine("Scissors cuts Paper");
                playerTwo.score++;
            }else if(playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("Paper covers rock");
                playerOne.score++;
            }else if(playerTwo.chosenGesture == "paper" && playerOne.chosenGesture == "rock")
            {
                Console.WriteLine("Paper covers rock");
                playerTwo.score++;
            }else if(playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("Rock crushes Lizard");
                playerOne.score++;
            }else if(playerTwo.chosenGesture == "rock" && playerOne.chosenGesture == "lizard")
            {
                Console.WriteLine("Rock crushes Lizard");
                playerTwo.score++;
            }else if(playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("Lizard Poisons Spock");
                playerOne.score++;
            }else if(playerTwo.chosenGesture == "lizard" && playerOne.chosenGesture == "spock")
            {
                Console.WriteLine("Lizard Poisons Spock");
                playerTwo.score++;
            }else if(playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("Spock smashes Scissors");
                playerOne.score++;
            }else if(playerTwo.chosenGesture == "spock" && playerOne.chosenGesture == "scissors")
            {
                Console.WriteLine("Spock smashes Scissors");
                playerTwo.score++;
            }else if(playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard");
                playerOne.score++;
            }else if(playerTwo.chosenGesture == "scissors" && playerOne.chosenGesture == "lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard");
                playerTwo.score++;
            }else if(playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("Lizard eats Paper");
                playerOne.score++;
            }else if(playerTwo.chosenGesture == "lizard" && playerOne.chosenGesture == "paper")
            {
                Console.WriteLine("Lizard eats Paper");
                playerTwo.score++;
            }else if(playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("Paper disproves Spock");
                playerOne.score++;
            }else if(playerTwo.chosenGesture == "paper" && playerOne.chosenGesture == "spock")
            {
                Console.WriteLine("Paper disproves Spock");
                playerTwo.score++;
            }else if(playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock")
            {

                Console.WriteLine("Spock vaporizes Rock");
                playerOne.score++;
            }else if (playerTwo.chosenGesture == "spock" && playerOne.chosenGesture == "rock")
            {
                Console.WriteLine("Spock vaporizes Rock");
                playerTwo.score++;
            }else if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("Tie! Go again.");
            }
        }

        public void DisplayGameWinner()
        {
            if(playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} wins!");
            }else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{ playerTwo.name} wins!");
            }
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
