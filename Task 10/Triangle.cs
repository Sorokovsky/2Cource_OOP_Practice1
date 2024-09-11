namespace Task_10
{
    public class Triangle
    {
        public Point First { get; init; }
        public Point Second { get; init; }
        public Point Third { get; init; }

        public Triangle(Point first, Point second, Point third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public static double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        private (double, double, double) GetSides()
        {
            double firstSide = LengthSide(First, Second);
            double secondSide = LengthSide(First, Third);
            double thirdSide = LengthSide(Second, Third);
            return (firstSide, secondSide, thirdSide);
        }

        public bool IsValid()
        {
            (double firstSide, double secondSide, double thirdSide) = GetSides();            
            if(firstSide > secondSide + thirdSide) return false;
            if(secondSide > firstSide + thirdSide) return false;
            if(thirdSide > secondSide + firstSide) return false;
            else return true;
        }

        public static Triangle Create(Point first, Point second, Point third)
        {
            Triangle triangle = new Triangle(first, second, third);
            if(triangle.IsValid())
            {
                return triangle;
            }
            else
            {
                throw new ArgumentException("Triangle points is not correct");
            }
        }

        public double GetArea()
        {
            (double first, double second, double third) = GetSides();
            double halfPerimeter = GetPerimeter() / 2;
            double multi = halfPerimeter * (halfPerimeter - first) * (halfPerimeter - second) * (halfPerimeter - third);
            return Math.Sqrt(multi);
        }

        public double GetPerimeter()
        {
            (double firstSide, double secondSide, double thirdSide) = GetSides();
            return firstSide + secondSide + thirdSide;
        }

        public Point MediansCenter()
        {
            return new Point((First.X + Second.X + Third.X) / 3, (First.Y + Second.Y + Third.Y) / 3);
        }
    }
}
