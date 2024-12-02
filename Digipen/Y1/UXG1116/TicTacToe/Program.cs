using System;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            // Print Game Start
            Console.WriteLine("Welcome to Tic Tac Toe!");

            // Initialize UI
            Box box = new Box();
            box.Draw();
            Console.WriteLine();

            // Set Win to false
            bool win = false;

            // Initialize Players with their action
            Player P1 = new Player("P1", "O");
            Player P2 = new Player("P2", "X");

            // Set Current Player to P1
            Player currentPlayer = P1;

            // Game Loop
            while (!win)
            {
                // Check if player input is valid and run input function in box class
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write("{0} -> Input: ", currentPlayer.GetName());
                    validInput = box.Input(Console.ReadLine(), currentPlayer);
                    Console.WriteLine();
                }
                box.Draw();
                Console.WriteLine();

                // Check if the player won
                if (box.CheckWin())
                {
                    break;
                }
                currentPlayer = currentPlayer == P1 ? P2 : P1;

                if (box.CheckDraw())
                {
                    Console.WriteLine("It's a Draw! Restart With P1!");
                    box = new Box();
                    Console.WriteLine();
                    box.Draw();
                    Console.WriteLine();
                    currentPlayer = P1;
                }
            }
            // Game Ends
            Console.WriteLine("Congratulations {0}!", currentPlayer.GetName());
        }
    }
}
