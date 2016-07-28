using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习80
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现：请计算出一个整型数组的平均值，保留2位小数
            int[] number = { 4, 5,7,9,6,1 };
            double average = GetAverage(number);
            string str = average.ToString("f2");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        public static double GetAverage(int[] number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            double average = sum*1.0 / number.Length;
            return average;
        }
    }
}
