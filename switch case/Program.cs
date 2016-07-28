using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //一位员工评年终奖，工资为5000，若评为A：加500，B：加300，C：不变，D：减300，E：减500
            int money = 5000;
            bool b = true;
            Console.WriteLine("请输入你的评级：");
            string score = Console.ReadLine();
            switch (score)
            {
                case "A": money += 500;
                    break;
                case "B": money += 300;
                    break;
                case "C": break;
                case "D": money -= 300;
                    break;
                case "E": money -= 500;
                    break;
                default: Console.WriteLine("你输入的评级有误");
                    b = false;
                    break;
            }
            if (b)
                Console.WriteLine(money);
            Console.ReadKey(); 

        }
    }
}
