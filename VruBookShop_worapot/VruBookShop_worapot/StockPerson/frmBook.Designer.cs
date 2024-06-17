
namespace VruBookShop_worapot.StockPerson
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.labBookID = new System.Windows.Forms.Label();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.cboBookType = new System.Windows.Forms.ComboBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // labBookID
            // 
            this.labBookID.AutoSize = true;
            this.labBookID.Location = new System.Drawing.Point(247, 107);
            this.labBookID.Name = "labBookID";
            this.labBookID.Size = new System.Drawing.Size(0, 17);
            this.labBookID.TabIndex = 44;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(122, 435);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(121, 29);
            this.btnSelectPicture.TabIndex = 43;
            this.btnSelectPicture.Text = "เลือกรูปภาพ";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // cboBookType
            // 
            this.cboBookType.FormattingEnabled = true;
            this.cboBookType.Location = new System.Drawing.Point(122, 297);
            this.cboBookType.Name = "cboBookType";
            this.cboBookType.Size = new System.Drawing.Size(142, 24);
            this.cboBookType.TabIndex = 42;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(122, 338);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(126, 72);
            this.picture.TabIndex = 41;
            this.picture.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "รูปภาพ";
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.Location = new System.Drawing.Point(122, 150);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(111, 22);
            this.txtCost.TabIndex = 37;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(122, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(146, 22);
            this.txtPrice.TabIndex = 36;
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Location = new System.Drawing.Point(122, 243);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(146, 22);
            this.txtStock.TabIndex = 35;
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Location = new System.Drawing.Point(122, 108);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(111, 22);
            this.txtBookName.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "ประเภทหนังสือ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "จำนวน *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "ราคาขาย *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "ราคาทุน *";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ชื่อหนังสือ *";
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
            this.toolStrip1.Size = new System.Drawing.Size(1092, 69);
            this.toolStrip1.TabIndex = 24;
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
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookName,
            this.cost,
            this.price,
            this.stock,
            this.bookPicture,
            this.bookTypeName});
            this.dgvBook.Location = new System.Drawing.Point(283, 100);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(771, 463);
            this.dgvBook.TabIndex = 25;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "bookID";
            this.bookID.FillWeight = 80F;
            this.bookID.HeaderText = "รหัสหนังสือ";
            this.bookID.MinimumWidth = 6;
            this.bookID.Name = "bookID";
            this.bookID.Width = 80;
            // 
            // bookName
            // 
            this.bookName.DataPropertyName = "bookName";
            this.bookName.HeaderText = "ชื่อหนังสือ";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.Width = 80;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "ราคาทุน";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.Width = 60;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "ราคาขาย";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "จำนวน";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.Width = 125;
            // 
            // bookPicture
            // 
            this.bookPicture.DataPropertyName = "bookPicture";
            this.bookPicture.HeaderText = "ไฟล์รูปภาพ";
            this.bookPicture.MinimumWidth = 6;
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Width = 125;
            // 
            // bookTypeName
            // 
            this.bookTypeName.DataPropertyName = "bookTypeName";
            this.bookTypeName.HeaderText = "ประเภทหนังสือ";
            this.bookTypeName.MinimumWidth = 6;
            this.bookTypeName.Name = "bookTypeName";
            this.bookTypeName.Width = 125;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 631);
            this.Controls.Add(this.labBookID);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.cboBookType);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลหนังสือ";
            this.Load += new System.EventHandler(this.frmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBookID;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.ComboBox cboBookType;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtCondition;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTypeName;
    }
}