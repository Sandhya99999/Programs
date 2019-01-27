using System;

class MainClass {
  public static void Main (string[] args) {
    int TermNumber, TermCounter =2, Counter = 1, Product = 1;
    Console.Write("Enter a number upto which you want to print like this series(1, 4, 27, 256, .....):");
    TermNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("The terms in the above series upto " + TermNumber + " are");
    while(Product <= TermNumber) {
      Console.Write(" " + Product);
      Product = 1;
      for(Counter = 1; Counter <= TermCounter; Counter++) {
        Product = Product * TermCounter;
      }
      TermCounter++;
    }
    Console.Write(".\n");
  }
}