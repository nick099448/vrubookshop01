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
    public partial class frmSale : Form
    {
        string empID, empName;
      //  string saleID;
      
        public frmSale(string empID,string empName)
        {
            InitializeComponent();
            this.empID = empID;
            this.empName = empName;
           
        }
        private void frmSale_Load(object sender, EventArgs e)
        {
            this.showDateTime();
        }
        private void showDateTime()
        {
            labSaleDate.Text = DateTime.Now.ToString();
        }

        private void txtBookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Book book = new Book();
                book.bookID = int.Parse(txtBookID.Text);
                DataTable dt = book.readByID();
                if (dt.Rows.Count > 0)
                {
                    labBookName.Text = dt.Rows[0]["bookName"].ToString();
                    labCost.Text = dt.Rows[0]["cost"].ToString();
                    labPrice.Text = dt.Rows[0]["price"].ToString();
                    txtAmount.Focus();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูล");
                    txtBookID.Clear();
                }
            }
        }

        // กำหนดค่าตัวแปร i นับแถวของ dataGrid
        int i = 0;
        int totalAll = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //เช็คว่ามีราคาขายและจำนวนเงินหรือยัง
            if (!int.TryParse( labPrice.Text , out int price)
                || !int.TryParse(labTotal.Text, out int total))
            {
                MessageBox.Show("ไม่มีข้อมูลราคาสินค้าหรือจำนวนเงิน");
                return;
            }
            
                dgvSale.Rows.Add();
                dgvSale.Rows[i].Cells["bookID"].Value = txtBookID.Text;
                dgvSale.Rows[i].Cells["bookName"].Value = labBookName.Text;
                dgvSale.Rows[i].Cells["cost"].Value = labCost.Text;
                dgvSale.Rows[i].Cells["price"].Value = labPrice.Text;
                dgvSale.Rows[i].Cells["amount"].Value = txtAmount.Text;
                dgvSale.Rows[i].Cells["total"].Value = labTotal.Text;
                i++ ;
                totalAll = totalAll + (int.Parse(labTotal.Text));
                labTotalAll.Text = totalAll.ToString();
                this.clearForm();
        }
        private void clearForm()
        {
            txtBookID.Clear();txtAmount.Clear();labBookName.Text = " ";labCost.Text = "";
            labPrice.Text = ""; labTotal.Text = "";
        }

        //  ......

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labTotal.Text = (int.Parse(labPrice.Text) * int.Parse(txtAmount.Text)).ToString();
                btnAdd.Focus();
            }
        }

        private void txtBookID_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text,out int bookID))
            {
                MessageBox.Show("ป้อนรหัสไม่ถูกต้อง");txtBookID.Focus();
                txtBookID.Clear();
                return;
                
            }
            Book book = new Book();
            book.bookID = int.Parse(txtBookID.Text);
            DataTable dt = book.readByID();
            if (dt.Rows.Count > 0)
            {
                labBookName.Text = dt.Rows[0]["bookName"].ToString();
                labCost.Text = dt.Rows[0]["cost"].ToString();
                labPrice.Text = dt.Rows[0]["price"].ToString();
                txtAmount.Focus();
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล");
                txtBookID.Clear();
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAmount.Text, out int bookID))
            {
                MessageBox.Show("ป้อนจำนวนไม่ถูกต้อง"); txtAmount.Focus();
                txtAmount.Clear();
                return;

            }
            labTotal.Text = (int.Parse(labPrice.Text) * int.Parse(txtAmount.Text)).ToString();
            btnAdd.Focus();
        }

       int saleID;

        private void btnSave_Click(object sender, EventArgs e)
        {

            //นำข้อมูลการขายไปจัดเก็บในตาราง sale   และ tbsaledetail
            //ตาราง sale เก็บข้อมูล saleid empid saledetail saletotal
            //saleID  เป็น auto ไม่ต้องใส่ empID นำมาจากตัวแปร
            // saleDetail ใช้วันที่ของเครื่อง saleTotal   ใช้ labtotal
            //เรียนใช้งานคลาส sale
            Sale sale = new Sale();
            sale.empID = int.Parse(this.empID);
            sale.saleTotal = int.Parse(labTotalAll.Text);
            sale.create();
            //ตาราง saleDrtail เก็บข้อมูล ID saleID bookID cost price amount total

            //this.saleID = saleID;
            
            //ต้องหา saleID ก่อน ส่วนข้อมูลอื่นๆ อยู่ใน datagridview
            saleID = sale.getsaleID();
           // MessageBox.Show(saleID.ToString());
            
            // อ่านข้อมูลใน dataagidview ไปเก็บในตาราง saledetail
            for (int i = 0; i < dgvSale.Rows.Count - 1; i++)
            {
                SaleDateil saleDateil = new SaleDateil();
                saleDateil.saleID = saleID;
                saleDateil.bookID = 
                    int.Parse(dgvSale.Rows[i].Cells["bookID"].Value.ToString()); 
                saleDateil.cost =
                    int.Parse(dgvSale.Rows[i].Cells["cost"].Value.ToString());
                saleDateil.price =
                    int.Parse(dgvSale.Rows[i].Cells["price"].Value.ToString());
                saleDateil.amount =
                    int.Parse(dgvSale.Rows[i].Cells["amount"].Value.ToString());
                saleDateil.total =
                    int.Parse(dgvSale.Rows[i].Cells["total"].Value.ToString());
                saleDateil.create();

                //ตัดสต๊อกที่ตาราง book
                Book book = new Book();
                book.bookID = saleDateil.bookID;
                book.upDateStock(saleDateil.amount);
                
            }
            MessageBox.Show("จัดเก็บข้อมูลแล้ว");
            dgvSale.Rows.Clear();
            i = 0;
            labTotalAll.Text = "";


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmRecivev frm = new frmRecivev(this.saleID);
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.showDateTime();
        }
    }

    internal class frmRecivev
    {
        private int saleID;

        public frmRecivev(int saleID)
        {
            this.saleID = saleID;
        }
    }
}
