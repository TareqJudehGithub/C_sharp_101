using System.Text; // for StringBuilder()

namespace ConstFieldProp
{
    internal class MovieService
    {
        // member fields
        private MovieData _movieData = new MovieData();

        // Methods
        internal List<MovieDescription> GetMovies()
        {
            return _movieData.GetMovies().Select(entity => new MovieDescription
            {
                Description = new StringBuilder().Append(entity.Tile)
                .Append("\n").Append(entity.ReleaseDate.Year.ToString())
                .Append("\n").Append(entity.Overview)
                .ToString()
            }).ToList();
        }
    }
}
