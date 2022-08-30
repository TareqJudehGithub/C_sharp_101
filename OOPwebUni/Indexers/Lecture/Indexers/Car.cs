namespace Indexers
{
    internal class Car
    {
        // private fields
        private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };
        private string[] _names = new string[] { "Anna", "James", "Ali" };
        // Indexers
        internal string this[int index]
        {
            set
            {
                this._brands[index] = value; // Assign value into the index based on indexer.

            }
            get
            {
                return _brands[index]; // return index value
            }
        }
    }
}

