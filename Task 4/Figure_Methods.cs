namespace Task_4
{
    internal partial class Figure
    {
        public static partial double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public partial double PerimeterCalculator()
        {
            double result = 0;
            for (int i = 0; i < _points.Count - 1; i++)
            {
                result += Figure.LengthSide(_points.ElementAt(i), _points.ElementAt(i + 1));
            }
            return result;
        }
    }
}
