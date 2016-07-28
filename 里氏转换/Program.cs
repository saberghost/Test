using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person people = new Teacher();
            //Teacher teacher = new Teacher();
            //if (people is Teacher)
            //{
            //    teacher = (Teacher)people;
            //}
            Teacher teacher = people as Teacher;
            teacher.Name = "李小璐";
            teacher.Work = "老师";
            teacher.WorkSpace();
            Console.ReadKey();
        }
    }
    class Person
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        char gender;
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("{0}的性别是{1}，年龄是{2}", this.Name, this.Gender, this.Age);
        }
    }
    class Teacher : Person
    {
        string work;
        public string Work
        {
            get { return work; }
            set { work = value; }
        }
        public void WorkSpace()
        {
            Console.WriteLine("{0}的工作是{1}", this.Name, this.Work);
        }
    }
}
