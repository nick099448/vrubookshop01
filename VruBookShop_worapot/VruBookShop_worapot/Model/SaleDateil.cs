using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace VruBookShop_worapot.Model
{
    
    class SaleDateil
    {
        public int ID { get; set; }
        public int saleID { get; set; }
        public int bookID { get; set; }
        public int cost { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public int total { get; set; }

        public SqlConnection con;
        public SaleDateil()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=.\\sqlexpress;database=dbBookShop;" +
                "integrated security=true";
        }

        public void create()
        {
            con.Open();
            string sql = "INSERT INTO tb_SaleDetail (saleID,bookID,cost,price,amount,total) " +
                "VALUES (@saleID,@bookID,@cost,@price,@amount,@total)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("saleID", this.saleID);
            cm.Parameters.AddWithValue("bookID", this.bookID);
            cm.Parameters.AddWithValue("cost", this.cost);
            cm.Parameters.AddWithValue("price", this.price);
            cm.Parameters.AddWithValue("amount", this.amount);
            cm.Parameters.AddWithValue("total", this.total);
            cm.ExecuteNonQuery();
            con.Close();
        }
    }
   



}
