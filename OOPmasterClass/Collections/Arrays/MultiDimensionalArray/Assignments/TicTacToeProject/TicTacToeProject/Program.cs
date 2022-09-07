namespace TicTacToeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PlayTicTacToe();
        }
        static void PlayTicTacToe()
        {

            // Instantiate a new obj
            TicTacToe game = new TicTacToe();

            // Variables 
            string playerOneSquare = string.Empty;
            string playerTwoSquare = string.Empty;

            Console.Clear();

            Console.WriteLine("Welcome to the Tic Tac Toe game!\n");

            Console.Write("Player1's name: ");
            string player1Name = Console.ReadLine();

            Console.Write("Player2's name: ");
            string player2Name = Console.ReadLine();

            Console.Clear();


            string player1Choice = string.Empty;
            string player2Choice = string.Empty;

            do
            {
                //if (player1Choice != "x" || player1Choice != "X" || player1Choice != "o" || player1Choice != "O")
                //{
                //    Console.WriteLine("X or O only, please.");
                //    break;
                //}
                Console.Write($"{player1Name}, choose X or O: ");
                player1Choice = Console.ReadLine();

                if (player1Choice == "x" || player1Choice == "X")
                {
                    player1Choice = "x".ToUpper();
                    player2Choice = "o".ToUpper();
                    break;
                }
                if (player1Choice == "o" || player1Choice == "O")
                {
                    player1Choice = "o".ToUpper();
                    player2Choice = "x".ToUpper();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose only between X or O");
                    Thread.Sleep(2000);

                }
            }
            while (player1Choice != "x" || player1Choice != "X" || player1Choice != "o" || player1Choice != "O");

            Console.WriteLine($"{player1Name} have chosen {player1Choice}");
            Console.WriteLine($"{player2Name} will play {player2Choice}");

            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("Let's play Tic Tac Toe!\n");
            Thread.Sleep(2000);

            do
            {
                game.Board();

                // P1
                Console.WriteLine($"{player1Name}'s turn. Mark: {player1Choice}");
                Console.Write("Choose a square: ");
                playerOneSquare = Console.ReadLine();
                Thread.Sleep(500);

                if (playerOneSquare == "q")
                {
                    Console.WriteLine("Good bye!");
                    break;
                }

                game.PlayersChoices(playerOneSquare, player1Choice);

                game.Winner(player1Name, player2Name, player1Choice, player2Choice);



                if (game.Iswinner == true)
                {
                    game.Board();
                    Console.WriteLine(" Thank  you and Good Game!");
                    break;
                }

                while (game.InputDuplication == true)
                {
                    game.Board();
                    Console.WriteLine($"{player1Name}'s turn. Mark: {player1Choice}");

                    Console.Write("Choose a square: ");
                    playerOneSquare = Console.ReadLine();
                    Thread.Sleep(500);

                    if (playerOneSquare == "q")
                    {
                        Console.WriteLine("Good bye!");
                        Thread.Sleep(1000);
                        break;
                    }
                    game.PlayersChoices(playerOneSquare, player1Choice);

                    game.Winner(player1Name, player2Name, player1Choice, player2Choice);

                    if (game.Iswinner == true)
                    {
                        game.Board();
                        Console.WriteLine(" Thank  you and Good Game!");
                        break;
                    }

                    Thread.Sleep(500);
                }
                Console.Clear();
                game.Board();

                // P2             
                game.Board();

                Console.WriteLine($"{player2Name}'s turn. Mark: {player2Choice}");
                Thread.Sleep(500);

                Console.Write("Choose a square: ");
                playerTwoSquare = Console.ReadLine();

                if (playerTwoSquare == "q")
                {
                    Console.WriteLine("Good bye!");
                    Thread.Sleep(1000);
                    break;
                }

                game.PlayersChoices(playerTwoSquare, player2Choice);

                if (game.Iswinner == true)
                {
                    game.Board();
                    Console.WriteLine(" Thank  you and Good Game!");
                    break;
                }

                while (game.InputDuplication == true)
                {
                    game.Board();
                    Console.WriteLine($"{player2Name}'s turn. Mark: {player2Choice}");
                    Thread.Sleep(500);

                    Console.Write("Choose a square: ");
                    playerTwoSquare = Console.ReadLine();
                    if (playerTwoSquare == "q")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }

                    game.PlayersChoices(playerTwoSquare, player2Choice);

                    if (game.Iswinner == true)
                    {
                        game.Board();
                        Console.WriteLine(" Thank  you and Good Game!");
                        break;
                    }
                }

                game.Board();

            } while (playerOneSquare != "q" || playerTwoSquare != "q");
        }
    }

}