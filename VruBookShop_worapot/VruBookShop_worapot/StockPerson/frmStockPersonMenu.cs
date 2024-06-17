using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VruBookShop_worapot.StockPerson
{
    public partial class frmStockPersonMenu : Form
    {
        string empID, empName, posName;

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //เปิดฟอร์มบุ๊คไทป์
            frmBookType frm = new frmBookType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnShowBook_Click(object sender, EventArgs e)
        {
             frmBook frm = new frmBook();
            frm.MdiParent = this;
            frm.Show();
        }

        private void รายงานขอมลหนงสอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportBook frm = new frmReportBook();
            frm.MdiParent=this;
            frm.Show();
        }

        private void frmStockPersonMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public frmStockPersonMenu(string empID, string empName, string posName)
        {
            InitializeComponent();
            this.empID = empID;
            this.empName = empName;
            this.posName = posName;
        }
    }
}
