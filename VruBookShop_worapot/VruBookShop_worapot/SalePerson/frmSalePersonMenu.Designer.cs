
namespace VruBookShop_worapot.SalePerson
{
    partial class frmSalePersonMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalePersonMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSale = new System.Windows.Forms.ToolStripButton();
            this.btnReportSale = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSale,
            this.btnReportSale,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(767, 73);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(767, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labUser
            // 
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(151, 20);
            this.labUser.Text = "toolStripStatusLabel1";
            // 
            // btnSale
            // 
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSale.Name = "btnSale";
            this.btnSale.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSale.Size = new System.Drawing.Size(97, 70);
            this.btnSale.Text = "ขายหนังสือ";
            this.btnSale.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnReportSale
            // 
            this.btnReportSale.Image = ((System.Drawing.Image)(resources.GetObject("btnReportSale.Image")));
            this.btnReportSale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportSale.Name = "btnReportSale";
            this.btnReportSale.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnReportSale.Size = new System.Drawing.Size(122, 70);
            this.btnReportSale.Text = "รายงานการขาย";
            this.btnReportSale.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnReportSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportSale.Click += new System.EventHandler(this.btnReportSale_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnClose.Size = new System.Drawing.Size(83, 70);
            this.btnClose.Text = "ปิดฟอร์ม";
            this.btnClose.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSalePersonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 291);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmSalePersonMenu";
            this.Text = "รายการทำงานของพนักงานขาย";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalePersonMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSale;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnReportSale;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labUser;
    }
}