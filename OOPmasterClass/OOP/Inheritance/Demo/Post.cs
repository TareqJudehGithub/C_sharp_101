namespace Demo
{
    internal class Post
    // This is the base class
    {
        // fields
        private static int currentPostID = 1;

        // Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Constructors

        public Post()
        // parameterless/default constructor
        {
            ID = GetNextId();
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "John Smith";
        }

        public Post(string title, bool isPublic, string sendByUsername)
        // Parametrized constructor
        {
            ID = GetNextId();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }

        protected int GetNextId()
        // This method increments ID by 1 each time users submit a new post.
        {
            return currentPostID++;
        }

        public void Update(string title, bool isPublic)
        /**
         * This method allows users to update post title and publicity
         * @params: string title, bool isPublic
         * @return: Updated post.
         
         */
        {
            Title = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        // This method OVERRIDES the System.Object.Tostring() method
        {
            return $"{ID} - {Title} - {SendByUsername}";
        }
    }
}
