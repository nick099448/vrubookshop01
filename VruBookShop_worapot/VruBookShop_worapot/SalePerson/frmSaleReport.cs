using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VruBookShop_worapot.Model;

namespace VruBookShop_worapot.SalePerson
{
    public partial class frmSaleReport : Form
    {
        string empID;
        public frmSaleReport(string empID)
        {
            InitializeComponent();
            this.empID = empID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmSaleReport_Load(object sender, EventArgs e)
        {
            this.showDgvSale();
        }
        private void showDgvSale()
        {
            Sale sale = new Sale();
            DataTable dt = new DataTable();
            sale.empID = int.Parse(this.empID);
            dt = sale.readSaleDataByEmpID();
            dgvSale.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dbegin = dBegin.Value.Date.ToString("yyyy-MM-dd",
                new System.Globalization.CultureInfo("en-us"));
            string dend = dEnd.Value.Date.ToString("yyyy-MM-dd",
                new System.Globalization.CultureInfo("en-us"));

          //  MessageBox.Show(dbegin);
            //นำวันที่เลือกไปค้นหาจากตารางที่เกี่ยวข้อง
            Sale sale = new Sale();
            sale.empID = int.Parse(this.empID);
            DataTable dt = new DataTable();
            dt = sale.readSaleDataByDate(dbegin,dend);
            if(dt.Rows.Count > 0)
            {
                dgvSale.DataSource = dt;
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล");
            }
        }
    }
}
