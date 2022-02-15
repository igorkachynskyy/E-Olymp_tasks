public class Triangle
    {
        private int x1, x2, x3, y1, y2, y3;
        public Triangle()
        {
            x1 = 0; x2 = 0; x3 = 0;
            y1 = 0; y2 = 0; y3 = 0;
        }
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }
        public void Out()
        {
            Console.WriteLine(x1 + " " + y1 + " " + x2 + " " + y2 + " " + x3 + " " + y3);
        }
        public double area()
        {
            var p = (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) + Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3)) + Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3))) /2;
            return Math.Sqrt(p * (p - Math.Sqrt((x1 -x2) * (x1 - x2) + (y1-y2) * (y1-y2)))* (p - Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3)) * (p - Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3)))));
        }
        public double perimeter()
        {
            return (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) + Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3)) + Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3)));
        }
        public double describedRadius()
        {
            return (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) * Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3)) * Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3))) / (4 * area());
        }
        public double inscribedRadius()
        {
            var p = (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) + Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3)) + Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3))) / 2;
            return area() / p;
        }
    }
