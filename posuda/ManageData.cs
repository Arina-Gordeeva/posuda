using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace posuda
{
    public class ManageData
    {
        SqlConnection connection;
        public ManageData()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=LAPTOP-PQV5J0E9\SQLEXPRESS;Initial Catalog=Posuda;Integrated Security=True"); connection.Open();
            }
            catch
            {
                MessageBox.Show("Подключение не получилось создать");
            }
        }
        public void SqlRequest(string sqlR)
        {
            SqlCommand cmd = new SqlCommand(sqlR, connection); cmd.ExecuteNonQuery();
        }
        public SqlDataReader SqlRequestReader(string sqlR)
        {
            SqlCommand cmd = new SqlCommand(sqlR, connection);
            return cmd.ExecuteReader();
        }
        public void Update()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=SJFLLW\SQLEXPRESS;Initial Catalog=marathon;Integrated Security=True"); connection.Open();
            }
            catch
            {
                MessageBox.Show("Подключение не получилось создать");
            }
        }
    }
}
