using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    var names = str.Split(' ');
    return $"{names[1]} {names[0]}";
  }
}
