
namespace VruBookShop_worapot.SalePerson
{
    partial class frmSaleReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dEnd = new System.Windows.Forms.DateTimePicker();
            this.dBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.saleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dEnd);
            this.groupBox1.Controls.Add(this.dBegin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาข้อมูล";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::VruBookShop_worapot.Properties.Resources.iconfinder_print_56096;
            this.btnPrint.Location = new System.Drawing.Point(987, 56);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 76);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "พิมพ์รายงาน";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::VruBookShop_worapot.Properties.Resources.iconfinder_search_basic_red_69956;
            this.btnSearch.Location = new System.Drawing.Point(851, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 77);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dEnd
            // 
            this.dEnd.Location = new System.Drawing.Point(535, 74);
            this.dEnd.Name = "dEnd";
            this.dEnd.Size = new System.Drawing.Size(284, 22);
            this.dEnd.TabIndex = 3;
            // 
            // dBegin
            // 
            this.dBegin.Location = new System.Drawing.Point(142, 72);
            this.dBegin.Name = "dBegin";
            this.dBegin.Size = new System.Drawing.Size(284, 22);
            this.dBegin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ถึงวันที่";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่";
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleID,
            this.empID1,
            this.saleDate,
            this.bookID,
            this.bookName,
            this.price,
            this.amount,
            this.total});
            this.dgvSale.Location = new System.Drawing.Point(34, 213);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowTemplate.Height = 24;
            this.dgvSale.Size = new System.Drawing.Size(1143, 348);
            this.dgvSale.TabIndex = 1;
            // 
            // saleID
            // 
            this.saleID.DataPropertyName = "saleID";
            this.saleID.FillWeight = 80F;
            this.saleID.HeaderText = "รหัสการขาย";
            this.saleID.MinimumWidth = 6;
            this.saleID.Name = "saleID";
            this.saleID.Width = 110;
            // 
            // empID1
            // 
            this.empID1.DataPropertyName = "empID";
            this.empID1.HeaderText = "รหัสพนักงานขาย";
            this.empID1.MinimumWidth = 6;
            this.empID1.Name = "empID1";
            this.empID1.Visible = false;
            this.empID1.Width = 130;
            // 
            // saleDate
            // 
            this.saleDate.DataPropertyName = "saleDate";
            this.saleDate.FillWeight = 80F;
            this.saleDate.HeaderText = "วันที่ขาย";
            this.saleDate.MinimumWidth = 6;
            this.saleDate.Name = "saleDate";
            this.saleDate.Width = 125;
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
            this.amount.HeaderText = "จำนวนที่ขาย";
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
            // frmSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 599);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmSaleReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dEnd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}