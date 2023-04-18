


namespace JogoDaVelha
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = { { 1,2,3},
                            { 4,5,6},
                            { 7,8,9} };

            Console.WriteLine(ints[0, 1]);
        }

        public int IsSolved(int[,] board)
        {

            if (board[0, 0] == board[0, 1] && board[0, 2] == board[0, 1] && board[0, 0] != 0)
            {
                return board[0, 0];
            }
            else if (board[1, 0] == board[1, 1] && board[1, 2] == board[1, 1] && board[1, 0] != 0)
            {
                return board[1, 0];
            }
            else if (board[2, 0] == board[2, 1] && board[2, 2] == board[2, 1] && board[2, 0] != 0)
            {
                return board[2, 0];
            }
            else if (board[0, 0] == board[1, 0] && board[2, 0] == board[0, 0] && board[0, 0] != 0)
            {
                return board[0, 0];
            }
            else if (board[0, 1] == board[1, 1] && board[2, 1] == board[0, 1] && board[0, 1] != 0)
            {
                return board[0, 1];
            }
            else if (board[0, 2] == board[1, 2] && board[2, 2] == board[0, 2] && board[0, 2] != 0)
            {
                return board[0, 2];
            }

            else if (board[0, 0] == board[1, 1] && board[2, 2] == board[0, 0] && board[0, 0] != 0)
            {
                return board[0, 0];
            }
            else if (board[0, 2] == board[1, 1] && board[2, 0] == board[0, 2] && board[0, 2] != 0)
            {
                return board[0, 2];
            }
            else if (board[0, 0] == 0 || board[0, 1] == 0 || board[0, 2] == 0 || board[1, 0] == 0 || board[1, 1] == 0 || board[1, 2] == 0 || board[2, 0] == 0 || board[2, 1] == 0 || board[2, 2] == 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

}

