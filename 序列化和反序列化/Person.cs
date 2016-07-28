using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    [Serializable]
    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
