namespace CashierProject
{
    internal class Product
    {
        // member - Fields
        private readonly int _code;
        private readonly string _name;
        private readonly double _price;

        // member - Properties
        internal int Code { get; set; }
        internal string Name { get; set; }
        internal double Price { get; set; }

        // construct
        internal Product(int code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }



    }
}
