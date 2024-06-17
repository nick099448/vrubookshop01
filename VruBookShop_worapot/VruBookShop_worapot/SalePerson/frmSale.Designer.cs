
namespace VruBookShop_worapot.SalePerson
{
    partial class frmSale
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labSaleDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labCost = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labBookName = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCloes = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labTotalAll = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(845, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่ขาย";
            // 
            // labSaleDate
            // 
            this.labSaleDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labSaleDate.Location = new System.Drawing.Point(904, 31);
            this.labSaleDate.Name = "labSaleDate";
            this.labSaleDate.Size = new System.Drawing.Size(228, 26);
            this.labSaleDate.TabIndex = 1;
            this.labSaleDate.Text = "label2";
            this.labSaleDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labCost);
            this.groupBox1.Controls.Add(this.labTotal);
            this.groupBox1.Controls.Add(this.labPrice);
            this.groupBox1.Controls.Add(this.labBookName);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(63, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labCost
            // 
            this.labCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCost.Location = new System.Drawing.Point(233, 62);
            this.labCost.Name = "labCost";
            this.labCost.Size = new System.Drawing.Size(68, 23);
            this.labCost.TabIndex = 10;
            this.labCost.Text = "label2";
            // 
            // labTotal
            // 
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotal.Location = new System.Drawing.Point(542, 65);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(68, 23);
            this.labTotal.TabIndex = 9;
            this.labTotal.Text = "label10";
            // 
            // labPrice
            // 
            this.labPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPrice.Location = new System.Drawing.Point(307, 65);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(78, 23);
            this.labPrice.TabIndex = 8;
            this.labPrice.Text = "label9";
            // 
            // labBookName
            // 
            this.labBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labBookName.Location = new System.Drawing.Point(107, 63);
            this.labBookName.Name = "labBookName";
            this.labBookName.Size = new System.Drawing.Size(120, 23);
            this.labBookName.TabIndex = 7;
            this.labBookName.Text = "label8";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(412, 63);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(79, 22);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = global::VruBookShop_worapot.Properties.Resources.iconfinder_001_01_9588;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(888, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "เพิ่มรายการขาย";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(36, 64);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(55, 22);
            this.txtBookID.TabIndex = 5;
            this.txtBookID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookID_KeyDown);
            this.txtBookID.Leave += new System.EventHandler(this.txtBookID_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "รวมเงิน";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "จำนวน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "ราคาขาย";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ชื่อหนังสือ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "รหัสหนังสือ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSale);
            this.groupBox2.Location = new System.Drawing.Point(58, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 330);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookName,
            this.cost,
            this.price,
            this.amount,
            this.total});
            this.dgvSale.Location = new System.Drawing.Point(6, 21);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowTemplate.Height = 24;
            this.dgvSale.Size = new System.Drawing.Size(743, 295);
            this.dgvSale.TabIndex = 0;
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "bookID";
            this.bookID.HeaderText = "รหัสหนังสือ";
            this.bookID.MinimumWidth = 6;
            this.bookID.Name = "bookID";
            this.bookID.Width = 125;
            // 
            // bookName
            // 
            this.bookName.DataPropertyName = "bookName";
            this.bookName.HeaderText = "ชื่อหนังสือ";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.Width = 125;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "ต้นทุน";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "ราคาขาย";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "จำนวน";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "รวมเงิน";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCloes);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(868, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 329);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnCloes
            // 
            this.btnCloes.Image = global::VruBookShop_worapot.Properties.Resources.iconfinder_close_delete_7097511;
            this.btnCloes.Location = new System.Drawing.Point(83, 226);
            this.btnCloes.Name = "btnCloes";
            this.btnCloes.Size = new System.Drawing.Size(97, 55);
            this.btnCloes.TabIndex = 4;
            this.btnCloes.Text = "button5";
            this.btnCloes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCloes.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::VruBookShop_worapot.Properties.Resources.iconfinder_Gnome_Edit_Clear_32_54970;
            this.btnClear.Location = new System.Drawing.Point(83, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 58);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "เคลียร์ฟอร์ม";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::VruBookShop_worapot.Properties.Resources.iconfinder_print_56096;
            this.btnPrint.Location = new System.Drawing.Point(86, 81);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 54);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "พิมพ์ใบเสร็จ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Image = global::VruBookShop_worapot.Properties.Resources.iconfinder_001_01_9588;
            this.btnSave.Location = new System.Drawing.Point(86, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 56);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "จัดเก็บ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labTotalAll
            // 
            this.labTotalAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalAll.Location = new System.Drawing.Point(922, 554);
            this.labTotalAll.Name = "labTotalAll";
            this.labTotalAll.Size = new System.Drawing.Size(152, 41);
            this.labTotalAll.TabIndex = 5;
            this.labTotalAll.Text = "  ";
            this.labTotalAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(803, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 52);
            this.label11.TabIndex = 10;
            this.label11.Text = "รวมเงิน";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 667);
            this.Controls.Add(this.labTotalAll);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labSaleDate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ขายหนังสือ";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labBookName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnCloes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labCost;
        private System.Windows.Forms.Label labTotalAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label labSaleDate;
    }
}