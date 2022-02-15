public class Vector
    {
        private int X, Y, Z;
        public Vector()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Vector(Vector v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }
        public Vector (int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public void setX(int X)
        {
            this.X = X;
        }
        public void setY(int Y)
        {
            this.Y = Y;
        }
        public void setZ(int Z)
        {
            this.Z = Z;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public int getZ()
        {
            return Z;
        }
        public double length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public void Out()
        {
            Console.WriteLine(X + " " + Y + " " + Z);
        }
    }
