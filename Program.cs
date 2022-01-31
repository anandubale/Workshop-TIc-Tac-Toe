using System;

namespace Tic_tac_Toe_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {   
            


            int GameStatus = 0;
            int CurrentPlayer = -1;
            char[] GameSpace = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            do
            {
                CurrentPlayer = ChangePlayer(CurrentPlayer);

                Console.WriteLine("Choose 'X' or 'O' ");
                Char option = Convert.ToChar(Console.ReadLine());
                Choose(option,CurrentPlayer);



                /*
                RulesandCurrentPlayer(CurrentPlayer);

                DrawGameBoard(GameSpace);
                */
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

            Console.WriteLine($"\n\t{GameSpace[0]} | {GameSpace[1]} | {GameSpace[2]} ");
            Console.WriteLine("\t--+---+--");
            Console.WriteLine($"\t{GameSpace[3]} | {GameSpace[4]} | {GameSpace[5]} ");
            Console.WriteLine("\t--+---+--");
            Console.WriteLine($"\t{GameSpace[6]} | {GameSpace[7]} | {GameSpace[8]} ");
        }

        public static char Choose(char option,int player)
        {
           

            if (option.Equals('X'))
            {
                Console.WriteLine($"Player{player} chooses 'X'.");
                return 'X';
            }
            else if (option.Equals('O'))
            {
                Console.WriteLine($"Player{player} chooses 'O'.");

                return 'O';
            }
            else
            {
                Console.WriteLine("Return Appropriate option!");
                return 'N';
            }

        }

    }
}
