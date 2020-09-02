using System.Linq;
public class Kata
{
  public static string TripleTrouble(string one, string two, string three)
  {
    var output = "";
    for (var index = 0; index < one.Length; index++)
      {
        output += one[index];
        output += two[index];
        output += three[index];
    }
    return output;
  }
}
