using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承练习
{
    public class Teacher : Person
    {
        public Teacher(string name, char gender, int age, int workYear)
            : base(name, gender, age)
        {
            this.WorkYear = workYear;
        }
        private int _workYear;
        public int WorkYear
        {
            get { return _workYear; }
            set { _workYear = value; }
        }
        public void TeacherSayHello()
        {
            Console.WriteLine("我叫{0}，我是{1}人，我今年{2}岁，工作了{3}年", Name, Gender, Age, WorkYear);
        }
    }
}
