using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VruBookShop_worapot.SalePerson
{
    public partial class frmSalePersonMenu : Form
    {
        string empID, empName, posName;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale(empID,empName);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReportSale_Click(object sender, EventArgs e)
        {
            frmSaleReport frm = new frmSaleReport(empID);
            frm.MdiParent = this;
            frm.Show();

        }

        private void frmSalePersonMenu_Load(object sender, EventArgs e)
        {
            //นำชื่อและตำแหน่งมาแสดง
            labUser.Text = "ผู้ใช้งาน " + this.empName + " ตำแหน่ง " + posName;
        }

        public frmSalePersonMenu(string empID,string empName,string posName)
        {
            InitializeComponent();
            this.empID = empID;
            this.empName = empName;
            this.posName = posName;
        }
    }
}
