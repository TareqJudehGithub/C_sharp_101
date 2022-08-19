namespace PhoneCompanyAssignment
{
    internal class Phone
    {
        // fields
        private string company;
        private string model;
        private string releaseDay;

        // constructors
        internal Phone()
        {
            this.company = "Unknown";
            this.model = "Unknown";
            this.releaseDay = "Unknown";
        }

        internal Phone(string company, string model)
        {
            this.company = company;
            this.model = model;
            this.releaseDay = "Unknown";
        }
        internal Phone(string company, string model, string releaseDay)
        {
            this.company = company;
            this.model = model;
            this.releaseDay = releaseDay;
        }

        // Methods

        // Setters
        private void SetCompany(string value)
        {
            this.company = value;
        }
        private void SetModel(string value)
        {
            this.model = value;
        }
        private void SetReleaseDay(string value)
        {
            this.releaseDay = value;
        }

        // Getters
        private string GetCompany()
        {
            return company;
        }
        private string GetModel()
        {
            return model;
        }
        private string GetReleaseDay()
        {
            return releaseDay;
        }

        // Methods

        internal void PhoneDetails()
        {
            if (GetCompany() != "Unknown" && GetModel() != "Unknown" && GetReleaseDay() != "Unknown")
            {
                Console.WriteLine($@"
                    Company: {GetCompany()}
                    Model: {GetModel()}
                    Release Day: {GetReleaseDay()}");
            }
            else if (GetCompany() != "Unknown" && GetModel() != "Unknown")
            {
                Console.WriteLine($@"
                    Company: {GetCompany()}
                    Model: {GetModel()}
                    Release Day: {GetReleaseDay()}");
            }
            else
            {
                Console.WriteLine($@"
                    Company: {GetCompany()}
                    Model: {GetModel()}
                    Release Day: {GetReleaseDay()}");
            }
        }
    }

}
