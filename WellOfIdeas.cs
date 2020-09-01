using System.Linq;
public class Kata
{
  public static string Well(string[] x)
  {
    // Given an array of stings x, count the number of 'good' instances.
    // If count is 0, return "Fail!"
    // If count is 1 or 2, return "Publish!"
    // If count > 2 return, "I smell a series!"
    var count = x.Count(str => str == "good");
    if (count == 0)
      {
      return "Fail!";
    }
    else if ((count == 1) || (count == 2))
      {
      return "Publish!";
    }
    return "I smell a series!";
  }
}
