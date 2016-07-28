using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tshirt = 35;
            int trousers = 120;
            Console.WriteLine("3件T恤和2件裤子的总价是{0},打了8.8折的总价是{1}", Tshirt * 3 + trousers * 2, (Tshirt * 3 + trousers * 2) * 0.88);
            Console.ReadKey();
        }
    }
}
