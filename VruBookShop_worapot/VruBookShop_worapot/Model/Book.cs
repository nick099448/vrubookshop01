using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace VruBookShop_worapot.Model
{
    class Book
    {
        public int bookID { get; set; }

        public string bookName { get; set; }

        public int cost { get; set; }

        public int price { get; set; }

        public int stock { get; set; }

        public string bookPicture { get; set; }

        public int bookTypeID { get; set; }

        public SqlConnection con;

        public Book()
        {
            string connectionString = "server=.\\sqlexpress;database=dbBookShop; " +
               "integrated security=true";
            con = new SqlConnection(connectionString);
        }
        public void create()
        {
            con.Open();
            string sql = "INSERT INTO tbbook (bookName,cost,price,stock,bookPicture," +
                "bookTypeID) VALUES (@bookName,@cost,@price,@stock,@bookPicture,@bookTypeID) ";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("bookName", this.bookName);
            cm.Parameters.AddWithValue("cost", this.cost);
            cm.Parameters.AddWithValue("price", this.price);
            cm.Parameters.AddWithValue("stock", this.stock);
            cm.Parameters.AddWithValue("bookPicture", this.bookPicture);
            cm.Parameters.AddWithValue("bookTypeID", this.bookTypeID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void update()
        {
            con.Open();
            string sql = "UPDATE tbBook SET bookName=@bookName,cost=@cost," +
                "price=@price,stock=@stock,bookPicture=@bookPicture,bookTypeID=@bookTypeID " +
                "WHERE bookID=@bookID ";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("bookName", this.bookName);
            cm.Parameters.AddWithValue("cost", this.cost);
            cm.Parameters.AddWithValue("price", this.price);
            cm.Parameters.AddWithValue("stock", this.stock);
            cm.Parameters.AddWithValue("bookPicture", this.bookPicture);
            cm.Parameters.AddWithValue("bookTypeID", this.bookTypeID);
            cm.Parameters.AddWithValue("bookID", this.bookID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void delete()
        {
            con.Open();
            string sql ="DELETE FROM tbBook WHERE bookID=@bookID ";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("bookID", this.bookID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public DataTable read()
        {
            con.Open();
            DataTable dt = new DataTable(); //เก็บผลลัพธ์จากการอ่านข้อมูล 
            string sql = "SELECT bookID,bookName,cost,price,stock,bookPicture,bookTypeName FROM tbBook " +
                "LEFT JOIN tb_BookType ON tbBook.bookTypeID=tb_BookType.bookTypeID ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable readByID()
        {
            con.Open();
            DataTable dt = new DataTable(); //เก็บผลลัพธ์จากการอ่านข้อมูล 
            string sql = "SELECT bookID,bookName,cost,price,stock,bookPicture,bookTypeName FROM tbBook " +
                "LEFT JOIN tb_BookType ON tbBook.bookTypeID=tb_BookType.bookTypeID " +
                "WHERE bookID=@bookID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("bookID",
                this.bookID);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable readByName()
        {
            con.Open();
            DataTable dt = new DataTable(); //เก็บผลลัพธ์จากการอ่านข้อมูล 
            string sql ="SELECT bookID,bookName,cost,price,stock,bookPicture,bookTypeName FROM tbBook " +
                "LEFT JOIN tb_BookType ON tbBook.bookTypeID=tb_BookType.bookTypeID " +
                "WHERE bookName LIKE @bookName ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("bookName",
              "%" + this.bookName + "%");
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public int getAutoNumber()
        {
            int id = 0;
            con.Open();   
            string sql = " SELECT IDENT_CURRENT('tbBook')+1 AS ID;";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            id = int.Parse(dt.Rows[0]["ID"].ToString());
            con.Close();
            return id;
        }

        //เมธอด สำหรรับตัดสต๊อก
        public void upDateStock(int amount)
        {
            con.Open();
            string sql = "UPDATE tbBook SET stock=stock-@amount " +
                "WHERE bookID=@bookID ";
            SqlCommand cm = new SqlCommand(sql,con);
            cm.Parameters.AddWithValue("amount", amount);
            cm.Parameters.AddWithValue("bookID", this.bookID);
            cm.ExecuteNonQuery();
            con.Close();
        }
    }


}
