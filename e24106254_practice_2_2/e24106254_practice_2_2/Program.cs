using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_2_2
{
    class Program
    {
        static string getWinner(char[,] board)
        {
            int oCount = 0;
            int xCount = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'O')
                    {
                        oCount++;
                    }
                    else if (board[i, j] == 'X')
                    {
                        xCount++;
                    }
                }
            }

            // don't consider tie
            return oCount > xCount ? "O" : "X";
        }

        static void printBoard(char[,] board)
        {
            Console.Clear();
            // print ABC
            Console.Write("  ");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                char c = Convert.ToChar('A' + i);
                Console.Write($"{c} ");
            }
            Console.WriteLine("");

            // print number and board
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine("");
            }
        }

        static bool hasPiece(char[,] board, int row, int col)
        {
            return board[row, col] != '-';
        }

        // make input such as A1 indexes of board
        static int[] convertInput(string input)
        {
            // NOTE convert positoin[1] to int directly will become 49 since it's char
            int row = Convert.ToInt32(input[1] - '1');
            int col = Convert.ToInt32(input[0] - 'A');

            int[] indexes = { row, col };
            return indexes;
        }

        static void play(ref char[,] board, int row, int col, char symbol)
        {
            board[row, col] = symbol;
        }

        // turn pieces surrounded to the other player's
        static void convertPieces(ref char[,] board, int row, int col, char symbol)
        {
            int boardSize = board.GetLength(0);

            int i = 0;
            int j = boardSize - 1;

            // use two pointers, find largest range of pieces, and convert pieces in between
            // check the same column
            while (i < j)
            {
                if (board[i, col] != symbol && i < boardSize)
                {
                    i++;
                }

                if (board[j, col] != symbol)
                {
                    j--;
                }

                if (board[i, col] == symbol && board[j, col] == symbol)
                {
                    for (; i < j; i++)
                    {
                        if (board[i, col] != '-')
                        {
                            board[i, col] = symbol;
                        }
                    }
                }
            }

            i = 0;
            j = boardSize - 1;

            // check same row
            while (i < j)
            {
                if (board[row, i] != symbol)
                {
                    i++;
                }

                if (board[row, j] != symbol)
                {
                    j--;
                }

                if (board[row, i] == symbol && board[row, j] == symbol)
                {
                    for (; i < j; i++)
                    {
                        if (board[row, i] != '-')
                        {
                            board[row, i] = symbol;
                        }
                    }
                }
            }
        }

        static bool inputIsValid(string input, int boardSize)
        {
            bool charIsValid = input[0] - 'A' < boardSize && input[0] - 'A' >= 0;
            bool numIsValid = false;
            try
            {
                // second character is number
                int row = Convert.ToInt32(input[1])-'1';
                numIsValid = row < boardSize && row >= 0;
            }
            catch
            {
                return false;
            }

            return input.Length == 2 && charIsValid && numIsValid;
        }

        static void Main(string[] args)
        {
            // initialize board
            const int boardSize = 8;
            char[,] board = new char[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = '-';
                }
            }

            int turn = 1;
            char playerSymbol = 'O';
            string input = "";
            while (turn <= boardSize * boardSize)
            {
                printBoard(board);
                Console.WriteLine($"輪到玩家{playerSymbol} 請輸入要下的位置:");
                input = Console.ReadLine();

                if (!inputIsValid(input, boardSize))
                {
                    Console.WriteLine("無效的輸入，請輸入字母加數字，如A1");
                    Console.ReadLine();
                    continue;
                }

                int[] indexes = convertInput(input);
                if (hasPiece(board, indexes[0], indexes[1]))
                {
                    Console.WriteLine("此位置已經有棋子！按任意鍵繼續遊戲");
                    Console.ReadLine();
                    continue;
                }

                play(ref board, indexes[0], indexes[1], playerSymbol);
                convertPieces(ref board, indexes[0], indexes[1], playerSymbol);

                playerSymbol = playerSymbol == 'O' ? 'X' : 'O';
                turn++;
            }
            printBoard(board);
            Console.WriteLine($"遊戲結束　玩家{getWinner(board)}獲勝!");
            Console.ReadLine();
        }
    }
}
