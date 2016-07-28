using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
{
    enum Gender
    {
        男,
        女
    }
    struct School
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            School zhanngsan;
            zhanngsan._name = "张三";
            zhanngsan._age = 18;
            zhanngsan._gender = Gender.男;
            Console.WriteLine(zhanngsan._gender);
            Console.ReadKey();
        }
    }
}
