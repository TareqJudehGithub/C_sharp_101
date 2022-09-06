namespace TicTacToeProject
{
    internal class GamePlay
    {
        TicTacToe game = new TicTacToe();

        // Variables 

        string playerOneSquare = string.Empty;
        string playerTwoSquare = string.Empty;
        string playerOneChoice = String.Empty;
        string playerTwoChoice = String.Empty;

        internal void GameLogic()
        {
            do
            {
                game.InputDuplication = false;
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
                game.Board();

                if (game.InputDuplication == true) continue;

                // P2
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
                game.Board();
                if (game.InputDuplication == true) continue;

            } while (playerOneSquare != "q");
        }
    }
}
