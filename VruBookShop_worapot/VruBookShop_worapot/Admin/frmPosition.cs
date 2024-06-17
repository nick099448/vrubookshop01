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

namespace VruBookShop_worapot.Admin
{
    public partial class frmPosition : Form
    {
        SqlConnection con = new SqlConnection();
        public frmPosition()
        {
            InitializeComponent();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=.\\sqlexpress;" +
                "database=dbBookShop;integrated security=true";
            con.Open();
            this.showDgvPosition();
        }


        private void showDgvPosition()
        {
            //แสดงข้อมูลตำแหน่ง ใน  datagridview
            String sql = "SELECT * FROM tb_Position";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgvPosition.DataSource = dt ;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //ค้นหาข้อมูล ในตารางtbPosition    
            //ตรวจสอบ user ป้อนตัวเลขหรือข้อความ
            bool isNumber = int.TryParse(txtCondition.Text, out int posID);
            string sql = "";
            if (isNumber) //เป็นตัวเลข
            {
                sql = "SELECT * FROM tb_Position WHERE posID=@posID";

            }
            else  //ไม่เป็นตัวเลข
            {
                sql = "SELECT * FROM tb_Position WHERE posName LIKE @posName";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("posID", txtCondition.Text);
            da.SelectCommand.Parameters.AddWithValue("posName", "%"+txtCondition.Text+ "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                dgvPosition.DataSource = dt;
            else
                MessageBox.Show("ไม่พบข้อมูล");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ตรวจสอบกานป้อนข้อมูล
            if(txtPosName.Text == "")
            {
                MessageBox.Show("ป้อนข้อมุลก่อน", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  txtPosName.Focus();
                return;

            }
            string sql = "INSERT INTO tb_Position  (posName) VALUES (@posName)";
            SqlCommand cm = new SqlCommand(sql,con);
            cm.Parameters.AddWithValue("posName", txtPosName.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("จัดเก็บข้อมูลแล้ว", "ผลลัพธ์",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.showDgvPosition();
            //  txtPosName.Focus();
            txtPosName.Clear();
        }

        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //นำข้อมูลที่คลิกในที่ datagridview ไปแสดงบนฟอร์ม
            txtPosName.Text = dgvPosition.Rows[e.RowIndex].Cells["posName"].Value.ToString();
            labPosID.Text = dgvPosition.Rows[e.RowIndex].Cells["posID"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่าเลือกข้อมูลรึยัง
           if(labPosID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลก่อน", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  txtPosName.Focus();
                return;
            }
            //เขียน sql ลบ
            string sql = "DELETE FROM tb_Position WHERE posID=@posID";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("posID", labPosID.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("ต้องการลบใช่หรือไม่", "ผิดพลาด",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  txtPosName.Focus();
            this.showDgvPosition();
            txtPosName.Clear();
            labPosID.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (labPosID.Text == "")
            {
                MessageBox.Show("เลือกข้อมูลที่จะแก้ไขก่อน", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  txtPosName.Focus();
                return;
            }
            string sql = "UPDATE tb_Position SET posName=@posName WHERE posID=@posID" ;
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("posName", txtPosName.Text);
            cm.Parameters.AddWithValue("posID", labPosID.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("แก้ไขข้อมูลแล้ว", "ผลลัพธ์", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.showDgvPosition();
            txtPosName.Clear();labPosID.Text = "";
        }
    }
}
