// Fibonacci sequence problem

List<int> fiboNumbers = new List<int> { 1, 1 };
  while (fiboNumbers.Count < 20)
  {
      int prevVal1 = fiboNumbers[fiboNumbers.Count - 1];  // last number in the list 
      int prevVal2 = fiboNumbers[fiboNumbers.Count - 2];  // the 2nd number from the end 
      Console.WriteLine($"last number:  {prevVal1}");
      Console.WriteLine($"number before: {prevVal2}");

      int nextVal = prevVal1 + prevVal2;
      Console.WriteLine($"{prevVal1} + {prevVal2} = {nextVal}");
      Console.WriteLine("");

      fiboNumbers.Add(nextVal);
  }

  foreach (int number in fiboNumbers) Console.Write($"{number}, ");
  {

  }