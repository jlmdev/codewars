public class Kata
{
  public static int[] Arr(int N)
  {
    // Given an integer (N), return an array of integers from 0 to N-1
      
    int[] array = new int[N];
    for (var index = 0; index < N; index++)
    {
        array[index] = index;
    }
    return array;
  }
}
