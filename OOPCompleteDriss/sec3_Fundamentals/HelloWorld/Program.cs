// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic; // for using Lists


namespace HelloWorld {
  class MYClass 
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");

      // Creating a new empty list
      List<int>  myList = new List<int>();
      var newList = new List<int>();

      var query = from item in newList // LINQ
                  select item;
    }  
  }  
}
