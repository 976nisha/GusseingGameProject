//Date: 9/30/21
//Puropse: To create a guessing game that displays good encapsulation technique

using System;

namespace GuessingGame
{
    class Game
    {
        static void Main(string[] args)
        {
            //dispay the banner then welcome message prompt
            Banner();
            WelcomeMessage();
            Player player = new Player(GetUserInput());

            //this will check the property and accessor methods in the plyaer field if it prints the players name
            GamePrompt(player);
            string _playerAnswer = Console.ReadLine();
            //should get the input from the player and see if it is of type string if not loop not implemented
            CheckPlayerInput();

        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guessing Game!!");
            Console.WriteLine("Please enter your name: ");
        }

        private static string GetUserInput()
        {
            //returns the players input to the player class
            return Console.ReadLine();
        }

        private static void GamePrompt(Player player)
        {
            //This one uses the acessor method to get the _playerName - comparing it to the property
            //Console.WriteLine("Hi " + player.GetName() + " would you like to play the GuessingGame??");

            //This one uses the property to access the _playerName
            Console.WriteLine("Hi " + player.GetName + " would you like to play the GuessingGame??");
            Console.WriteLine("Choices: Yes(Y) No(N) Quit(Q)");
        }

        private static bool CheckPlayerInput()
        {
            return false;
        }

        private static void Banner()
        {
            Console.Title = "Guessing Game";
            string title = @"
             
                  ________                            .__                    ________                       
                 /  _____/ __ __   ____   ______ _____|__| ____    ____     /  _____/_____    _____   ____  
                /   \  ___|  |  \_/ __ \ /  ___//  ___/  |/    \  / ___\   /   \  ___\__  \  /     \_/ __ \ 
                \    \_\  \  |  /\  ___/ \___ \ \___ \|  |   |  \/ /_/  >  \    \_\  \/ __ \|  Y Y  \  ___/ 
                 \______  /____/  \___  >____  >____  >__|___|  /\___  /    \______  (____  /__|_|  /\___  >
                        \/            \/     \/     \/        \//_____/            \/     \/      \/     \/  ";

            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}