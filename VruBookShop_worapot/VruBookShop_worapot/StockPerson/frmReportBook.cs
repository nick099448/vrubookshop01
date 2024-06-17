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
using VruBookShop_worapot.Report.Stock;
namespace VruBookShop_worapot.StockPerson
{
    public partial class frmReportBook : Form
    {
        SqlConnection con = new SqlConnection();
        public frmReportBook()
        {
            InitializeComponent();
        }

        private void rptReportBook_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=.\\sqlexpress;database=dbBookShop;integrated security=true";
            con.Open();
            string sql = "SELECT bookID,bookName,stock,bookTypeName " +
                "FROM tbBook LEFT JOIN tb_BookType " +
                "ON tbBook.bookTypeID=tb_BookType.bookTypeID";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            rptBook rpt = new rptBook();
            rpt.SetDataSource(dt);
            crvBook.ReportSource = rpt;
        }
    }
}
