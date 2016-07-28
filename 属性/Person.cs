using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性
{
    class Person
    {
        ~Person()
        {
            Console.WriteLine("fuck you");
        }
        public Person(string name, int age, char gender, float height, float weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Height = height;
            this.Weight = weight;
        }
        public Person(string name, int age, char gender)
            : this(name, age, gender, 1, 1)
        {

        }
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                    value = 0;
                _age = value;
            }
        }
        char _gender;

        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                    _gender = '男';
                return _gender;
            }
            set { _gender = value; }
        }
        float _height;

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }
        float _weight;

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public void Info()
        {
            Console.WriteLine("我的名字是{0},{1}岁,是{2}生", Name, Age, Gender);
        }
    }
}
