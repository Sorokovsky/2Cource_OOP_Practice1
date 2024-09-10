namespace Task_4
{
    internal partial class Figure
    {
        private LinkedList<Point> _points = new();

        public int PointsCount => _points.Count;

        public Figure(Point a, Point b, Point c)
        {
            _points.AddLast(a);
            _points.AddLast(b);
            _points.AddLast(c);
        }

        public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
        {
            _points.AddLast(d);
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
        {
            _points.AddLast(e);
        }

        public static partial double LengthSide(Point A, Point B);
        public partial double PerimeterCalculator();
    }
}
