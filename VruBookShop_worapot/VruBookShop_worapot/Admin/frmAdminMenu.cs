using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VruBookShop_worapot.Admin
{
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            //เปิดฟอร์ม frmEmployee 
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnShowPosition_Click(object sender, EventArgs e)
        {
            //เปิดฟอร์ม frmPosition
            frmPosition frm = new frmPosition();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportUser frm = new frmReportUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReportPosition frm = new frmReportPosition();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
