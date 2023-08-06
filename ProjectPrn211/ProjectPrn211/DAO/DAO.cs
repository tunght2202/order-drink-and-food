
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrn211.DAO
{
    public class DAO
    {
        
        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appSetting.json").Build();
            string ConnectionStr = config.GetConnectionString("DB");
            return new SqlConnection(ConnectionStr);
        }

       
        // use to get data from database in SQlServer
        public static DataTable GetDataBySQl(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length == 0) command.Parameters.AddRange(parameters); //add toàn bộ parameter vào command
            
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt); 
            return dt;
        }

        //use to add, update,delete
        public static int ExecuteSql(String sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length == 0)
                command.Parameters.AddRange(parameters);

            command.Connection.Open();
            int count = command.ExecuteNonQuery();
           
            command.Connection.Close();


            return count;
        }
    }
}
