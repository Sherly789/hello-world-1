using System;

class Cd
{
  private string _title;
  private string _artist;
  private int _price;

  public void SetTitle(string newTitle)
  {
    _title = newTitle;
  }
  public string GetTitle()
  {
    return _title;
  }

  public void SetArtist(string newArtist)
  {
    _artist = newArtist;
  }
  public string GetArtist()
  {
    return _artist;
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
  public int GetPrice()
  {
    return _price;
  }
}

public class Program
{
  public static void Main()
  {
    Cd anotherCd = new Cd();
    anotherCd.SetTitle("Rubber Soul");
    anotherCd.SetArtist("The Beatles");
    anotherCd.SetPrice(-10);
    Console.WriteLine(anotherCd.GetTitle());
    Console.WriteLine("By: " + anotherCd.GetArtist());
    Console.WriteLine("Price: $" + anotherCd.GetPrice());
  }
}
