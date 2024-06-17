using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VruBookShop_worapot.Model
{
    class BookType  //สร้างคลาสเพื่อทำงานกับตาราง tb_BookType
    {
        public int bookTypeID { get; set; }
        public string bookTypeName { get; set; }

        public SqlConnection con;
        //เชื่อมต่อกับฐานข้อมูล เขียนไว้ที่ constror
        public BookType()
        {
            string connectionString = "server=.\\sqlexpress;database=dbBookShop;" +
                "integrated security=true";
            con = new SqlConnection(connectionString);
        }
        //สร้างเมธอดสำหรับ CRUD เพิ่ม แก้ไข ลบ ค้นหา แสดง
        //เมธอด สำหรับเพิ่มข้อมูล
        public void create()
        {
            con.Open();
            string sql = "INSERT INTO tb_Booktype (bookTypeName)" +
                "VALUES (@bookTypeName)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("bookTypeName",this.bookTypeName);
            cm.ExecuteNonQuery();
            con.Close();
        }
        //เมธอดสำหรับแก้ไขข้อมูล
        public void update()
        {
            con.Open();
            string sql = "UPDATE tb_BookType SET bookTypeName=@bookTypeName " +
                "WHERE bookTypeID=@bookTypeID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("bookTypeName", this.bookTypeName);
            cm.Parameters.AddWithValue("bookTypeID", this.bookTypeID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        public void delete()
        {
            con.Open();
            string sql = "DELETE FROM tb_BookType WHERE bookTypeID=@bookTypeID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("bookTypeID", this.bookTypeID);
            cm.ExecuteNonQuery();
            con.Close();
        }
        //เมธอด สำหรับอ่าน
        public DataTable read()
        {
            con.Open();
            DataTable dt = new DataTable(); //เก็บผลลัพธ์จากการอ่านข้อมูล 
            string sql = "SELECT * FROM tb_BookType";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        //เมธอด สำหรับค้นหาากรหัส
        public DataTable readByID()
        {
            con.Open();
            DataTable dt = new DataTable(); //เก็บผลลัพธ์จากการอ่านข้อมูล 
            string sql = "SELECT * FROM tb_BookType " +
                "WHERE bookTypeID=@bookTypeID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("bookTypeID",
                this.bookTypeID);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        //เมธอด สำหรับค้นหาากชื่อ
        public DataTable readByName()
        {
            con.Open();
            DataTable dt = new DataTable(); //เก็บผลลัพธ์จากการอ่านข้อมูล 
            string sql = "SELECT * FROM tb_BookType " +
                "WHERE bookTypeName LIKE @bookTypeName";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("bookTypeName",
              "%" + this.bookTypeName + "%");
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
