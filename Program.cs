using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            GameLogic.PrintBoard();

            int row, column;

            bool gameover = false;

            while (!gameover)
            {

                Console.WriteLine("Choose the row from 0 - 2");
    
                if (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row > 2)
                {
                    Console.WriteLine("Please enter a number from 0 to 2.");
                    continue;
                }

                Console.WriteLine("Choose the column from 0 - 2");
                if(!int.TryParse(Console.ReadLine(), out column) || column < 0 || column > 2)
                {
                    Console.WriteLine("Please enter a number from 0 to 2.");
                    continue;
                }

                GameLogic.UpdateBoard(row, column);

                if (GameLogic.Winner())
                {
                    Console.Clear();
                    GameLogic.PrintBoard();
                    Console.WriteLine("Winner: " + GameLogic.CurrentPlayer());
                    gameover = true;
                }

                if(GameLogic.IsGameFull())
                {
                    Console.Clear();
                    GameLogic.PrintBoard();
                    Console.WriteLine("Tie!");
                    gameover = true;
                }
                

            }





        }
    }
}
