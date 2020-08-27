  using System;
  public static class Paper
  {
    public static int Paperwork(int n, int m)
    {
      // PEDAC
      // Calculate number of pages needed to copy paperwork
      // Input: int n (numberOfClassmates)
      // Input: int m (numberOfPages)
      // Work Check for and account for negative input
      // Work n * m otherwise
      // Output 0 or (n * m)
      // 
      // Example: n=5 m=5 -> 25
      // Data Structures: no new structures required
      // Algorithm: if n < 0 or m < 0, return 0
      // else return n * m
      
      if (n < 0 || m < 0)
        {
        return 0;
        }
      else
        {
        return n * m;
        }
    }
  }
