ublic class Kata
{
  public static int Grow(int[] x)
  {
    // Given a non-empty array of integers, return the result of multiplying the values together in order
    var product = x[0];
    for (var index = 1; index < x.Length; index++)
    {
      product = product * x[index];
    }
    return product;
  }
}
