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
        private bool _isWinner;
        internal bool Iswinner
        {
            set { this._isWinner = value; }
            get { return this._isWinner; }
        }

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


        private string[,] ticTacToeBoard = new string[3, 3];

        //{
        //    { One, Two, Three },
        //    { Four, Five, Six},
        //    { Seven, Eight, Nine }
        //};

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
            //string[,] ticTacToeBoard =
            //{
            //    { One, Two, Three },
            //    { Four, Five, Six},
            //    { Seven, Eight, Nine }
            //};

            ticTacToeBoard[0, 0] = One;
            ticTacToeBoard[0, 1] = Two;
            ticTacToeBoard[0, 2] = Three;

            ticTacToeBoard[1, 0] = Four;
            ticTacToeBoard[1, 1] = Five;
            ticTacToeBoard[1, 2] = Six;

            ticTacToeBoard[2, 0] = Seven;
            ticTacToeBoard[2, 1] = Eight;
            ticTacToeBoard[2, 2] = Nine;

            Console.Clear();
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
            if (square == "1")
            {
                if (One != "X" && One != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            One = "X";
                            break;
                        case "o":
                        case "O":
                            One = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice} : {One}");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }

            // 2
            else if (square == "2")
            {
                if (Two != "X" && Two != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            Two = "X";
                            break;
                        case "o":
                        case "O":
                            Two = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice} : {Two}");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }

            // 3
            else if (square == "3")
            {
                if (Three != "X" && Three != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            Three = "X";
                            break;
                        case "o":
                        case "O":
                            Three = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice.ToUpper()} : {Three}");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }

            // 4
            else if (square == "4")
            {
                if (Four != "X" && Four != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            Four = "X";
                            break;
                        case "o":
                        case "O":
                            Four = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice.ToUpper()} : {Four}");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }

            // 5
            else if (square == "5")
            {
                if (Five != "X" && Five != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            Five = "X";
                            break;
                        case "o":
                        case "O":
                            Five = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice.ToUpper()} : {Five}");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }
            // 6
            else if (square == "6")
            {
                if (Six != "X" && Six != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            Six = "X";
                            break;
                        case "o":
                        case "O":
                            Six = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice.ToUpper()} : {Six}");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }

            // 7
            else if (square == "7")
            {
                if (Seven != "X" && Seven != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            Seven = "X";
                            break;
                        case "o":
                        case "O":
                            Seven = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice.ToUpper()} : {Seven}");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }


            // 8
            else if (square == "8")
            {
                if (Eight != "X" && Eight != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            Eight = "X";
                            break;
                        case "o":
                        case "O":
                            Eight = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice.ToUpper()} : {Eight}");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Duplication Error!");
                    InputDuplication = true;
                    Thread.Sleep(5000);
                }
            }

            // 9
            else if (square == "9")
            {
                if (Nine != "X" && Nine != "O")
                {
                    InputDuplication = false;
                    switch (choice)
                    {
                        case "x":
                        case "X":
                            Nine = "X";
                            break;
                        case "o":
                        case "O":
                            Nine = "O";
                            break;
                        default:
                            Console.WriteLine("X or O only.");
                            break;
                    }
                    Console.WriteLine($"Square {square} is now {choice.ToUpper()} : {Nine}");
                    Thread.Sleep(2000);
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

            Console.Clear();
        }
        internal bool Winner(string p1, string p2, string p1Choice, string p2Choice)
        {
            string winner = string.Empty;

            if (p1Choice == "X")
            {
                if (One == "X" && Two == "X" && Three == "X")
                {
                    winner = $"{p1} is the winner! Good Game!";
                    Iswinner = true;
                }

            }
            else if (p2Choice == "O")
            {
                if (One == "O" && Two == "O" && Three == "O")
                {
                    winner = $"{p2} is the winner!";
                    Iswinner = true;
                }
            }
            else
            {
                Iswinner = false;
            }

            Console.WriteLine(winner);
            return Iswinner;
        }
    }
}
