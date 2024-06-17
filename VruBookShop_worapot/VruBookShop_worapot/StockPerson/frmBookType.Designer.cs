
namespace VruBookShop_worapot.StockPerson
{
    partial class frmBookType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookType));
            this.labBookTypeID = new System.Windows.Forms.Label();
            this.dgvBookType = new System.Windows.Forms.DataGridView();
            this.txtBookTypeName = new System.Windows.Forms.TextBox();
            this.txtPosName1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookType)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labBookTypeID
            // 
            this.labBookTypeID.AutoSize = true;
            this.labBookTypeID.Location = new System.Drawing.Point(546, 120);
            this.labBookTypeID.Name = "labBookTypeID";
            this.labBookTypeID.Size = new System.Drawing.Size(0, 17);
            this.labBookTypeID.TabIndex = 9;
            // 
            // dgvBookType
            // 
            this.dgvBookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookType.Location = new System.Drawing.Point(42, 175);
            this.dgvBookType.Name = "dgvBookType";
            this.dgvBookType.RowHeadersWidth = 51;
            this.dgvBookType.RowTemplate.Height = 24;
            this.dgvBookType.Size = new System.Drawing.Size(693, 255);
            this.dgvBookType.TabIndex = 8;
            this.dgvBookType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookType_CellClick);
            // 
            // txtBookTypeName
            // 
            this.txtBookTypeName.Location = new System.Drawing.Point(142, 115);
            this.txtBookTypeName.Name = "txtBookTypeName";
            this.txtBookTypeName.Size = new System.Drawing.Size(357, 22);
            this.txtBookTypeName.TabIndex = 7;
            // 
            // txtPosName1
            // 
            this.txtPosName1.AutoSize = true;
            this.txtPosName1.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPosName1.Location = new System.Drawing.Point(39, 120);
            this.txtPosName1.Name = "txtPosName1";
            this.txtPosName1.Size = new System.Drawing.Size(87, 17);
            this.txtPosName1.TabIndex = 6;
            this.txtPosName1.Text = "ประเภทหนังสือ";
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 69);
            this.toolStrip1.TabIndex = 5;
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
            this.txtCondition.BackColor = System.Drawing.SystemColors.Window;
            this.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // frmBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labBookTypeID);
            this.Controls.Add(this.dgvBookType);
            this.Controls.Add(this.txtBookTypeName);
            this.Controls.Add(this.txtPosName1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ประเภทหนังสือ";
            this.Load += new System.EventHandler(this.frmBookType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookType)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBookTypeID;
        private System.Windows.Forms.DataGridView dgvBookType;
        private System.Windows.Forms.TextBox txtBookTypeName;
        private System.Windows.Forms.Label txtPosName1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtCondition;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnClose;
    }
}