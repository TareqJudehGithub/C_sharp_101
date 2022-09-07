namespace TicTacToeProject
{
    internal class GamePlay
    {
        private bool _isWinner;
        internal bool Iswinner
        {
            set { this._isWinner = value; }
            get { return this._isWinner; }
        }

        TicTacToe game = new TicTacToe();
        // Methods
        internal bool Winner(string p1, string p2, string p1Choice, string p2Choice)
        {
            string winner = string.Empty;

            if (p1Choice == "X")
            {
                if (game.One == "X" && game.Two == "X" && game.Three == "X")
                {
                    winner = $"{p1} is the winner! Game over";
                    Iswinner = true;
                }
            }
            else if (p2Choice == "O")
            {
                if (game.One == "O" && game.Two == "O" && game.Three == "O")
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
