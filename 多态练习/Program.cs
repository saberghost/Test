using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫
            RealDuck[] duck={new RealDuck(),new MutouDuck(),new XpDuck()};
            for (int i = 0; i < duck.Length; i++)
            {
                duck[i].Bark();
            }
            Console.ReadKey();
        }
        public class RealDuck
        {
            public virtual void Bark()
            {
                Console.WriteLine("真的鸭子嘎嘎叫");
            }
        }
        public class MutouDuck:RealDuck
        {
            public override void Bark()
            {
                Console.WriteLine("木头鸭子吱吱叫");
            }   
        }
        public class XpDuck:RealDuck
        {
            public override void Bark()
            {
                Console.WriteLine("橡皮鸭子唧唧叫");
            }
        }
    }
}
