using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data types");


            sbyte a = sbyte.MaxValue;
            sbyte c = default(sbyte);
            Console.WriteLine(a);
            Console.WriteLine(c);
        }
    }
}
