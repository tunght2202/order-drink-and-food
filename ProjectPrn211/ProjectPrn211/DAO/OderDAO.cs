using ProjectPrn211.DAO;
using ProjectPrn211.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrn211.DAO
{
    internal class OderDAO 
    {
        public static int insertOrder(Order o)
        {
            string sql = @"INSERT INTO [dbo].[OrderTable]
           ([TableName]
           ,[FoodOrDrinkName]
           ,[Number]
            ,[Status])
             VALUES
           (@tablename,@foodordrinkname,@number,@status)";
            SqlParameter para1 = new SqlParameter("@tablename", DbType.String);
            para1.Value = o.tableName;
            SqlParameter para2 = new SqlParameter("@foodordrinkname",DbType.String);
            para2.Value = o.foodOrDrinkName;
            SqlParameter para3 = new SqlParameter("@number",DbType.Int32);
            para3.Value = o.number;
            SqlParameter para4 = new SqlParameter("@status", DbType.Int32);
            para4.Value = o.status;
            return DAO.ExecuteSql(sql, para1, para2, para3,para4);
        }

        public static List<Order> getAllOrder()
        {
            string sql = "SELECT [OrderID],[TableName],[FoodOrDrinkName],[Number],[Status] FROM [OrderFoodAndDrink].[dbo].[OrderTable] Where [OrderFoodAndDrink].[dbo].[OrderTable].[Status] = 0;";
            DataTable dt = DAO.GetDataBySQl(sql);
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dt.Rows)
            {
                Order o = new Order();
                o.id = int.Parse(dr["OrderID"].ToString());
                o.tableName = dr["TableName"].ToString();
                o.foodOrDrinkName = dr["FoodOrDrinkName"].ToString();
                o.number =int.Parse( dr["Number"].ToString());
                o.status = int.Parse(dr["Status"].ToString());
                orders.Add(o);

            }
            return orders;
        }
    }
}
