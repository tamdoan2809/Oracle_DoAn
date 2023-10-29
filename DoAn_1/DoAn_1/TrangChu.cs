using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DoAn_1
{
    public partial class TrangChu : Form
    {
        public string accessLevel;
        public TrangChu(string accessLevel)
        {
            InitializeComponent();
            CenterToScreen();
            this.accessLevel = accessLevel;

            if (accessLevel == "Default")
            {
                dky_mnstrip.Enabled= false;
            }
            else if (accessLevel == "SYSDBA")
            {
                dky_mnstrip.Enabled = true;
            }
        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy dky = new DangKy();
            dky.Show();
        }

        private void dxuat_mns_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

                Login loginForm = new Login();
                loginForm.Show();
            }
        }
    }
}
