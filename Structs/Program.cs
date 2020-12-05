using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(7, 6, 5);
            Vector v2 = new Vector(1, 2, 3);
            Vector r1 = v1.Rationing();
            v1.Write();
            v2.Write();
            v2 = v2 * 3;
            v2.Write();
            Console.WriteLine (v2 ^ r1);
            Vector v3 = v1 + v2 ;
            v3.Write();
        }
        struct Vector
        {
            public double x,y,z;
            public Vector(double X, double Y, double Z)
            {
                x = X;
                y = Y;
                z = Z;
            }
            public double GetLength()
            {
                return Math.Sqrt(x * x + y * y + z * z);
            }
            public Vector Rationing()
            {
                double vX = Math.Sqrt(x / (x * x + y * y + z * z));
                double vY = Math.Sqrt(y / (x * x + y * y + z * z));
                double vZ = Math.Sqrt(z / (x * x + y * y + z * z));
                return new Vector(vX,vY,vZ); 
            } 
            public void Write()
            {
                Console.WriteLine("("+x+","+y+","+z+ ")");                 
            }
            public static Vector operator +(Vector v1, Vector v2)
            {
                return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            }
            public static Vector operator -(Vector v1, Vector v2)
            {
                return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
            }
            public static Vector operator *(Vector v1,int k )
            {
                v1.x *= k;
                v1.y *= k;
                v1.z *= k;
                return v1;
            }
            public static Vector operator /(Vector v1, int k)
            {
                v1.x /= k;
                v1.y /= k;
                v1.z /= k;
                return v1;
            }
            public static double operator ^(Vector v1,Vector v2)
            {
                return v1.x*v2.x+ v1.y * v2.y + v1.z * v2.z;
            } 
        }
    }
}
