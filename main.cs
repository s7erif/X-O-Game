using System;

class Program
{
    static char[,] board = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    static int turns = 0;
    static char currentPlayer = 'X';

    static void Main()
    {
        PlayGame();
    }

    static void PlayGame()
    {
        while (true)
        {
            Console.Clear();
            PrintBoard();
            Console.WriteLine($"\nPlayer {currentPlayer}, choose your cell (1-9):");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int cell) || cell < 1 || cell > 9)
            {
                Console.WriteLine("❌ Invalid input. Press any key to continue...");
                Console.ReadKey();
                continue;
            }

            int row = (cell - 1) / 3;
            int col = (cell - 1) % 3;

            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                Console.WriteLine("❌ Cell already taken. Press any key to continue...");
                Console.ReadKey();
                continue;
            }

            board[row, col] = currentPlayer;
            turns++;

            if (CheckWinner())
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine($"\n🎉 Player {currentPlayer} wins!");
                break;
            }

            if (turns == 9)
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("\n🤝 It's a draw!");
                break;
            }

            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        Console.WriteLine("\nPress any key to play again...");
        Console.ReadKey();
        ResetGame();
        PlayGame();
    }

    static void PrintBoard()
    {
        Console.WriteLine("╔═══╦═══╦═══╗");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("║");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {board[i, j]} ║");
            }
            Console.WriteLine();
            if (i < 2)
                Console.WriteLine("╠═══╬═══╬═══╣");
        }
        Console.WriteLine("╚═══╩═══╩═══╝");
    }

    static bool CheckWinner()
    {
        // Rows & Columns
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == currentPlayer &&
                 board[i, 1] == currentPlayer &&
                 board[i, 2] == currentPlayer) ||
                (board[0, i] == currentPlayer &&
                 board[1, i] == currentPlayer &&
                 board[2, i] == currentPlayer))
                return true;
        }

        // Diagonals
        if ((board[0, 0] == currentPlayer &&
             board[1, 1] == currentPlayer &&
             board[2, 2] == currentPlayer) ||
            (board[0, 2] == currentPlayer &&
             board[1, 1] == currentPlayer &&
             board[2, 0] == currentPlayer))
            return true;

        return false;
    }

    static void ResetGame()
    {
        board = new char[,]
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        turns = 0;
        currentPlayer = 'X';
    }
}
