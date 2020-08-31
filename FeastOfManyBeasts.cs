using System.Linq;

public class Kata
{
    public static bool Feast(string beast, string dish)
    {
        var beastFirstLetter = beast.First();
        var beastLastLetter = beast.Last();
        var dishFirstLetter = dish.First();
        var dishLastLetter = dish.Last();
        
        if ((beastFirstLetter == dishFirstLetter) && (beastLastLetter == dishLastLetter))
        {
          return true;
        }
        else
        {
          return false;
        }
    }
}
