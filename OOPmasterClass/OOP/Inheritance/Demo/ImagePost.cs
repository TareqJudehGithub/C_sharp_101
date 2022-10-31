namespace Demo
{
    internal class ImagePost : Post
    // Child class
    {
        // Properties
        internal string ImageURL { get; set; }

        // Constructors
        //public ImagePost()
        //{

        //}

        //private string _title;
        //internal string Title
        //{
        //    set => _title = value;
        //    get => _title;
        //}

        // Constructor
        public ImagePost(string title, string sendByUsernane, string imageURL, bool isPublic)
        {
            ID = GetNextId();
            Title = title;
            SendByUsername = sendByUsernane;
            ImageURL = imageURL;
            IsPublic = isPublic;
        }
        // Methods
        public override string ToString()
        {
            return $"{ID} - {Title} - {SendByUsername} - Image URL: {ImageURL}";
        }
    }
}
