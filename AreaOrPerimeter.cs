public class MathCheck {
    public static int AreaOrPerimeter(int l, int w) {
        // PEDAC
        // Given length (l) and width (w), calculate the area or perimeter
        // of a 4 sided polygon. If the polygon is a square, return its area. (l * w)
        // Otherwise, return it's perimeter (2l + 2w)
        // Examples:
        // 6, 10 -> 32
        // 4, 4 -> 16
        // Data Structures:
        // No new data structures are needed
        // Algorithm:
        // if (l == w) { return l * w;}
        // else {return ((l * 2) + (w * 2));}
        if (l == w)
        {
          return l * w;
        }
        else 
        {
          return (l * 2) + (w * 2);
        }
    }
}
