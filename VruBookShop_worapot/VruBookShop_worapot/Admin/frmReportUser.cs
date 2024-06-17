using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VruBookShop_worapot.Report.Admin;
namespace VruBookShop_worapot.Admin
{
    public partial class frmReportUser : Form
    {
        public frmReportUser()
        {
            InitializeComponent();
        }

      /*  private void frmReportUser_Load(object sender, EventArgs e)
        {
            //สร้าง object ขอรายงาน
            rptUser rpt = new rptUser();
            //นำ repost ไปแสดงที่ crystalreportviewer
        }*/

        private void frmReportUser_Load_1(object sender, EventArgs e)
        {
            //สร้าง object ขอรายงาน
            rptUser rpt = new rptUser();
            //นำ repost ไปแสดงที่ crystalreportviewer
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
