﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class Cangku
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        /// <summary>
        /// 展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                if (item.Count == 0)
                {
                    continue;
                }
                Console.WriteLine("我们超市有：{0}，有{1}个，每个{2}元", item[0].Name, item.Count, item[0].Price);
            }
        }
        //list[0]存储Acer电脑
        //list[1]存储三星手机
        //list[2]存储香蕉
        //list[3]存储酱油
        /// <summary>
        /// 在创建仓库对象的时候，向仓库中添加货架
        /// </summary>
        public Cangku()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">货物数量</param>
        public void JinPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏基笔记本"));
                        break;
                    case "Banana":
                        list[1].Add(new Banana(Guid.NewGuid().ToString(), 20, "香蕉"));
                        break;
                    case "JiangYou":
                        list[2].Add(new JiangYou(Guid.NewGuid().ToString(), 30, "酱油"));
                        break;
                    case "SamSumg":
                        list[3].Add(new Samsung(Guid.NewGuid().ToString(), 3000, "三星"));
                        break;
                }
            }
        }
        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">货物数量</param>
        /// <returns></returns>
        public ProductFather[] QuPros(string strType, int count)
        {
            ProductFather[] Pros = new ProductFather[count];
            for (int i = 0; i < Pros.Length; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        Pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "Banana":
                        Pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou":
                        Pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "SamSumg":
                        Pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return Pros;
        }
    }
}
