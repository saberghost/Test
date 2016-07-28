using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add(4.3);
            list.AddRange(new int[] { 3, 5, 5, 44, 1, 3 });
            //list.Clear();清空集合里的元素
            list.Remove(3);
            list.RemoveAt(1);
            list.RemoveRange(0, 2);
            list.Insert(0, "插入");
            list.Insert(1, "charu");
            list.InsertRange(2, new char[] { '男', '女' });
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
