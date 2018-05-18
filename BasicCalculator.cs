using System;

class Object {
  
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Welcome to the interactive calculator application!!");
    char keepGoing;
    do {
      Object thing = new Object();
      int result = thing.calculator();
      Console.WriteLine("Your anwer is: " + result.ToString());
      Console.WriteLine("Would you like to keep going? Enter 'Y' or 'N'.");
      keepGoing = Convert.ToChar(Console.ReadLine());
		} while(keepGoing == 'y' || keepGoing == 'Y');
  }
  public int calculator() 
  {
	int first;
    int second;
    char op;
    Console.WriteLine("Enter your first number: ");
    first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Now enter your second number: ");
    second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("What operation do you want to perform: ");
    
    op = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("You chose to perform: " +first.ToString() + op.ToString() + second.ToString());
    if(op == '+')
    {
      return (first + second);
    }
    else if (op == '-')
    {
      return (first - second);
    }
    else if (op == '/')
    {
      if(second == 0)
      {
        throw new DivideByZeroException("Cannot divide by 0!");
      }
      return (first / second);
    }
    else if (op == '*')
    {
      return (first * second);
    }
    else 
    {
      throw new ArgumentException("Cannot use that operation!");
    }
  }
}