using System;

class AlwaysOne
{
  static void Main()
  {
    Console.WriteLine("Give me any number!");
    Console.WriteLine("I will magically turn that number into 1!");
    string stringNumber = Console.ReadLine();

    int yourNumber = int.Parse(stringNumber);
    int theNumberOne = yourNumber / yourNumber;

    string stringNumberOne = theNumberOne.ToString();

    Console.WriteLine("Here it is: " + stringNumberOne);
  }
}
