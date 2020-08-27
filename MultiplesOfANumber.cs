using System.Collections.Generic;

public class Kata
{
  public static List<int> FindMultiples(int integer, int limit)
  {
    // PEDAC
    // Given an integer and a limit, find all multiples of that integer up to the limit
    // Example: 2, 6 -> 2, 4, 6
    // Data structures:
    // Algorithm
    List<int> integers = new List<int>();
    for (var index = integer; index <= limit; index += integer)
      {
          integers.Add(index);
      }
    return integers;
  }
}
