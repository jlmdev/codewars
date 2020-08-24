using System;

public class Kata
{
  public static int CloseCompare(double a, double b, double margin = 0)
  {
    int result = 0;
    if ((a < b) && (Math.Abs(a - b) > margin))
    {
        result = -1;
    }
    else if ((a > b) && (Math.Abs(a - b) > margin))
    {
        result = 1;
    }
    else
    {
        result = 0;
    }
    
    
    
    return result;
  }
}
