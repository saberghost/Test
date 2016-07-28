using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        struct Vector
        {
            public double x, y, z;
            public Vector(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public Vector(Vector rhs)
            {
                x = rhs.x;
                y = rhs.y;
                z = rhs.z;
            }
            public override string ToString()
            {
                return "(" + x + "," + y + "," + z + ")";
            }
            public static Vector operator +(Vector lhs, Vector rhs)
            {
                Vector result = new Vector(lhs);
                result.x += rhs.x;
                result.y += rhs.y;
                result.z += rhs.z;
                return result;
            }
        }
        static void Main(string[] args)
        {
            //Vector vect1, vect2, vect3;
            //vect1 = new Vector(3.0, 3.0, 1.0);
            //vect2 = new Vector(2.0,-4.0,-4.0);
            //vect3 = vect1 + vect2;
            //Console.WriteLine("vect1={0}", vect1.ToString());
            //Console.WriteLine("vect2={0}", vect2.ToString());
            //Console.WriteLine("vect3={0}", vect3.ToString());
            //Console.ReadKey();
            int[] scores = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> scoreQuery = from score in scores where score % 2 == 0 select score;
            foreach (int num in scoreQuery)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
