using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class SuperMarket
    {
        Cangku ck = new Cangku();
        /// <summary>
        /// 创建仓库对象的时候，给仓库导入货物
        /// </summary>
        public SuperMarket()
        {
            ck.JinPros("Acer", 1000);
            ck.JinPros("Banana", 1000);
            ck.JinPros("JiangYou", 1000);
            ck.JinPros("SamSumg", 1000);
        }
        /// <summary>
        /// 跟用户交互的过程
        /// </summary>
        public void AskBuyling()
        {
            Console.WriteLine("欢迎光临本超市，请问你需要什么？");
            Console.WriteLine("我们有Acer,Banana,JiangYou,SamSumg");
            string strType = Console.ReadLine();
            Console.WriteLine("请问你需要多少个");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货
            ProductFather[] pros = ck.QuPros(strType, count);
            //计算价格
            double realMoney = GetMoney(pros);
            Console.WriteLine("你总共应付{0}元", realMoney);
            Console.WriteLine("请输入你要的打折方式 1--不打折 2--打九折 3--打八折 4--满500减100 5满800减200");
            string input = Console.ReadLine();
            double totalMoney = GetCal(input).GetTotalMoney(realMoney);
            Console.WriteLine("打折后的价格为{0}", totalMoney);
            Console.WriteLine("以下是你的购物清单：");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称：{0}，货物价格{1}，货物ID{2}", item.Name, item.Price, item.ID);
            }
        }
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1":
                    cal = new CalNormal();
                    break;
                case "2":
                    cal = new CalRate(0.9);
                    break;
                case "3":
                    cal = new CalRate(0.8);
                    break;
                case "4":
                    cal = new CalMN(500, 100);
                    break;
                case "5":
                    cal = new CalMN(800, 200);
                    break;
            }
            return cal;
        }
        /// <summary>
        /// 根据用户买的货物计算总价格
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }
        public void ShowPros()
        {
            ck.ShowPros();
        }

    }
}
