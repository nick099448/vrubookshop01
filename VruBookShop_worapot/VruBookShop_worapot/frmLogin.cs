using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VruBookShop_worapot.Admin;
using VruBookShop_worapot.Manager;
using VruBookShop_worapot.SalePerson;
using VruBookShop_worapot.StockPerson;

using System.Data.SqlClient;


using System.Windows.Forms;

namespace VruBookShop_worapot
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection();
        public frmLogin()
        {
            InitializeComponent();
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            //ตรวจสอบการป้อนข้อมูล
            if (txtUsername.Text=="" || txtPassword.Text == "")
            {
                MessageBox.Show("ป้อนข้อมูลก่อน", "ผิดพลาด", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                return;
            }
            //นำ username , password ไปค้นในตาราง
            //เขียนคำสั่งsql ประการตัวแปรเก็บชุดคำสั่ง 
            string sql = "SELECT * FROM tb_Employee " +
                " LEFT JOIN tb_Position " +
                " ON tb_Employee.posID=tb_Position.posID " +
                " WHERE username = @username AND password=@password";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.SelectCommand.Parameters.AddWithValue("username", txtUsername.Text);
            da.SelectCommand.Parameters.AddWithValue("password", txtPassword.Text);
            //ประกาศอ็อปเจ็กของคลาส DataTable เก็บผลลัพธ์
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ตรวจสอบว่ามีข้อมูลหรือไม่จาก DataTable
            if(dt.Rows.Count>0) //มีข้อมูล
            {
                string empID = dt.Rows[0]["empID"].ToString();
                string empName = dt.Rows[0]["empName"].ToString();
                string posName = dt.Rows[0]["posName"].ToString();
                /* MessageBox.Show("พบข้อมูล" + Environment.NewLine + 
                  "รหัส "+ empID + Environment.NewLine +
                  "ชื่อ " + empName + Environment.NewLine +
                  "ตำแหน่ง " + posName ); */
                //นำตำแหน่งมาตรวจสอบ เพื่อเปิดฟอร์มรายการทำงาน
                if (posName == "พนักงานขาย")
                {
                    frmSalePersonMenu frm = new frmSalePersonMenu(empID,empName,posName);
                    frm.Show();
                }else if (posName == "พนักงานคลังสินค้า")
                {
                    frmStockPersonMenu frm = new frmStockPersonMenu(empID, empName, posName);
                    frm.Show();
                }
                else if(posName == "ผู้จัดการ")
                {
                    frmManagerMenu frm = new frmManagerMenu();
                    frm.Show();
                    
                }else if (posName == "ผู้ดูแลระบบ")
                {
                    frmAdminMenu frm = new frmAdminMenu();
                    frm.Show();
                }else
                {
                    MessageBox.Show("ไม่พบข้อมูล");
                }
                
            }
            else //ไม่มีข้อมูล
            {
                MessageBox.Show("ไม่พบข้อมูล");
            }    
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            try {
                //กำหนดการเชื่อมต่อกับฐานข้อมูล
                con.ConnectionString = "Server = .\\sqlexpress;" +
               "database=dbBookShop;integrated security=true";
                //เปิดการเชื่อมต่อ
                con.Open();
                
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
 