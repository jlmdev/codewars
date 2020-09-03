public class Kata
{
  public static string Correct(string text)
  {
    foreach (var item in text)
            {
                text = text.Replace("5", "S").Replace("0", "O").Replace("1", "I");
            }
            return text;
  }
}
