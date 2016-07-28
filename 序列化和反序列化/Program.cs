using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 10;
            p.Gender = '男';
            p.Name = "张三";
            using (FileStream fsWrite=new FileStream(@"E:/XULIE.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                //开始序列化对象
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, p);
            }
            //Person p;
            //using (FileStream fsRrad = new FileStream(@"E:/XULIE.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    p = (Person)bf.Deserialize(fsRrad);
            //}
            //Console.WriteLine(p.Name);
            //Console.WriteLine(p.Age);
            //Console.WriteLine(p.Gender);
            //Console.ReadKey();
        }
    }
}
