using System;

public class Kata
{
  public static int Litres(double time)
  {
    int water = Convert.ToInt32(Math.Floor(.5 * time));
    return water;
  }
}
