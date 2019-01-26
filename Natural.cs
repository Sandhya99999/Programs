using System;

class Natural {
  public static void Main (string[] args) {
    Console.Write("Enter a number upto which you want to print the natural numbers:");
    int Count = Convert.ToInt32(Console.ReadLine());
    Console.Write("The natural numbers upto " + Count + " are");
    for(int Counter = 1; Counter <= Count; Counter++) {
      Console.Write(" " + Counter);
    }
    Console.Write(".");
    Console.WriteLine();
  }
}