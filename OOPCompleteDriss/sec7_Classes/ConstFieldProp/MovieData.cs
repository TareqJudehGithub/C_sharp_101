
namespace ConstFieldProp
{
    internal class MovieData
    {

        internal List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    id = 1,
                    Tile = "Movie 1",
                    Overview = "Overview 1",
                    ReleaseDate = new DateTime(2022, 12, 25)
                },
                new Movie
                {
                    id = 2,
                    Tile = "Movie 2",
                    Overview = "Overview 2",
                    ReleaseDate = new DateTime(2022, 6, 22)
                }
            };
        }
    }
}
