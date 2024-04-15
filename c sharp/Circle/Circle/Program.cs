namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = Circle.circle_new(1, 3, 5);
            Console.WriteLine(circle.Contains(circle.X,circle.Y));
        }
    }
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
        Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        static public Circle circle_new(double x, double y, double radius)
        {
            return new Circle(x, y, radius);
        }

        double Area { get {return Math.PI * Radius * Radius; } }
        double Perimeter { get { return 2 * Math.PI * Radius; } }

        public bool Contains(double x, double y) 
        {
            double distance = Math.Sqrt((x - X) * (x - X) + (y - Y) * (y - Y));
            if(distance<Radius) 
                return true;
            return false;
        }

    }

}
