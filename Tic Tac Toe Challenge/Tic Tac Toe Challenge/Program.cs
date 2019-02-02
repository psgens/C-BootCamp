using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Challenge
{
    class Program
    {
        static char[,] boardPlace =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; //Player 1
            int input = 0;
            bool inputCorrect = true;

            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                PlaceBoard();

                #region
                //Checks for a winner
                char[] playerIcons = { 'O', 'X' };
                foreach (char playerIcon in playerIcons)
                {
                    if(((boardPlace[0,0] == playerIcon) && (boardPlace[0,1] == playerIcon) && (boardPlace[0,2] == playerIcon))||
                        ((boardPlace[1, 0] == playerIcon) && (boardPlace[1, 1] == playerIcon) && (boardPlace[1, 2] == playerIcon))||
                        ((boardPlace[2, 0] == playerIcon) && (boardPlace[2, 1] == playerIcon) && (boardPlace[2, 2] == playerIcon))||
                        ((boardPlace[0, 0] == playerIcon) && (boardPlace[1, 0] == playerIcon) && (boardPlace[2, 0] == playerIcon))||
                        ((boardPlace[0, 1] == playerIcon) && (boardPlace[1, 1] == playerIcon) && (boardPlace[2, 0] == playerIcon))||
                        ((boardPlace[0, 2] == playerIcon) && (boardPlace[1, 2] == playerIcon) && (boardPlace[2, 2] == playerIcon))||
                        ((boardPlace[0, 0] == playerIcon) && (boardPlace[1, 1] == playerIcon) && (boardPlace[2, 2] == playerIcon))||
                        ((boardPlace[0, 2] == playerIcon) && (boardPlace[1, 1] == playerIcon) && (boardPlace[2, 0] == playerIcon)))
                    {
                        if (playerIcon == 'O')
                        {
                            Console.WriteLine("\nPlayer 1, YOU WIN!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 2, YOU WIN!");
                        }

                        Console.WriteLine("Reset the game? Press any key!");
                        Console.ReadKey();
                        resetBoard();


                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("This game is a draw.");
                        Console.WriteLine("Press any key to reset.");
                        Console.ReadKey();
                        resetBoard();
                        break;
                    }
                }
                #endregion

                #region
                //Checks if option has already been played.
                do
                {
                    Console.WriteLine("\nPlayer {0} : Where would you like to play?", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number.");
                    }
                    if ((input == 1) && (boardPlace[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (boardPlace[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (boardPlace[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (boardPlace[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (boardPlace[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (boardPlace[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (boardPlace[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (boardPlace[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (boardPlace[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nThat space is already taken! Try again");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
                #endregion
            } while (true);

        }


        public static void PlaceBoard()
        {
            Console.Clear();
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardPlace[0, 0], boardPlace[0, 1], boardPlace[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardPlace[1, 0], boardPlace[1, 1], boardPlace[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardPlace[2, 0], boardPlace[2, 1], boardPlace[2, 2]);
            turns++;
        }

        public static void resetBoard()
        {
            char[,] initialBoardPlace =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };


            boardPlace = initialBoardPlace;
            PlaceBoard();
            turns = 0;
        }

        public static void EnterXorO(int player, int input)
        {

            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';
            switch (input)
            {
                case 1: boardPlace[0, 0] = playerSign; break;
                case 2: boardPlace[0, 1] = playerSign; break;
                case 3: boardPlace[0, 2] = playerSign; break;
                case 4: boardPlace[1, 0] = playerSign; break;
                case 5: boardPlace[1, 1] = playerSign; break;
                case 6: boardPlace[1, 2] = playerSign; break;
                case 7: boardPlace[2, 0] = playerSign; break;
                case 8: boardPlace[2, 1] = playerSign; break;
                case 9: boardPlace[2, 2] = playerSign; break;
            }
        }
    }
}