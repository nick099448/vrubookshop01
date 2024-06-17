
namespace VruBookShop_worapot.Admin
{
    partial class frmAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShowEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnShowPosition = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnShowEmployee,
            this.btnShowPosition,
            this.toolStripDropDownButton3,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(949, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnShowEmployee.Image")));
            this.btnShowEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnShowEmployee.Size = new System.Drawing.Size(184, 70);
            this.btnShowEmployee.Text = "ข้อมูลจัดการข้อมูลผู้ใช้งาน";
            this.btnShowEmployee.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnShowEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // btnShowPosition
            // 
            this.btnShowPosition.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPosition.Image")));
            this.btnShowPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowPosition.Name = "btnShowPosition";
            this.btnShowPosition.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnShowPosition.Size = new System.Drawing.Size(143, 70);
            this.btnShowPosition.Text = "จัดการข้อมูลตำแน่ง";
            this.btnShowPosition.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnShowPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowPosition.Click += new System.EventHandler(this.btnShowPosition_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.AutoSize = false;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(80, 70);
            this.toolStripDropDownButton3.Text = "รายงาน";
            this.toolStripDropDownButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItem1.Text = "รายงานผู้ใช้งาน";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItem2.Text = "รายงานตำแหน่งผู้ใช้งาน";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายการทำงานของผู้ดูแลระบบ";
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnShowEmployee;
        private System.Windows.Forms.ToolStripButton btnShowPosition;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}