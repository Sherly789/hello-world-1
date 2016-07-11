using System;

class MealTime
{
  static void Main()
  {
    AskWhatYouAteFor("breakfast");
    AskWhatYouAteFor("lunch");
    AskWhatYouAteFor("dinner");
  }

  static void AskWhatYouAteFor(string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
    string yourMeal = Console.ReadLine();
    Console.WriteLine("You had " + yourMeal + " for " + meal + ".");
  }
}
