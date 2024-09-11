namespace Task_10;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            int operation = ChooseOperation();
            switch (operation)
            {
                case 0:
                    {
                        return;
                    }
                 case 1:
                    {
                        try
                        {
                            Triangle triangle = EnterTriangle();
                            Console.WriteLine("Area: {0}", triangle.GetArea());
                            Console.WriteLine("Perimeter: {0}", triangle.GetPerimeter());
                            Console.WriteLine("Center a median: ");
                            triangle.MediansCenter().Show();
                        } 
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Unknown operation. Try again.");
                        break;
                    }
            }
        }
    }

    public static int ChooseOperation()
    {
        Console.WriteLine("Choose operation.");
        Console.WriteLine("0-Exit.");
        Console.WriteLine("1-Create triangle.");
        Console.Write(">> ");
        int operation = Convert.ToInt32(Console.ReadLine());
        return operation;
    }

    public static Triangle EnterTriangle()
    {
        Console.WriteLine("1 point.");
        Point first = EnterPoint();
        Console.WriteLine("2 point.");
        Point second = EnterPoint();
        Console.WriteLine("3 point.");
        Point third = EnterPoint();
        return Triangle.Create(first, second, third);
    }

    public static Point EnterPoint()
    {
        Console.Write("Enter x: "); double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y: "); double y = Convert.ToDouble(Console.ReadLine());
        return new Point(x, y);
    }
}