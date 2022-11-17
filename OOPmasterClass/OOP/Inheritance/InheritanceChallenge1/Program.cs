namespace InheritanceChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Challenge 1\n");

            // Instantiate new objects
            Post adminPost = new Post();
            VideoPost video1 = new VideoPost(title: "Peter having a cookie.", sendByUsername: "Lulu", videoURL: "https://www. peter-cookies.net", length: 10, isPublic: true);
            VideoPost video2 = new VideoPost(title: "Pooh enjoying a delicious honey donut", sendByUsername: "Dina", videoURL: "https://www. winnie-the-pooh.net", length: 5, isPublic: true);

            // Methods calling
            Console.WriteLine(adminPost.ToString());
            Console.WriteLine(video1.ToString() + "\n");
            Console.WriteLine(video2.ToString() + "\n");

            Console.WriteLine("Video Play:");
            video1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadLine();
            video1.Stop();


        }
    }
}

