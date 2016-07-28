using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL链接
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "server=localhost;database=Test;uid=sa;pwd=123456";
            string select = "select * from Table_1";
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader aReader = cmd.ExecuteReader();
            while (aReader.Read())
            {
                Console.WriteLine("{0}{1}{2}", aReader.GetString(0), aReader.GetString(1), aReader.GetInt32(2));
            }
            aReader.Close();
            conn.Close();
            Console.ReadKey();
        }
    }
}
