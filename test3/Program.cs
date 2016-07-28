using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 107653;
            int day = time/60/60/24;
            int hour = time/60/60-day*24;
            int minute = time / 60 - (day*24*60+hour * 60);
            int seconds = time - (day*24*60*60+hour*60*60+minute*60);
            Console.WriteLine("{0}天{1}小时{2}分钟{3}秒", day, hour,minute,seconds);
            Console.ReadKey();
        }
    }
}
