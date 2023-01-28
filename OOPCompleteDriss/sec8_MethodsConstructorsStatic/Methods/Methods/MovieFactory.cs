namespace Methods
{
    internal class MovieFactory
    {
        public Movie CreateMovie(int id = 0, string title = "default title", string overview = "default overview") // default values
        {
            return new Movie { Id = id, Title = title, Overview = overview };
        }


    }
}
