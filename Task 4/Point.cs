namespace Task_4
{
    public class Point
    {
        private int _x, _y;

        public int X { get { return _x; } }

        public int Y { get { return _y; } }

        public string Name { get; set; } = string.Empty;

        public Point(int x, int y, string name)
        {
            _x = x;
            _y = y;
            Name = name;
        }
    }
}
