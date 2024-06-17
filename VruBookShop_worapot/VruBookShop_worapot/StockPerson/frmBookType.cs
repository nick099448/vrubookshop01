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

namespace VruBookShop_worapot.StockPerson
{
    public partial class frmBookType : Form
    {
        public frmBookType()
        {
            InitializeComponent();
        }

        private void frmBookType_Load(object sender, EventArgs e)
        {
             this.showDgvBookType();
        }

        private void showDgvBookType()  //อ่านข้อมูลประเภทหนังสือมาแสดง
        {
            //สร้างอออฟเจ็คของคลาส BookType ใช้งาน
            BookType bt = new BookType();
            DataTable dt = new DataTable();
            dt = bt.read();
            if (dt.Rows.Count > 0)
                dgvBookType.DataSource = dt;
            else
                MessageBox.Show("ไม่พบข้อมูลประเภทหนังสือ");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ตรวจสอบการป้อนข้อมูล 
            if(txtBookTypeName.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลหนังสือก่อน");
                return;
            }
            BookType bt = new BookType();
            bt.bookTypeName = txtBookTypeName.Text;
            bt.create();
            this.showDgvBookType();
            this.clearform();
        }
        private void clearform()
        {
            txtBookTypeName.Clear(); labBookTypeID.Text = "";
        }

        private void dgvBookType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookTypeName.Text = dgvBookType.Rows[e.RowIndex].Cells["bookTypeName"].Value.ToString();
            labBookTypeID.Text = dgvBookType.Rows[e.RowIndex].Cells["bookTypeID"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(labBookTypeID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่จะแก้ไขก่อน");
                return;
                    
            }
            BookType bt = new BookType();
            bt.bookTypeName = txtBookTypeName.Text;
            bt.bookTypeID = int.Parse(labBookTypeID.Text);
            bt.update();
            this.showDgvBookType();
            this.clearform();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (labBookTypeID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่จะลบก่อน");
                return;

            }
            BookType bt = new BookType();
            bt.bookTypeID = int.Parse(labBookTypeID.Text);
            bt.delete();
            this.showDgvBookType();
            this.clearform();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(txtCondition.Text,
                out int bookTypeID);
            BookType bt = new BookType();
            DataTable dt;
            if (isNumber)
            {
                bt.bookTypeID = bookTypeID;
               dt=bt.readByID();

            }
            else
            {
                bt.bookTypeName = txtCondition.Text;
                dt=bt.readByName();
            }
            if (dt.Rows.Count > 0)
                dgvBookType.DataSource = dt;
                this.clearform();
            MessageBox.Show("ไม่พบข้อมูล");

        }
    }
}
