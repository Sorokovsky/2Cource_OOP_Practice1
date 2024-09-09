namespace Task_1;
public static class Program
{
    public static void Main(string[] args)
    {
        double width, height;
        Console.Write("Enter a width: "); width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a height: "); height = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine("Area: {0}.", rectangle.Area);
        Console.WriteLine("Perimeter: {0}.", rectangle.Perimeter);
    }
}