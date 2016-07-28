using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.IO;

namespace 数据库链接
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringText = File.ReadAllLines(@"C:\Users\Master\Desktop\1.txt", Encoding.Default);
            string source = "User ID=layzt;Password=layzt;Data Source=(DESCRIPTION = (ADDRESS_LIST= (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))) (CONNECT_DATA = (SERVICE_NAME = orcl)))";
            OracleConnection conn = new OracleConnection(source);
            //string select = "select * from d_rec";
            //conn.Open();
            //OracleCommand cmd = new OracleCommand(select, conn);
            //OracleDataReader aReader = cmd.ExecuteReader();
            //while (aReader.Read())
            //{
            //    if (!aReader.GetOracleString(3).IsNull)
            //    {
            //        Console.WriteLine("{0}", aReader.GetOracleString(3));
            //    }
            //}
            //aReader.Close();
            //conn.Close();
            conn.Open();
            for (int i = 0; i < stringText.Length; i++)
            {
                string update = "insert into mytest (id,name) values ('" + (i+1) + "','" + stringText[i] + "')";
                OracleCommand cmd = new OracleCommand(update, conn);
                OracleDataReader aReader = cmd.ExecuteReader();
                aReader.Close();
            }
            conn.Close();
        }
    }
}
