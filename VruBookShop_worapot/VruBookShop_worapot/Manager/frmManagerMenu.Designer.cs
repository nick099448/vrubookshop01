
namespace VruBookShop_worapot.Manager
{
    partial class frmManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReport = new System.Windows.Forms.ToolStripSplitButton();
            this.รายงานการขายประจำวนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานการขายประจำเดอนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReport,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(743, 73);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = false;
            this.btnReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายงานการขายประจำวนToolStripMenuItem,
            this.รายงานการขายประจำเดอนToolStripMenuItem});
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(83, 70);
            this.btnReport.Text = "รายงาน";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // รายงานการขายประจำวนToolStripMenuItem
            // 
            this.รายงานการขายประจำวนToolStripMenuItem.Name = "รายงานการขายประจำวนToolStripMenuItem";
            this.รายงานการขายประจำวนToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.รายงานการขายประจำวนToolStripMenuItem.Text = "รายงานการขายประจำวัน";
            // 
            // รายงานการขายประจำเดอนToolStripMenuItem
            // 
            this.รายงานการขายประจำเดอนToolStripMenuItem.Name = "รายงานการขายประจำเดอนToolStripMenuItem";
            this.รายงานการขายประจำเดอนToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.รายงานการขายประจำเดอนToolStripMenuItem.Text = "รายงานการขายประจำเดือน";
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(743, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 288);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagerMenu";
            this.Text = "รายการทำงานของผู้จัดการ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton btnReport;
        private System.Windows.Forms.ToolStripMenuItem รายงานการขายประจำวนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายงานการขายประจำเดอนToolStripMenuItem;
    }
}