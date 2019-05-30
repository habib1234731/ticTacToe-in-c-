using System;

namespace TicTacToe
{
    class Program
    {
        Board board;
        static void Main(string[] args)
        {
            Board board = new Board();
            game(ref board);

            Console.WriteLine("Would you like to play again? Y for yes and N for no");
            char c = Char.ToLower(Console.ReadKey().KeyChar);

            while (c != 'n') {
                if (c == 'y')
                {
                    resetBoard(ref board);
                    Console.WriteLine("Would you like to play again? Y for yes and N for no");
                }
                else if (c == 'n') break;
                else Console.WriteLine("Invalid Input! Please try again!");
                c = Char.ToLower(Console.ReadKey().KeyChar);
            }
        }

        private static void resetBoard(ref Board board)
        {
            board = new Board();
            game(ref board);
        }

        private static void game(ref Board board)
        {
            displayBoard(board);
            bool winner = false, flag;
            int input, movesCount = 0;
            do {
                Console.WriteLine("Player 1: Choose your Field!");
            play1:
                input = getField();
                flag = checkField(input, ref board, 1);
                if (flag == false)
                {
                    Console.WriteLine("Invalid Field! Please Select An Empty Field!");
                    goto play1;
                }
                displayBoard(board);
                if (movesCount >= 3) winner = checkWin(board, 'X');
                if (winner == true)
                {
                    Console.WriteLine("Player 1 Wins!");
                    break;
                }

                movesCount++;
                if (movesCount == 9)
                {
                    Console.WriteLine("Draw!");
                    break;
                }

                Console.WriteLine("Player 2: Choose your Field!");
            play2:
                input = getField();
                flag = checkField(input, ref board, 2);
                if (flag == false)
                {
                    Console.WriteLine("Invalid Field! Please Select An Empty Field!");
                    goto play2;
                }
                displayBoard(board);
                if (movesCount >= 3) winner = checkWin(board, 'O');
                if (winner == true)
                {
                    Console.WriteLine("Player 2 Wins!");
                    break;
                }

                movesCount++;
                if (movesCount == 9)
                {
                    Console.WriteLine("Draw!");
                    break;
                }
            }
            while (!winner);

        }

        private static bool checkWin(Board board, char player)
        {
            if (board.One == player && board.Two == player && board.Three == player) return true;
            if (board.Four == player && board.Five == player && board.Six == player) return true;
            if (board.Seven == player && board.Eight == player && board.Nine == player) return true;

            if (board.One == player && board.Four == player && board.Seven == player) return true;
            if (board.Two == player && board.Five == player && board.Eight == player) return true;
            if (board.Three == player && board.Six == player && board.Nine == player) return true;

            if (board.One == player && board.Five == player && board.Nine == player) return true;
            if (board.Three == player && board.Five == player && board.Seven == player) return true;

            return false;
        }

        // checks if field already contains a value otherwise assigns it a value
        private static bool checkField(int input, ref Board board, int player)
        {
            switch(input)
            {
                case 1:
                    if (board.One == '1')
                    {
                        if (player == 1) board.One = 'X';
                        else board.One = 'O';
                        return true;
                    }
                    break;
                case 2:
                    if (board.Two == '2')
                    {
                        if (player == 1) board.Two = 'X';
                        else board.Two = 'O';
                        return true;
                    }
                    break;
                case 3:
                    if (board.Three == '3')
                    {
                        if (player == 1) board.Three = 'X';
                        else board.Three = 'O';
                        return true;
                    }
                    break;
                case 4:
                    if (board.Four == '4')
                    {
                        if (player == 1) board.Four = 'X';
                        else board.Four = 'O';
                        return true;
                    }
                    break;
                case 5:
                    if (board.Five == '5')
                    {
                        if (player == 1) board.Five = 'X';
                        else board.Five = 'O';
                        return true;
                    }
                    break;
                case 6:
                    if (board.Six == '6')
                    {
                        if (player == 1) board.Six = 'X';
                        else board.Six = 'O';
                        return true;
                    }
                    break;
                case 7:
                    if (board.Seven == '7')
                    {
                        if (player == 1) board.Seven = 'X';
                        else board.Seven = 'O';
                        return true;
                    }
                    break;
                case 8:
                    if (board.Eight == '8')
                    {
                        if (player == 1) board.Eight = 'X';
                        else board.Eight = 'O';
                        return true;
                    }
                    break;
                case 9:
                    if (board.Nine == '9')
                    {
                        if (player == 1) board.Nine = 'X';
                        else board.Nine = 'O';
                        return true;
                    }
                    break;
                default:
                    return false;
            }
            return false;
        }

        private static int getField()
        {
            int input = int.Parse(Console.ReadLine());
            while(input < 1 || input > 9)
            {
                Console.WriteLine("Invalid input, enter a number " +
                    "between 1-9");
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }

        public static void displayBoard(Board b)
        {
            Console.WriteLine("   {0}   |   {1}   |   {2}", b.One, b.Two, b.Three);
            Console.WriteLine("_______________________");
            Console.WriteLine("   {0}   |   {1}   |   {2}", b.Four, b.Five, b.Six);
            Console.WriteLine("_______________________");
            Console.WriteLine("   {0}   |   {1}   |   {2}", b.Seven, b.Eight, b.Nine);
        }
    }
}
