using System;
using System.Collections.Generic;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    var numbers = new List<int>();
    for (var index = n; index > 0; index--)
    {
      numbers.Add(index);
    }
    return numbers.ToArray();
  }
}
