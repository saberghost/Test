using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    public enum School
    {
        高一,
        高二,
        高三
    }
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            School school = (School)Enum.Parse(typeof(School), m);
            Console.WriteLine(school);
            Console.ReadKey();
        }
    }
}
