using System.Text;

namespace Constructors
{
    internal class Movie
    {
        private readonly string _language = "English";
        public string Title { get; set; }
        public string Overview { get; set; }

        public List<Actor> Actors { get; set; }


        #region Constructors
        public Movie()
        {
            // Initialize Actors property inside the parameter-less constructor
            Actors = new List<Actor>();
        }

        public Movie(string title, string overview) : this()
        {
            // using this keyword to call another constructor. 

            Title = title;
            Overview = overview;
        }
        public Movie(string title, string overview, List<Actor> actors) : this(title, overview)
        {
            // this keyword calls its constructor into this 1, saving code duplications.
            Actors = actors;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            if (Actors.Count > 0)
            {
                foreach (var actor in Actors)
                {
                    stringBuilder.AppendLine($"{actor.FirstName} {actor.LastName}");
                    //actorFullName += actor.FirstName + " " + actor.LastName;
                }
            }
            return $"Title: {Title}\n" +
                $"Overview: {Overview}\n" +
                $"Language: {_language}\n" +
                $"Actors:\n{stringBuilder}";
        }
        #endregion
    }
}

