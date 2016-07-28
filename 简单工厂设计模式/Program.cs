using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想要的笔记本品牌");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            try
            {
                nb.SayHello();
            }
            catch
            {
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 简单工厂的核心，根据用户输入创建对象赋值给父类
        /// </summary>
        /// <param name="brand">品牌</param>
        /// <returns></returns>
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Acer": nb = new Acer();
                    break;
                case "IBM": nb = new IBM();
                    break;
                case "Lenovo": nb = new Lenovo();
                    break;
                default: Console.WriteLine("没有这种牌子");
                    break;
            }
            return nb;
        }
    }
}
