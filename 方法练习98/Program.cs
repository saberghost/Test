using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习98
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法 计算圆的面积和周长  面积是 pI*R*R  周长是 2*Pi*r
            Console.Write("请输入圆的半径：");
            double r = Convert.ToDouble(Console.ReadLine());
            double perimeter;
            double area = Circle(r, out perimeter);
            Console.WriteLine("圆的面积是{0},周长是{1}", area, perimeter);
            Console.ReadLine();
        }
        public static double Circle(double r,out double perimeter)
        {
            double area = Math.PI * r * r;
            perimeter = 2 * Math.PI * r;
            return area;
        }
    }
}
