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
using System.IO;

namespace VruBookShop_worapot.StockPerson
{
    public partial class frmBook : Form
    {
        string imagePath = Application.StartupPath.Substring(0,
           Application.StartupPath.Length - 9) + "images\\Empimages\\";
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
             this.showDgvBook();
            this.showCboBookType();
        }
        private void showCboBookType()
        {
            //นำประเภทหนังสือมาแสดงที่ cbobooktype
            BookType booktype = new BookType();
            cboBookType.DataSource = booktype.read();
            cboBookType.DisplayMember = "bookTypeName";
            cboBookType.ValueMember = "bookTypeID";
            
        }
        private void showDgvBook() //อ่านข้อมูลตาราง Book
        {
            Book book = new Book();
            DataTable dt = new DataTable();
            dt = book.read();
            if (dt.Rows.Count > 0)
                dgvBook.DataSource = dt;
            else
                MessageBox.Show("ไม่พบข้อมูลหนังสือ");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(labBookID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลในตารางก่อน");
                return;

            }
            string pictureName = picname;
            Book book = new Book();
            if (selectPic)//มีการเลือกรูปหรือเปลี่ยนรูป    
            {
                string[] data = ofd.SafeFileName.Split('.');
                pictureName = labBookID.Text + "." + data[1];
                //คัดลอกไฟล์ไปที่ project 
                File.Copy(ofd.FileName, imagePath + pictureName, true);
                selectPic = false;
            }
            book.bookID = int.Parse(labBookID.Text);
            book.bookName = txtBookName.Text;
            book.cost = int.Parse(txtCost.Text);
            book.price = int.Parse(txtPrice.Text);
            book.stock = int.Parse(txtStock.Text);
            book.bookPicture = pictureName;
            book.bookTypeID = int.Parse(cboBookType.SelectedValue.ToString());
            book.update();
            book.create();
            this.showDgvBook();
        }
        bool selectPic = false;
        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            ofd.Filter = "เลือกไฟล์รูปภาพที่ระบุ|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(ofd.FileName);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                selectPic = true;
                //MessageBox.Show(ofd.FileName + Environment.NewLine +
                //     ofd.SafeFileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ตรวจสอบการป้อนข้อมูล
            if (txtBookName.Text == "" || txtCost.Text == ""
                || txtPrice.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลก่อน");
                return;
            }
            Book book = new Book();
            string pictureName = "";
            if (selectPic)
            {
                string[] data = ofd.SafeFileName.Split('.');
                pictureName = book.getAutoNumber().ToString() + "." + data[1];
                //คัดลอกไฟล์ไปที่ project 
                File.Copy(ofd.FileName, imagePath + pictureName, true);
                selectPic = false;
            }
           
            book.bookName = txtBookName.Text;
            book.cost = int.Parse(txtCost.Text);
            book.price = int.Parse(txtPrice.Text);
            book.stock = int.Parse(txtStock.Text);
            book.bookPicture = pictureName;
            book.bookTypeID = int.Parse(cboBookType.SelectedValue.ToString());
            book.create();
            this.showDgvBook();
          //  this.clearFrom();
        }
        string picname = "";
        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("");
            labBookID.Text = dgvBook.Rows[e.RowIndex].Cells["bookID"].Value.ToString();
            txtBookName.Text = dgvBook.Rows[e.RowIndex].Cells["bookName"].Value.ToString();
            txtCost.Text = dgvBook.Rows[e.RowIndex].Cells["cost"].Value.ToString();
            txtPrice.Text = dgvBook.Rows[e.RowIndex].Cells["price"].Value.ToString();
            txtStock.Text = dgvBook.Rows[e.RowIndex].Cells["stock"].Value.ToString();
            cboBookType.Text = dgvBook.Rows[e.RowIndex].Cells["bookTypeName"].Value.ToString();
            picname = dgvBook.Rows[e.RowIndex].Cells["bookPicture"].Value.ToString();
            if (File.Exists(imagePath + picname))
            {
                Image image = Image.FromFile(imagePath + picname);
                picture.Image = new Bitmap(image);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                image.Dispose();
            }else
            {
                picture.Image = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(labBookID.Text == "")
            {
                MessageBox.Show("เลือกข้แมูลในตารางก่อน");
                return;
            }
            Book book = new Book();
            book.bookID = int.Parse(labBookID.Text);
            book.delete();
            this.showDgvBook();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            bool isNumber = int.TryParse(txtCondition.Text,
                out int bookID);
            Book book = new Book();
            DataTable dt;
            if (isNumber)
            {
                book.bookTypeID = bookID;
                dt = book.readByID();

            }
            else
            {
                book.bookName = txtCondition.Text;
                dt = book.readByName();
            }
            if (dt.Rows.Count > 0)
                dgvBook.DataSource = dt;
         //  this.clearform();
            MessageBox.Show("ไม่พบข้อมูล");

        }
    }
}
