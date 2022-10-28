namespace Abstarction
{
    public abstract class Car
    {
        // fields
        private string _brand;
        private string _model;
        private string _color;

        private int _year;
        private double _price;
        private double _insurance;

        // properties
        public string Brand
        {
            set { this._brand = value; }
            get { return this._brand; }
        }
        public string Model
        {
            set { this._model = value; }
            get { return this._model; }
        }
        public string Color
        {
            set { this._color = value; }
            get { return this._color; }
        }
        public int Year
        {
            set { this._year = value; }
            get { return this._year; }
        }
        public double Price
        {
            set { this._price = value; }
            get { return this._price; }
        }
        public double Insurance
        {
            set { this._insurance = value; }
            get { return this._insurance; }
        }
        // Methods
        public abstract void CarInfo(double price, double insurance);
        public abstract void CarDetails(string brand, string model, string color, int year);

    }
}
