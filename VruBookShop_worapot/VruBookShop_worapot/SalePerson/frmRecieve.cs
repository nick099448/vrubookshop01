using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VruBookShop_worapot.Report.Sale;
namespace VruBookShop_worapot.Report.Sale
{
    public partial class frmRecivev : Form
    {
      
        SqlConnection con = new SqlConnection();
        public frmRecivev()
        {
            InitializeComponent();

        }

        private void frmRecivev_Load_1(object sender, EventArgs e)
        {
            con.ConnectionString = "server=.\\sqlexpress;database=dbBookShop;" +
               "integrated secuity=true";
            con.Open();
            //select ข้อมูลตามที่กำหนดไว้ใน Recivev
            //saleID, saleDate, saleTptal จากกตารางtbsale
            //name จากตาราง tbUser
            //bookID, price, amount, total จากตาราง tbsaledetail
            //bookName จากตาราง tbBook
            string sql = "SELECT tb_Sale.saleID,saleDate,saleTotal,name,tb_SaleDetail.bookID," +
                "price,amount,total,bookName FROM tb_Sale " +
                "LEFT JOIN tb_saleDetail ON tb_Sale.saleID=tb_SaleDetail.saleID " +
                "LEFT JOIN tb_Employee ON tb_Sale.empID=tb_Employee.empID " +
                "LEFT JOIN tbBook ON tb_SaleDetail.bookID=tbBook.bookID " +
                "WHERE tb_Sale.saleID=@saleID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@saleID", this.saleID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //สร้าง Object ของรายงาน
            rptRecieve rpt = new rptRecieve();
            rpt.SetDataSource(dt);
            //เปิดรายงาน
            crystalReportViewer1.ReportSource = rpt;
            con.Close();
        }
    }
}
