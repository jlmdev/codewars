public class DivisibleNb 
{
	public static bool isDivisible(long n, long x, long y) 
  {
		// Check if long n is divisible evenly by long x and long y
    // return boolean
    if ((n % x == 0) && (n % y == 0))
      {
        return true;
    }
    else
      {
      return false;
    }
	}
}
