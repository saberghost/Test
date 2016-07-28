using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    /// <summary>
    /// 打折的父类
    /// </summary>
    abstract class CalFather
    {
        /// <summary>
        /// 计算打折后的价格
        /// </summary>
        /// <param name="realMoney">原价格</param>
        /// <returns>折后价</returns>
        public abstract double GetTotalMoney(double realMoney);
    }
}
