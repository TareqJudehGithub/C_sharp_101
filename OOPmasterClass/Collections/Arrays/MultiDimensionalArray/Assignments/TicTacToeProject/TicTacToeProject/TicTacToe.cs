namespace TicTacToeProject
{
    internal class TicTacToe
    {
        // Board - fields
        private string _one = "1";
        private string _two = "2";
        private string _three = "3";
        private string _four = "4";
        private string _five = "5";
        private string _six = "6";
        private string _seven = "7";
        private string _eight = "8";
        private string _nine = "9";

        bool _Inputduplication = false;

        // properties
        internal string One
        {
            set { this._one = value; }
            get { return this._one; }
        }
        internal string Two
        {
            set { this._two = value; }
            get { return this._two; }
        }
        internal string Three
        {
            set { this._three = value; }
            get { return this._three; }
        }
        internal string Four
        {
            set { this._four = value; }
            get { return this._four; }
        }
        internal string Five
        {
            set { this._five = value; }
            get { return this._five; }
        }
        internal string Six
        {
            set { this._six = value; }
            get { return this._six; }
        }
        internal string Seven
        {
            set { this._seven = value; }
            get { return this._seven; }
        }
        internal string Eight
        {
            set { this._eight = value; }
            get { return this._eight; }
        }
        internal string Nine
        {
            set { this._nine = value; }
            get { return this._nine; }
        }

        internal string PlayerOneSquare { get; set; }
        internal string PlayerTwoSquare { get; set; }

        internal bool InputDuplication
        {
            set
            {
                this._Inputduplication = value;
            }
            get
            {
                return this._Inputduplication;
            }
        }

        // Methods
        internal void Board()
        {
            string[,] ticTacToeBoard =
            {
                { One, Two, Three },
                { Four, Five, Six},
                { Seven, Eight, Nine }
            };
            ticTacToeBoard[0, 0] = One;
            ticTacToeBoard[0, 1] = Two;
            ticTacToeBoard[0, 2] = Three;

            ticTacToeBoard[1, 0] = Four;
            ticTacToeBoard[1, 1] = Five;
            ticTacToeBoard[1, 2] = Six;

            ticTacToeBoard[2, 0] = Seven;
            ticTacToeBoard[2, 1] = Eight;
            ticTacToeBoard[2, 2] = Nine;


            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {One}  |  {Two}  |  {Three}  ");
            Console.WriteLine($"  ___|_____|____");

            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {Four}  |  {Five}  |  {Six}  ");
            Console.WriteLine($"  ___|_____|____");

            Console.WriteLine($"     |     |   ");
            Console.WriteLine($"  {Seven}  |  {Eight}  |  {Nine}  ");
            Console.WriteLine($"     |     |   ");

            Console.WriteLine("\n");
        }



        internal void PlayersChoices(string square, string choice)
        {
            if (square == "1" && One != "X" || One == "O")
            {
                if (One != "X" || One != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "X":
                        case "x":
                            One = "X";
                            break;
                        case "O":
                        case "o":
                            One = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice}");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }

            // 2
            else if (square == "2" && Two != "X" && Two != "O")
            {
                if (Two != "X" || Two != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "X":
                        case "x":
                            Two = "X";
                            break;
                        case "O":
                        case "o":
                            Two = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice}");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }
            else
            {
                Console.WriteLine("Invalid square entry!");
                Thread.Sleep(3000);
                InputDuplication = true;

            }

            //Console.WriteLine($"Player one has chosen {choice}");
            Console.Clear();
        }
    }
}
