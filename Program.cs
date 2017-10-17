using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static Boolean j = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 is X, Player 2 is O");

            String[,] board = new String[3, 3];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = "_ ";
                    if (j == 2)
                    {
                        Console.Write(board[i, j] + "\n");
                    }
                    else
                    {
                        Console.Write(board[i, j]);
                    }
                }
            }



            while (j == false)
            {
                placement(board);
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (j == 2)
                        {
                            Console.Write(board[i, j] + "\n");
                        }
                        else
                        {
                            Console.Write(board[i, j]);
                        }
                    }
                }


            }





        }

        public static void placement(String[,] board)
        {
            int r, c, n;
            Console.WriteLine("Where will you place your letter? Ex. (player# row column (Row and Column must be c#))");
            String[] place = Console.ReadLine().Split(' ');

            n = Convert.ToInt32(place[0]);
            r = Convert.ToInt32(place[1]);
            c = Convert.ToInt32(place[2]);

            if (n == 1)
            {
                board[r, c] = "x ";
            }

            if (n == 2)
            {
                board[r, c] = "o ";
            }


            if (board[0, 0] == board[0, 1] && board[0, 0] != "_ ")
            {
                if (board[0, 1] == board[0, 2])
                {
                    j = true;
                }
            }

            if (board[1, 0] == board[1, 1] && board[1, 0] != "_ ")
            {
                if (board[1, 1] == board[1, 2])
                {
                    j = true;
                }
            }

            if (board[2, 0] == board[2, 1] && board[2, 0] != "_ ")
            {
                if (board[2, 1] == board[2, 2])
                {
                    j = true;
                }
            }

            if (board[0, 0] == board[1, 0] && board[0, 0] != "_ ")
            {
                if (board[1, 0] == board[2, 0])
                {
                    j = true;
                }
            }

            if (board[0, 1] == board[1, 1] && board[0, 1] != "_ ")
            {
                if (board[1, 1] == board[2, 1])
                {
                    j = true;
                }
            }

            if (board[0, 2] == board[1, 2] && board[0, 2] != "_ ")
            {
                if (board[1, 2] == board[2, 2])
                {
                    j = true;
                }
            }

            if (board[0, 0] == board[1, 1] && board[0, 0] != "_ ")
            {
                if (board[1, 1] == board[2, 2])
                {
                    j = true;
                }
            }

            if (board[0, 2] == board[1, 1] && board[0, 2] != "_ ")
            {
                if (board[1, 1] == board[2, 0])
                {
                    j = true;
                }
            }

            if (board[0, 0] != "_ " && board[0, 1] != "_ " && board[0, 2] != "_ " && board[1, 0] != "_ " && board[1, 1] != "_ " && board[1, 2] != "_ " && board[2, 0] != "_ " && board[2, 1] != "_ " && board[2, 2] != "_ ")
            {
                j = true;
            }

        }
    }
}
