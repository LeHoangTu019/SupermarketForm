using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtAccount.Text;
            string password = txtPassword.Text;
            if(Program.superMarketManagement.login(username, password))
            {
                
                MenuForm menuForm = new MenuForm();
                this.Hide();
                menuForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
