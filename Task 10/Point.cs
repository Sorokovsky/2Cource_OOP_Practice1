namespace Task_10
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Show()
        {
            Console.WriteLine("X: {0}.", X);
            Console.WriteLine("Y: {0}.", Y);
        }
    }
}
