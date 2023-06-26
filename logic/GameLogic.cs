public class GameLogic
{

    private static char[,] board = new char[3, 3]
             {
                { '*', '*', '*' },
                { '*', '*', '*' },
                { '*', '*', '*' }
             };

    private static char turn = 'X';

    // draw board
    public static void PrintBoard()
    {

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j]);

                if (j < board.GetLength(1) - 1)
                {
                    Console.Write(" | ");
                }
            }

            Console.WriteLine();

            if (i < board.GetLength(0) - 1)
            {
                Console.WriteLine("---------");
            }

        }
    }


    public static void UpdateBoard(int row, int column)
    {
        
        if (row != null && column != null)
        {

            turn = turn == 'X' ? 'O' : 'X';

            Console.WriteLine("Turn:" + turn);

            board[row, column] = turn;

            PrintBoard();
        }

    }


    // Check for a winner
    public static bool Winner()
    {

        for (int row = 0; row < board.GetLength(0); row++)
        {
            if (board[row, 0] == turn && board[row, 1] == turn && board[row, 2] == turn)
            {
                return true;
            }
        }

        for (int col = 0; col < board.GetLength(1); col++)
        {
            if (board[0, col] == turn && board[1, col] == turn && board[2, col] == turn)
            {
                return true;
            }
        }

        if (board[0, 0] == turn && board[1, 1] == turn && board[2, 2] == turn
        || board[2, 2] == turn && board[1, 1] == turn && board[0, 0] == turn)
        {
            return true;
        }

        return false;

    }

    public static char CurrentPlayer()
    {
        return turn;
    }

    public static bool IsGameFull()
    {

        for(int row = 0; row < board.GetLength(0); row++)
        {

            for(int col = 0; col < board.GetLength(1); col++)
            {

                if(board[row, col] == '*')
                {
                    return false;
                }
                
            }

        }

            return true;

    }


}