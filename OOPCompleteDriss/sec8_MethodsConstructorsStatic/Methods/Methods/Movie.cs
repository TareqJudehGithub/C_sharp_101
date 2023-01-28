namespace Methods
{
    internal class Movie
    {
        #region Member properties
        public int Id { get; internal set; }
        public string Title { get; set; }
        public string Overview { get; set; }

        // override the ToString method in Main method:
        public override string ToString()
        {
            return $"Movie: ID: {Id} - Title: {Title} - Overview: {Overview}";
        }

        #endregion
    }
}
