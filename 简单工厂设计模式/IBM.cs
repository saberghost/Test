using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂设计模式
{
    public class IBM:NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("IBM笔记本");
        }
    }
}
