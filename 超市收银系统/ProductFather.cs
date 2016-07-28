using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class ProductFather
    {
        /// <summary>
        /// 货物
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="price">价格</param>
        /// <param name="name">名称</param>
        public ProductFather(string id,double price,string name)
        {
            this.ID = id;
            this.Price = price;
            this.Name = name;
        }
        public double Price
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
    }
}
