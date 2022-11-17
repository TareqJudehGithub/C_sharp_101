namespace InheritanceChallenge1
{
    internal class Post
    // This is the base class
    {
        // fields
        private static int currentPostID;

        // properties
        internal int ID;
        internal string Title;
        internal string SendByUsername;
        internal bool IsPublic;

        // constructors
        internal Post()
        {
            ID = GetNextID();
            Title = "Post Rules: Keep it clean, keep it professional.";
            SendByUsername = "Admin";
            IsPublic = true;
        }

        // Methods 
        internal int GetNextID()
        {
            currentPostID++;
            return currentPostID;
        }
        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Title: {Title}\n" +
                $"Posted By: {SendByUsername}\n" +
                $"Public: {IsPublic}\n";
        }
    }
}
