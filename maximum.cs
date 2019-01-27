using System;

class MainClass {
  public static void Main (string[] args) {
    int Counter, LargerNumber = 0; 
    int[] Number = new int[10];
    Console.Write("To print the maximum number among 10 numbers, enter the first number:");
    Number[0] = Convert.ToInt32(Console.ReadLine());
    for(Counter = 1; Counter < 10; Counter++) {
      Console.Write("Enter the next number:");
      Number[Counter] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("The maximum number among " + Number[0]);
    for(Counter = 1; Counter < 10; Counter++) {
      Console.Write(", " + Number[Counter]);
    }
    LargerNumber = Number[0];
    for(Counter = 0; Counter < 10; Counter++) {
      if(Number[Counter] > LargerNumber) {
        LargerNumber = Number[Counter];
      }
    }
    Console.Write(" is " + LargerNumber + ".\n");
  }
}