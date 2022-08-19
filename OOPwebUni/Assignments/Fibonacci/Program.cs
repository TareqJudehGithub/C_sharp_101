using System.Collections.Generic;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fiboResult = new Fibonacci();
            fiboResult.Fibo();
        }
    }

    internal class Fibonacci
    {
        internal void Fibo()
        {

            List<int> numbers = new List<int> { 1, 1 };

            while (numbers.Count < 20)
            {
                int prevValue1 = numbers[numbers.Count - 1];
                int prevValue2 = numbers[numbers.Count - 2];

                int nextValue = prevValue1 + prevValue2;

                numbers.Add(nextValue);
                System.Console.WriteLine(numbers[0]);
            }

            foreach (int num in numbers)
            {
                System.Console.Write(num + ", ");
            }

        }
    }
}
