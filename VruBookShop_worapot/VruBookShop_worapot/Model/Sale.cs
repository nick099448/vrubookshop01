using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VruBookShop_worapot.Model
{
    class Sale
    {
        public int saleID { get; set; }
        public int empID { get; set; }
        public string saleDate { get; set; }
        public int saleTotal { get; set; }

        public SqlConnection con;

        public Sale()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=.\\sqlexpress;database=dbBookShop;" +
                "integrated security=true";
        }

        public void create()//เพิ่มข้อมูลการขาย
             
        {
            con.Open();
            string sql = "INSERT INTO tb_Sale (empID,saleDate,saleTotal) " +
                "VALUES (@empID,@saleDate,@saleTotal)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("empID",this.empID);
            cm.Parameters.AddWithValue("saleDate", DateTime.Now);
            cm.Parameters.AddWithValue("saleTotal", this.saleTotal);
            cm.ExecuteNonQuery();
            con.Close();
        }
        //สร้าง เมธอด หาค่า saleID ของพนักงานขาย 
            public int getsaleID()
        {
            int ID=0;
            con.Open();
            string sql = "SELECT MAX(saleID) AS ID FROM tb_sale WHERE empID=@empID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("empID", this.empID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ID =int.Parse( dt.Rows[0]["ID"].ToString());
            con.Close();
            return ID;

        }

        //สร้างเมธอดสำหรับอ่านข้อมูลการขายตามพนักงาน
        public DataTable readSaleDataByEmpID()
        {
            DataTable dt = new DataTable();
            con.Open();
            /*   string sql = "SELECT tb_Sale.saleID,tb_sale.saleDate," +
                   "tb_SaleDetail.bookID,tbBook.bookName,tb_SaleDetail.price," +
                   "tb_SaleDetail.amount,tb_SaleDetail.total " +
                   "FROM tb_Sale INNER JOIN tb_SaleDetail " +
                   "ON tb_Sale.saleID=tb_SaleDetail.saleID " +
                   "INNER JOIN tbBook " +
                   "ON tb_SaleDetail.bookID=tbBook.bookID " +
                   "WHERE tb_Sale.empID=@empID"; */
            string sql = "SELECT * FROM V_SaleData WHERE empID=@empID";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.SelectCommand.Parameters.AddWithValue("empID", this.empID);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable readSaleDataByDate(string dBegin,string dEnd)
        {
            DataTable dt = new DataTable();
            con.Open();
            string sql = "SELECT * FROM V_SaleData WHERE empID=@empID " +
                "AND (CAST(saleDate AS Date) BETWEEN @dBegin AND @dEnd)";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("empID", this.empID);
            da.SelectCommand.Parameters.AddWithValue("dBegin", dBegin);
            da.SelectCommand.Parameters.AddWithValue("dEnd", dEnd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
