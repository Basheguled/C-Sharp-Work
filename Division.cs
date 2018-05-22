using System;

class MainClass {

  public static int divide (int a, int b)
  {
    int counter = 0;
    int i = a;
    while(i > 0)
    {
      i -= b;
      counter++;
      if(i < 0)
      {
        counter--;
      }
    }
    return counter;
  }
  public static void Main (string[] args) {
    Console.WriteLine("This program calculates division without using the division operator!");
    Console.WriteLine("Enter your first number to be divided: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your second number to be divided: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write(divide(a,b));
  }
}