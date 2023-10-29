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
    public partial class Login : Form
    {
        //private string hashedPassword;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_pass.Text;
            string accessLevel = cbx_level.SelectedItem.ToString(); 
            string host = "localhost";
            int port = 1521;
            string sid = "orcl";

            string connectionString = "";

            if (accessLevel == "Default")
            {
                connectionString = $"User Id={username};Password={password};Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={port}))(CONNECT_DATA=(SID={sid})))";
            }
            else if (accessLevel == "SYSDBA")
            {
                connectionString = $"User Id={username};Password={password};DBA Privilege=SYSDBA;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={port}))(CONNECT_DATA=(SID={sid})))";
            }

            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                connection.Open();
                //OracleCommand cmd = new OracleCommand("BEGIN :result := HashPassword(:password); END;", connection);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("result", OracleDbType.Varchar2, 32).Direction = ParameterDirection.Output;
                //cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

                //cmd.ExecuteNonQuery();
                //hashedPassword = cmd.Parameters["result"].Value.ToString();
                TrangChu homeForm = new TrangChu(accessLevel);
                homeForm.Show();
                this.Hide();
                MessageBox.Show("Kết nối thành công!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}");
            }
        }
    }
}
