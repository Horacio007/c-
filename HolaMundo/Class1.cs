using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    public class Class1
    {
        public static void GetCnn()
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"data source=192.168.42.52;initial catalog=pos;persist security info=True;user id=sa;password=B1Admin;";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                Console.WriteLine("Connection Open  !");
                SqlCommand command;
                SqlDataReader reader;
                String sql, output;

                sql = "select * from sucursalcaja";
                command = new SqlCommand(sql, cnn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetValue(0));
                }

                cnn.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
