namespace Our1stClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new object out of Human class
            Human john = new Human(humanFirst: "john".Trim(), humanLast: "smith".Trim(), eyeColor: "hazel", age: 42);
            Human ali = new Human(humanFirst: "ali".Trim(), humanLast: "  baba".Trim(), eyeColor: "blue", age: 35);

            Human husam = new Human(humanFirst: "husam".Trim(), humanLast: "judeh".Trim(), eyeColor: "black".Trim());

            Human bassem = new Human(humanFirst: "bassem");
            Human waleed = new Human(humanFirst: "waleed", humanLast: "salameh");

            john.IntroduceMySelf();
            ali.IntroduceMySelf();
            husam.IntroduceMySelf();
            bassem.IntroduceMySelf();
            waleed.IntroduceMySelf();
        }
    }
}

