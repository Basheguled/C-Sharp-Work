using System;

class Object {
  public static void Main (string[] args) 
  {
    int [] array = new int[10];
    Console.WriteLine("This is a program to find the largest number in an array!!"); //opening msg
    Console.WriteLine("Insert 10 numbers into your array one at a time (hit enter after each number): "); 
    for(int i = 0; i < 10; i++)
    { //reads numbers from console into the array
      array[i] =Convert.ToInt32(Console.ReadLine());
    }
    int maxValue = 0; 
    for(int i = 0; i < 10; i++)
    {
      if(maxValue < array[i]) //change max value
        maxValue = array[i];
      else //do nothing
        maxValue = maxValue;
    }
    Console.WriteLine("The max value is: " + maxValue.ToString());
    

  }
  
}