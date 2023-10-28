namespace DoAn_1
{
    partial class Login
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.chk_pass = new System.Windows.Forms.CheckBox();
            this.cbx_level = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(139, 106);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(327, 27);
            this.txt_user.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(224, 271);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 47);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chk_pass
            // 
            this.chk_pass.AutoSize = true;
            this.chk_pass.Location = new System.Drawing.Point(139, 226);
            this.chk_pass.Name = "chk_pass";
            this.chk_pass.Size = new System.Drawing.Size(148, 24);
            this.chk_pass.TabIndex = 3;
            this.chk_pass.Text = "Hiển thị mật khẩu";
            this.chk_pass.UseVisualStyleBackColor = true;
            // 
            // cbx_level
            // 
            this.cbx_level.FormattingEnabled = true;
            this.cbx_level.Items.AddRange(new object[] {
            "Default",
            "SYSDBA"});
            this.cbx_level.Location = new System.Drawing.Point(486, 106);
            this.cbx_level.Name = "cbx_level";
            this.cbx_level.Size = new System.Drawing.Size(113, 28);
            this.cbx_level.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(139, 161);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(327, 27);
            this.txt_pass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(224, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng Nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.cbx_level);
            this.Controls.Add(this.chk_pass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_user);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_user;
        private Label label1;
        private Button btn_login;
        private CheckBox chk_pass;
        private ComboBox cbx_level;
        private Label label2;
        private TextBox txt_pass;
        private Label label3;
    }
}