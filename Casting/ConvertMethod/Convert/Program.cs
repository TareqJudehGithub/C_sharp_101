namespace Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textNum = "1000";
            int num = System.Convert.ToInt32(textNum);
            System.Console.WriteLine(num.GetType());
            System.Console.WriteLine(num);
        }
    }
}
