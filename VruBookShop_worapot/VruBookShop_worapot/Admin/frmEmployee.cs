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
using System.IO;
namespace VruBookShop_worapot.Admin 
{
    public partial class frmEmployee : Form
    {
       
        SqlConnection con = new SqlConnection();
        string imagePath = Application.StartupPath.Substring(0,
            Application.StartupPath.Length - 9) + "images\\Empimages\\";
        public frmEmployee()
        {
            InitializeComponent();
        }
        bool selectPic = false; //กำหนดตัวแปรเก็บสถานะการเลือกรูปภาพ

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=.\\sqlexpress;" +
                "database=dbBookShop;integrated security=true";
            con.Open();
            this.showDgvEmployee();
            this.showCboPosition();

        }
        private void showCboPosition() //สร้างเมธอด เพื่อนำข้อมูลตำแหน่งงมาแสดง 
        {
            string sql = " SELECT * FROM tb_Position";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                //นำข้อมูลใส่คอมโบบล็อค
                cboPosition.DataSource = dt;
                cboPosition.DisplayMember = "posName";
                cboPosition.ValueMember = "posID";
            }
        }
        private void showDgvEmployee()
        {
            //แสดงข้อมูลตำแหน่ง ใน  datagridview
            String sql = "SELECT empID,empName,address,telephone," +
                "username,password,empPicture,posName,gender FROM tb_Employee " +
                "LEFT JOIN tb_Position ON tb_Employee.posID=tb_Position.posID ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgvEmployee.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ค้นหาข้อมูล ในตารางtbPosition    
            //ตรวจสอบ user ป้อนตัวเลขหรือข้อความ
            bool isNumber = int.TryParse(txtCondition.Text, out int empID);
            string sql = "SELECT empID,empName,address,telephone," +
                 "username,password,empPicture,posName,gender FROM tb_Employee " +
                 "LEFT JOIN tb_Position ON tb_Employee.posID=tb_Position.posID " ;
            if (isNumber) //เป็นตัวเลข
            {
                sql += " WHERE empID=@empID"
                ;

            }
            else  //ไม่เป็นตัวเลข
            {
                sql += "WHERE empName LIKE @empName";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("empID", txtCondition.Text);
            da.SelectCommand.Parameters.AddWithValue("empName", "%" + txtCondition.Text + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                dgvEmployee.DataSource = dt;
            else
                MessageBox.Show("ไม่พบข้อมูล");
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //นำข้อมูลที่ user ในตารางมาแสดงในฟอร์ม 
            labEmpID.Text = dgvEmployee.Rows[e  .RowIndex].Cells["empID"].Value.ToString();
            txtEmpName.Text = dgvEmployee.Rows[e.RowIndex].Cells["empName"].Value.ToString();
            txtAddress.Text = dgvEmployee.Rows[e.RowIndex].Cells["address"].Value.ToString();
            txtTelephone.Text = dgvEmployee.Rows[e.RowIndex].Cells["telephone"].Value.ToString();
            txtUsername.Text = dgvEmployee.Rows[e.RowIndex].Cells["username"].Value.ToString();
            txtPassword.Text = dgvEmployee.Rows[e.RowIndex].Cells["password"].Value.ToString();

            if (dgvEmployee.Rows[e.RowIndex].Cells["gender"].Value.ToString() == "ชาย")
                radMale.Checked = true;
            else if (dgvEmployee.Rows[e.RowIndex].Cells["gender"].Value.ToString() == "หญิง")
                radFemale.Checked = true;

            cboPosition.Text = dgvEmployee.Rows[e.RowIndex].Cells["posName"].Value.ToString();

            string picname = dgvEmployee.Rows[e.RowIndex].Cells["empPicture"].Value.ToString();
            if (File.Exists(imagePath + picname))
            {
                Image image = Image.FromFile(imagePath + picname);
                picture.Image = new Bitmap(image);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                image.Dispose();
            }
            else
            {
                picture.Image = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่า user เลือกข้อมูลที่จะลบหรือยัง
            if (labEmpID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่จะลบในตารางก่อน", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("ต้องการลบข้อมูลใช่หรือไม่", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string sql = "DELETE FROM tb_Employee WHERE empID=@empID";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("empID", labEmpID.Text);
                cm.ExecuteNonQuery();
                this.showDgvEmployee();
            }
        }
        private void clearFrom()
        {
            labEmpID.Text = ""; txtEmpName.Clear(); txtAddress.Clear();
            txtCondition.Clear(); txtPassword.Clear(); txtUsername.Clear(); txtTelephone.Clear();
            radMale.Checked = false; radFemale.Checked = false; cboPosition.Text = "";
            picture.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ตรวจสอบข้อมูลที่ต้องป้อน
            if (txtEmpName.Text == "" || txtUsername.Text == "" ||
                txtPassword.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลที่กำหนดก่อน", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //กรณีเพิ่มแล้ว เขียน sql เพิ่มข้อมูล
            string sql = "INSERT INTO tb_Employee (empName," +
                "gender,address,telephone,username,password," +
                "empPicture,posID)VALUES(@empName,@gender," +
                "@address,@telephone,@username,@password," +
                "@empPicture,@posID)";
            SqlCommand cm = new SqlCommand(sql, con);
            
            string gender = radMale.Checked ? "ชาย" : radFemale.Checked ? "หญิง" : "";
            string pictureName = "";
            if (selectPic)
            {
                string[] data = ofd.SafeFileName.Split('.');
                pictureName = txtUsername.Text + "." + data[1];
                //คัดลอกไฟล์ไปที่ project 
                File.Copy(ofd.FileName,imagePath+pictureName,true);
                selectPic = false;
            }
            cm.Parameters.AddWithValue("empName", txtEmpName.Text);
            cm.Parameters.AddWithValue("gender", gender);
            cm.Parameters.AddWithValue("address", txtAddress.Text);
            cm.Parameters.AddWithValue("telephone", txtTelephone.Text);
            cm.Parameters.AddWithValue("username", txtUsername.Text);
            cm.Parameters.AddWithValue("password", txtPassword.Text);
            cm.Parameters.AddWithValue("empPicture", pictureName);
            cm.Parameters.AddWithValue("posID", cboPosition.SelectedValue);
            cm.ExecuteNonQuery();
            MessageBox.Show("จัดเก็บข้อมูลแล้ว");
            this.showDgvEmployee();
            this.clearFrom();
        }

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (labEmpID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่จะแก้ไขในตารางก่อน", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //เขียนsqlเพื่อแก้ไขข้อมูล 
            string sql = "";
            if (selectPic)
                sql = "UPDATE tb_Employee SET empName=@empName,gender=@gender,address=@address," +
                "telephone=@telephone,password=@password,empPicture=@empPicture,posID=@posID " +
                "WHERE empID=@empID";
            else
                sql = "UPDATE tb_Employee SET empName=@empName,gender=@gender,address=@address," +
              "telephone=@telephone,password=@password,posID=@posID " +
              "WHERE empID=@empID";

            SqlCommand cm = new SqlCommand(sql, con);
            string pictureName = "";
            string gender = radMale.Checked ? "ชาย" : radFemale.Checked ? "หญิง" : "";
            if (selectPic)
            {
                string[] data = ofd.SafeFileName.Split('.');
                pictureName = txtUsername.Text + "." + data[1];
                //คัดลอกไฟล์ไปที่ project 
                File.Copy(ofd.FileName, imagePath + pictureName, true);
                selectPic = false;
            }
            cm.Parameters.AddWithValue("empName", txtEmpName.Text);
            cm.Parameters.AddWithValue("gender", gender);
            cm.Parameters.AddWithValue("address", txtAddress.Text);
            cm.Parameters.AddWithValue("telephone", txtTelephone.Text);
            cm.Parameters.AddWithValue("username", txtUsername.Text);
            cm.Parameters.AddWithValue("password", txtPassword.Text);
            cm.Parameters.AddWithValue("empPicture", pictureName);
            cm.Parameters.AddWithValue("posID", cboPosition.SelectedValue);
            cm.Parameters.AddWithValue("empID", labEmpID.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("แก้ไขข้มูลแล้ว");
            this.showDgvEmployee();
            this.clearFrom();
        }
    }

    }

