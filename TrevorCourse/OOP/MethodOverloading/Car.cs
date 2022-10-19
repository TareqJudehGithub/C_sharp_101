namespace MethodOverloading
{
    internal class Car
    {
        // fields
        private string _brand;
        private string _model;
        private DateTime _manufacturingYear;
        bool _isAutmatic;
        bool _isLeatherSeats;
        private double _price;
        // Properties
        internal string Brand
        {
            set { this._brand = value; }
            get { return this._brand; }
        }
        internal string Model
        {
            set { this._model = value; }
            get { return this._model; }
        }
        internal DateTime ManufacturingYear
        {
            set { this._manufacturingYear = value; }
            get { return this._manufacturingYear; }
        }
        internal double Price
        {
            set { this._price = value; }
            get { return this._price; }
        }
        internal bool IsAutomatic
        {
            set { this._isAutmatic = value; }
            get { return this._isAutmatic; }
        }
        internal bool IsLeatherSeats
        {
            set { this._isLeatherSeats = value; }
            get { return this._isLeatherSeats; }
        }

        // Methods

        // parameterless methods

        internal void CarSpec(int year)
        {
            Console.WriteLine($"Car Specifications: ");
            Console.WriteLine($"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Manufacturing Year: {year}\n" +
                $"Price: {Price}\n" +
                $"Auto-Gear: {IsAutomatic}\n" +
                $"Leather Seats: {IsLeatherSeats}\n");
        }
    }
}
