
namespace VruBookShop_worapot.Admin
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.labEmpID = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnEdit,
            this.btnDelete,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.txtCondition,
            this.btnSearch,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(1564, 69);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(72, 56);
            this.btnSave.Text = "จัดเก็บ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnEdit.Size = new System.Drawing.Size(64, 56);
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.Text = "ลบ";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 56);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 56);
            this.toolStripLabel2.Text = "ใส่รหัสหรือชื่อ";
            // 
            // txtCondition
            // 
            this.txtCondition.AutoToolTip = true;
            this.txtCondition.BackColor = System.Drawing.SystemColors.Window;
            this.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(200, 59);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSearch.Size = new System.Drawing.Size(67, 56);
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnClose.Size = new System.Drawing.Size(83, 56);
            this.btnClose.Text = "ปิดฟอร์ม";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.empName,
            this.gender,
            this.address,
            this.telephone,
            this.username,
            this.password,
            this.empPicture,
            this.posName});
            this.dgvEmployee.Location = new System.Drawing.Point(299, 94);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(1092, 463);
            this.dgvEmployee.TabIndex = 4;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // empID
            // 
            this.empID.DataPropertyName = "empID";
            this.empID.FillWeight = 80F;
            this.empID.HeaderText = "รหัสพนักงาน";
            this.empID.MinimumWidth = 6;
            this.empID.Name = "empID";
            this.empID.Width = 80;
            // 
            // empName
            // 
            this.empName.DataPropertyName = "empName";
            this.empName.HeaderText = "ชื่อ-สกุล";
            this.empName.MinimumWidth = 6;
            this.empName.Name = "empName";
            this.empName.Width = 80;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "เพศ";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 60;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "ที่อยู่";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // telephone
            // 
            this.telephone.DataPropertyName = "telephone";
            this.telephone.HeaderText = "โทรศัพท์";
            this.telephone.MinimumWidth = 6;
            this.telephone.Name = "telephone";
            this.telephone.Width = 125;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "ชื่อผู้ใช้งาน";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "รหัสผ่าน";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 125;
            // 
            // empPicture
            // 
            this.empPicture.DataPropertyName = "empPicture";
            this.empPicture.HeaderText = "รูปภาพ";
            this.empPicture.MinimumWidth = 6;
            this.empPicture.Name = "empPicture";
            this.empPicture.Width = 125;
            // 
            // posName
            // 
            this.posName.DataPropertyName = "posName";
            this.posName.HeaderText = "ตำแหน่ง";
            this.posName.MinimumWidth = 6;
            this.posName.Name = "posName";
            this.posName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ชื่อ-สกุล *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "เพศ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ที่อยู่";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "โทรศัพท์";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "username *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "password *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "ตำแหน่ง";
            // 
            // txtEmpName
            // 
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Location = new System.Drawing.Point(115, 102);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(146, 22);
            this.txtEmpName.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(115, 337);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 22);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(117, 294);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 22);
            this.txtUsername.TabIndex = 14;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelephone.Location = new System.Drawing.Point(117, 248);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(146, 22);
            this.txtTelephone.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(117, 201);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(146, 22);
            this.txtAddress.TabIndex = 16;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(110, 147);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(50, 21);
            this.radMale.TabIndex = 17;
            this.radMale.TabStop = true;
            this.radMale.Text = "ชาย";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(182, 147);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(54, 21);
            this.radFemale.TabIndex = 18;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "หญิง";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "รูปภาพ";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(116, 437);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(126, 72);
            this.picture.TabIndex = 20;
            this.picture.TabStop = false;
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(115, 389);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(142, 24);
            this.cboPosition.TabIndex = 21;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(115, 528);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(121, 29);
            this.btnSelectPicture.TabIndex = 22;
            this.btnSelectPicture.Text = "เลือกรูปภาพ";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // labEmpID
            // 
            this.labEmpID.AutoSize = true;
            this.labEmpID.Location = new System.Drawing.Point(263, 101);
            this.labEmpID.Name = "labEmpID";
            this.labEmpID.Size = new System.Drawing.Size(0, 17);
            this.labEmpID.TabIndex = 23;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 583);
            this.Controls.Add(this.labEmpID);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลพนักงาน";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtCondition;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Label labEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn posName;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}