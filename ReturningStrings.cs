using System;

public static class Kata
{
  public static string Greet(string name)
  {
    // PEDAC
    // Return string with string name interpolated in output
    return ($"Hello, {name} how are you doing today?");
  }
}
