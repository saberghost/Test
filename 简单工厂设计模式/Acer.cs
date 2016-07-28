using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂设计模式
{
    public class Acer:NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("鸿基笔记本");
        }
    }
}
