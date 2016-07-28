using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟移动硬盘_U盘_MP3
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileStorage ms = new MP3();
            Computer cpu = new Computer(ms);
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();
        }
    }
}
