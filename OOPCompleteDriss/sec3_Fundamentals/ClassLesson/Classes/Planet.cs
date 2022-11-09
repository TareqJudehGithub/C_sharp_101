namespace Classes
{
    internal class Planet
    {
        // fields - global variables in the class
        private int _id;
        private int _radius;
        private List<string> _satellites = new();

        // properties
        internal string Name { get; set; }
        internal int Radius
        {
            set { this._radius = value; }
            get { return this._radius; }
        }

        // Constructors -  Constructors are used to initialize fields.
        internal Planet(int id)
        {
            this._id = id;
        }

        // Methods
        internal int GetTemperature()
        {
            Random random = new Random();
            int temp = random.Next(0, 40);
            return temp;
        }
        internal void AddSatellite(string name)
        {
            _satellites.Add(name);
        }
        internal void PrintInfo()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            string planetInfo = $"Planet ID: {_id}" + Environment.NewLine;
            planetInfo += $"Name: {Name}" + Environment.NewLine;
            planetInfo += $"Radius: {Radius} km" + Environment.NewLine;
            planetInfo += $"{Name} has {_satellites.Count} satellite(s)" + Environment.NewLine;

            return planetInfo;
        }

    }
}
