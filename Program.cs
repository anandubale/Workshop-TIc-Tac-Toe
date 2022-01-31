using System;

namespace Tic_tac_Toe_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int GameStatus = -0;
            int CurrentPlayer = -1;
            char[] GameSpace = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            do
            {
                CurrentPlayer = ChangePlayer(CurrentPlayer);

                RulesandCurrentPlayer(CurrentPlayer);

                DrawGameBoard(GameSpace);






            } while (GameSpace.Equals(0));





        }

        public static int ChangePlayer(int player)
        {
            if (player.Equals(1))
            {
                return 2;
            }
            return 1;
        }


        public static void RulesandCurrentPlayer(int Player)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            
            Console.WriteLine("Player1 : 'O'");
            Console.WriteLine("Player1 : 'X'");

            Console.WriteLine($"Player{Player} turn choose between 1-9 ");


        }


        public static void DrawGameBoard(char[] GameSpace)
        {
            Console.WriteLine("");
        }


    }
}
