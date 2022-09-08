namespace TicTacToeProject
{
    internal class Program
    {
        // static fields
        static string player1Name = string.Empty;
        static string player2Name = string.Empty;
        static int counter = 0;

        static int playerOneSquare;
        static int playerTwoSquare;

        static void Main(string[] args)
        {
            bool restartGame = false;

            PlayTicTacToe();

            while (restartGame == false)
            {

                Console.Write("Play another game? (Y/N) ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    restartGame = true;
                    PlayTicTacToe();
                }
                else
                {
                    Console.WriteLine("Good bye!");
                    break;
                }
            }
        }
        static void PlayTicTacToe()
        {
            // Instantiate a new obj
            TicTacToe game = new TicTacToe();



            Console.Clear();

            Console.WriteLine("Welcome to the Tic Tac Toe game!\n");

            Console.Write("Player1's name: ");
            player1Name = Console.ReadLine();

            Console.Write("Player2's name: ");
            player2Name = Console.ReadLine();

            Console.Clear();

            string player1Choice = string.Empty;
            string player2Choice = string.Empty;

            do
            {
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
            Thread.Sleep(2000);

            Console.WriteLine($"{player2Name} will play {player2Choice}");
            Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine("Let's play Tic Tac Toe!\n");
            Thread.Sleep(2000);

            do
            {
                game.Board();

                // P1          
                if (game.IsDraw == true)
                {
                    Console.WriteLine("This round ended in a draw! Good game!");
                    Thread.Sleep(3000);
                    break;
                }

                Console.WriteLine($"playing {player1Choice}, {player1Name}'s turn: ");

                Thread.Sleep(2000);
                P1Square();


                if (playerOneSquare == 0)
                {
                    Console.WriteLine("Good bye!");
                    break;
                }

                game.PlayersChoices(playerOneSquare, player1Choice);
                game.Winner(player1Name, player1Choice);

                if (game.Iswinner == true)
                {
                    game.Board();
                    WinnerAnnouncementP1();
                    break;
                }

                while (game.InputDuplication == true)
                {
                    game.Board();

                    if (game.IsDraw == true)
                    {
                        Console.WriteLine("This round ended in a draw! Good game!");
                        Thread.Sleep(3000);
                        break;
                    }

                    Console.WriteLine($"playing {player1Choice}, {player1Name}'s turn: ");

                    P1Square();

                    if (playerOneSquare == 0)
                    {
                        Console.WriteLine("Good bye!");
                        Thread.Sleep(1000);
                        break;
                    }
                    game.PlayersChoices(playerOneSquare, player1Choice);
                    game.Winner(player1Name, player1Choice);

                    if (game.Iswinner == true)
                    {
                        game.Board();
                        WinnerAnnouncementP1();
                        break;
                    }

                }
                game.Draw();
                if (game.IsDraw)
                {
                    Console.WriteLine("This game ended in a draw!");
                    Console.WriteLine("Good game guys!");
                    Thread.Sleep(2000);
                    break;
                }
                counter++;
                Console.WriteLine($"The counter is: {counter}");
                Thread.Sleep(2000);
                if (counter == 9)
                {
                    Console.WriteLine($"Draw!! {counter} rounds reached!");
                    break;
                }

                // P2             
                game.Board();
                if (game.IsDraw == true)
                {
                    Console.WriteLine("This round ended in a draw! Good game!");
                    Thread.Sleep(3000);
                    break;
                }

                Console.WriteLine($"playing {player2Choice}, {player2Name}'s turn: ");
                Thread.Sleep(500);

                P2Square();

                if (playerTwoSquare == 0)
                {
                    Console.WriteLine("Good bye!");
                    Thread.Sleep(1000);
                    break;
                }

                game.PlayersChoices(playerTwoSquare, player2Choice);
                game.Winner(player2Name, player2Choice);

                if (game.Iswinner == true)
                {
                    game.Board();
                    WinnerAnnouncementP2();
                    break;
                }

                while (game.InputDuplication == true)
                {
                    game.Board();
                    if (game.IsDraw == true)
                    {
                        Console.WriteLine("This round ended in a draw! Good game!");
                        Thread.Sleep(3000);
                        break;
                    }

                    Console.WriteLine($"playing {player2Choice}, {player2Name}'s turn: ");
                    Thread.Sleep(500);

                    P2Square();

                    if (playerTwoSquare == 0)
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }

                    game.PlayersChoices(playerTwoSquare, player2Choice);
                    game.Winner(player2Name, player2Choice);

                    if (game.Iswinner == true)
                    {
                        game.Board();
                        WinnerAnnouncementP2();
                        break;
                    }
                }
                game.Draw();

                if (game.IsDraw)
                {
                    Console.WriteLine("This game ended in a draw!");
                    Console.WriteLine("Good game guys!");
                    Thread.Sleep(2000);
                    break;
                }

                counter++;
                Console.WriteLine($"The counter is: {counter}");

                if (counter == 9)
                {
                    Console.WriteLine($"Draw!! {counter} rounds reached!");
                    break;
                }
                Thread.Sleep(2000);

            } while (playerOneSquare != 15 || playerTwoSquare != 15);
        }

        // static methods
        static void WinnerAnnouncementP1()
        {
            Console.WriteLine($"The winner is {player1Name.ToUpper()}! ");
            Thread.Sleep(2000);

            Console.WriteLine($"Congratulations, {player1Name.ToUpper()}! Well played!");
            Thread.Sleep(3000);

            Console.WriteLine($"And hard luck {player2Name} :)");
            Thread.Sleep(3000);

            Console.WriteLine($"\n{player1Name} & {player2Name} Good Game guys!");
            Console.WriteLine(" Thank you for playing Tic Tac Toc!");
            Thread.Sleep(4000);
        }
        static void WinnerAnnouncementP2()
        {
            Console.WriteLine($"The winner is {player2Name.ToUpper()}! ");
            Thread.Sleep(2000);

            Console.WriteLine($"Congratulations, {player2Name.ToUpper()}! Well played!");
            Thread.Sleep(3000);

            Console.WriteLine($"And hard luck {player1Name} :)");
            Thread.Sleep(3000);

            Console.WriteLine($"\n{player2Name} & {player1Name} Good Game guys!");
            Console.WriteLine("Thank you for playing Tic Tac Toc!");
            Thread.Sleep(4000);
        }
        static void P1Square()
        {
            Console.Write("Choose a square: ");
            playerOneSquare = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(500);

        }
        static void P2Square()
        {
            Console.Write("Choose a square: ");
            playerTwoSquare = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(500);
        }


    }

}