namespace Demo
{
    internal class ImagePost : Post
    // Child class
    {
        // Properties
        internal string ImageURL { get; set; }

        // Constructor
        public ImagePost(string title, string sendByUsernane, string imageURL, bool isPublic)
        {
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
