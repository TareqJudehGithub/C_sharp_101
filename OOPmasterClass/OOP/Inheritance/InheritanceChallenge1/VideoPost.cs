namespace InheritanceChallenge1
{
    internal class VideoPost : Post
    {
        //fields
        protected bool _isPlaying = false;
        protected double currDuration = 0;
        Timer timer;

        // properties
        internal string VideoURL { get; set; }
        internal double Length { get; set; }

        // Constructor
        internal VideoPost(string title, string sendByUsername, string videoURL, double length, bool isPublic)
        {
            Title = title;
            SendByUsername = sendByUsername;
            VideoURL = videoURL;
            Length = length;
            IsPublic = isPublic;
        }
        // Methods

        internal void Play()
        {
            if (!_isPlaying)
            {
                Console.WriteLine("Playing video...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}s");
                // Garbage collector
                GC.Collect();
            }
            else Stop();
        }
        internal void Stop()
        {
            if (_isPlaying)
            {
                Console.WriteLine($"Stopped at {currDuration}");
                currDuration = 0;
                timer.Dispose();  // stops the timer
            }
        }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
               $"Title: {Title}\n" +
               $"Posted By: {SendByUsername}\n" +
               $"Video URL: {VideoURL}\n" +
               $"Length: {Length}\n" +
               $"Public: {IsPublic}";
        }
    }
}
