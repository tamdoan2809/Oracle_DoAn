namespace DoAn_1
{
    partial class TrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_ql = new System.Windows.Forms.ToolStripMenuItem();
            this.dxuat_mns = new System.Windows.Forms.ToolStripMenuItem();
            this.dky_mnstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.upduser_mns = new System.Windows.Forms.ToolStripMenuItem();
            this.infouser_mns = new System.Windows.Forms.ToolStripMenuItem();
            this.roleuser_mns = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_ql,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_ql
            // 
            this.mn_ql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dxuat_mns,
            this.dky_mnstrip,
            this.upduser_mns,
            this.infouser_mns,
            this.roleuser_mns});
            this.mn_ql.Name = "mn_ql";
            this.mn_ql.Size = new System.Drawing.Size(161, 24);
            this.mn_ql.Text = "Quản Lý Người Dùng";
            // 
            // dxuat_mns
            // 
            this.dxuat_mns.Name = "dxuat_mns";
            this.dxuat_mns.Size = new System.Drawing.Size(244, 26);
            this.dxuat_mns.Text = "Đăng Xuất";
            this.dxuat_mns.Click += new System.EventHandler(this.dxuat_mns_Click);
            // 
            // dky_mnstrip
            // 
            this.dky_mnstrip.Name = "dky_mnstrip";
            this.dky_mnstrip.Size = new System.Drawing.Size(244, 26);
            this.dky_mnstrip.Text = "Đăng Ký";
            this.dky_mnstrip.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
            // 
            // upduser_mns
            // 
            this.upduser_mns.Name = "upduser_mns";
            this.upduser_mns.Size = new System.Drawing.Size(244, 26);
            this.upduser_mns.Text = "Cập Nhật Tài Khoản";
            // 
            // infouser_mns
            // 
            this.infouser_mns.Name = "infouser_mns";
            this.infouser_mns.Size = new System.Drawing.Size(244, 26);
            this.infouser_mns.Text = "Thông Tin Người Dùng";
            this.infouser_mns.Click += new System.EventHandler(this.thôngTinNgườiDùngToolStripMenuItem_Click);
            // 
            // roleuser_mns
            // 
            this.roleuser_mns.Name = "roleuser_mns";
            this.roleuser_mns.Size = new System.Drawing.Size(244, 26);
            this.roleuser_mns.Text = "Phân Quyền";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(196, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Shop Quần Áo";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mn_ql;
        private ToolStripMenuItem dxuat_mns;
        private ToolStripMenuItem dky_mnstrip;
        private ToolStripMenuItem upduser_mns;
        private ToolStripMenuItem infouser_mns;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem roleuser_mns;
    }
}