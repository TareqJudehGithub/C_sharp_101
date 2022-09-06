namespace TicTacToeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Tic Tac Toe Project");


            // Instantiate a new obj
            TicTacToe game = new TicTacToe();

            // Variables 
            string playerOneSquare = string.Empty;
            string playerTwoSquare = string.Empty;
            string playerOneChoice = String.Empty;
            string playerTwoChoice = String.Empty;

            Console.Clear();
            Console.WriteLine("Let's play Tic Tac Toe!\n");

            Thread.Sleep(1000);
            game.Board();

            do
            {
                Console.Clear();
                game.Board();

                // P1

                Console.WriteLine("Player1's turn.");
                Console.Write("Choose a square number: ");
                playerOneSquare = Console.ReadLine();
                Thread.Sleep(500);

                if (playerOneSquare == "q")
                {
                    Console.WriteLine("Good bye!");
                    break;
                }

                Console.Write("(X/O)?: ");
                playerOneChoice = Console.ReadLine();

                game.PlayersChoices(playerOneSquare, playerOneChoice);
                Console.WriteLine(game.InputDuplication);

                while (game.InputDuplication == true)
                {
                    game.Board();
                    Console.WriteLine("Player1's turn.");
                    Console.Write("Choose a square number: ");
                    playerOneSquare = Console.ReadLine();
                    Thread.Sleep(500);

                    if (playerOneSquare == "q")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }

                    Console.Write("(X/O)?: ");
                    playerOneChoice = Console.ReadLine();

                    game.PlayersChoices(playerOneSquare, playerOneChoice);
                }
                game.Board();
                Console.WriteLine(game.InputDuplication);

                // P2
                Console.Clear();
                game.Board();
                Console.WriteLine(game.InputDuplication);

                Console.WriteLine("Player2's turn.");
                Thread.Sleep(500);

                Console.Write("Choose a square number: ");
                playerTwoSquare = Console.ReadLine();
                if (playerTwoSquare == "q")
                {
                    Console.WriteLine("Good bye!");
                    break;
                }

                Console.Write("(X/O)?: ");
                playerTwoChoice = Console.ReadLine();

                game.PlayersChoices(playerTwoSquare, playerTwoChoice);
                Console.WriteLine(game.InputDuplication);

                while (game.InputDuplication == true)
                {
                    game.Board();
                    Console.WriteLine("Player2's turn.");
                    Thread.Sleep(500);

                    Console.Write("Choose a square number: ");
                    playerTwoSquare = Console.ReadLine();
                    if (playerTwoSquare == "q")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }
                    Console.Write("(X/O)?: ");
                    playerTwoChoice = Console.ReadLine();

                    game.PlayersChoices(playerTwoSquare, playerTwoChoice);
                    Console.WriteLine(game.InputDuplication);
                }
                game.Board();
                Console.WriteLine(game.InputDuplication);

            } while (playerOneSquare != "q" || playerTwoSquare != "q");


        }
    }

}