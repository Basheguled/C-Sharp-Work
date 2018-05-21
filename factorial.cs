using System;

class MainClass {
  public static int result;
  public static int factorial(int n) 
  {
    if(n == 1)
    {
      return 1;
    }
    return n * factorial (n-1);
  }
  public static void Main (string[] args) {
    int n;
    Console.WriteLine("Enter a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    result = factorial(n);
    Console.Write (result);
  }
}