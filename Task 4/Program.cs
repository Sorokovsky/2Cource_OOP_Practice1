namespace Task_4;
public static class Program
{
    public static void Main()
    {
        Console.Write("Введіть кількість точок(3 =< x <= 5): ");
        int count = Convert.ToInt32(Console.ReadLine());
        Figure figure = null;
        if (count < 3)
        {
            count = 3;
            Console.WriteLine("Ви ввели < 3. Зараз встановлено 3.");
        }
        if (count > 5)
        {
            count = 5;
            Console.WriteLine("Ви ввели > 5. Зараз встановлено 5.");
        }

        if (count == 3)
        {
            Point a = EnterPoint();
            Point b = EnterPoint();
            Point c = EnterPoint();
            figure = new Figure(a, b, c);
        }
        if (count == 4)
        {
            Point a = EnterPoint();
            Point b = EnterPoint();
            Point c = EnterPoint();
            Point d = EnterPoint();
            figure = new Figure(a, b, c, d);
        }
        if (count == 5)
        {
            Point a = EnterPoint();
            Point b = EnterPoint();
            Point c = EnterPoint();
            Point d = EnterPoint();
            Point e = EnterPoint();
            figure = new Figure(a, b, c, d, e);
        }

        if (figure != null)
        {
            Console.WriteLine("Периметр: {0}.", figure.PerimeterCalculator());
            int points = figure.PointsCount;
            if(points == 3)
            {
                Console.WriteLine("Це трикутник.");
            }
            if (points == 4)
            {
                Console.WriteLine("Це чотирикутник.");
            }
            if (points == 5)
            {
                Console.WriteLine("Це п'ятикутник.");
            }
        }
    }

    public static Point EnterPoint()
    {
        int x, y;
        string name;
        Console.Write("Введіть X точки: "); x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть Y точки: "); y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть ім'я точки: "); name = Console.ReadLine();
        return new Point(x, y, name);
    }
}