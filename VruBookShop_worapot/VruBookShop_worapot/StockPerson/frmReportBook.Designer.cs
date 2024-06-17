
namespace VruBookShop_worapot.StockPerson
{
    partial class frmReportBook
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
            this.crvBook = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvBook
            // 
            this.crvBook.ActiveViewIndex = -1;
            this.crvBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBook.Location = new System.Drawing.Point(0, 0);
            this.crvBook.Name = "crvBook";
            this.crvBook.Size = new System.Drawing.Size(1137, 510);
            this.crvBook.TabIndex = 0;
            this.crvBook.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 510);
            this.Controls.Add(this.crvBook);
            this.Name = "frmReportBook";
            this.Text = "รายงานข้อมูลหนังสือ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptReportBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBook;
    }
}