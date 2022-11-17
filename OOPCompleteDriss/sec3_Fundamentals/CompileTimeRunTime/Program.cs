// See https://aka.ms/new-console-template for more information
using System;
class CompileTimeRunTime {
  static void Main(string[] args)
  {
    Console.WriteLine("Compile Time VS Run Time.\n");

    // Compile-time errors:
    int int1 = 1;
    int int2 = 0;
    int int3 = int1 / int2;
    

  }
}
