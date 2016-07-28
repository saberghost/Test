using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add(6);
            //list.Add(9);
            //list.Add(1);
            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    sum = sum + (int)list[i];
            //}
            //Console.WriteLine("{0},{1}",sum,sum*0.1/list.Count);
            //Console.ReadKey();
            ArrayList list = new ArrayList();
            Random r = new Random();            
            for (int i = 0; i < 10; i++)
            {
                
                while (true)
                {
                    int temp = r.Next(0, 10);
                    if(!list.Contains(temp))
                    {
                        list.Add(temp);
                        break;
                    }

                }
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
