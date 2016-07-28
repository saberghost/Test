using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //求矩形的面积和周长，求圆形的面积和周长
            Shape square = new Round(3);
            Console.WriteLine("{0},{1}", square.GetArea(), square.GetPerimeter());
            Console.ReadKey();
        }
        public abstract class Shape
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();
        }
        public class Square : Shape
        {
            double _height;
            public double Height
            {
                get { return _height; }
                set { _height = value; }
            }
            double _width;
            public double Width
            {
                get { return _width; }
                set { _width = value; }
            }
            public Square(double height, double width)
            {
                this.Height = height;
                this.Width = width;
            }

            public override double GetArea()
            {
                return this.Height * this.Width;
            }

            public override double GetPerimeter()
            {
                return (this.Height + this.Width) * 2;
            }
        }
        public class Round : Shape
        {
            double r;
            public double R
            {
                get { return r; }
                set { r = value; }
            }
            public Round(double r)
            {
                this.R = r;
            }
            public override double GetArea()
            {
                return Convert.ToDouble((Math.PI * this.R * this.R).ToString("f2"));
            }

            public override double GetPerimeter()
            {
                return Math.Round( 2 * Math.PI * this.R,2);
            }
        }

    }
}
