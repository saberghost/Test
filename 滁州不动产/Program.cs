using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.IO;

namespace 滁州不动产
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "User ID=BDCDJ;Password=BDCDJ;Data Source=(DESCRIPTION = (ADDRESS_LIST= (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.1.118)(PORT = 1522))) (CONNECT_DATA = (SERVICE_NAME = orcl)))";
            string[] strTxt= File.ReadAllLines(@"E:\dj.txt",Encoding.Default);
            for (int i = 0; i < strTxt.Length; i++)
            {
                string[] strSp= strTxt[i].Split(new char[] { ' ' });
                string str1 = strSp[0];
                string str2 = strSp[1];
                string select = "insert into oa2_sysdic (sd_oid,sd_main,sd_class,sd_value,sd_keyno,sd_keyno2,sd_order,owner) values ((select max(sd_oid) from oa2_sysdic)+1,91,91,'" + str2 + "','" + str1 + "',-1,(select max(sd_order) from oa2_sysdic where sd_class=91)+1,0)";
                OracleConnection conn = new OracleConnection(source);
                conn.Open();
                OracleCommand cmd = new OracleCommand(select, conn);
                OracleDataReader aReader = cmd.ExecuteReader();
                aReader.Close();
                conn.Close();
            }
            
            Console.WriteLine("入库完成！");
            Console.ReadKey();
        }
    }
}
