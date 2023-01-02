namespace ConstFieldProp
{
    internal class Movie
    {
        // members - fields
        private string _title;
        private string _description;

        // members - properties
        public string Computed
        {
            get
            {
                return $"{_title} {_description}";
            }
            private set   // This now can only be accessed inside the class.
            {
                this._title = value;
            }
        }
        public string Tile
        {
            set
            {
                this._title = value;
            }
            get
            {
                return this._title;
            }
        }

        // auto-implemented property
        public int id { get; set; }
        public string Overview { get; set; }
        public DateTime ReleaseDate { get; set; } // cannot b modified outside the class.
        public DateTime Rate { get; private set; } // cannot b modified outside the class.
        public string Category { get; set; }

        public string ImdbRate { get; }   // read only


    }
}
