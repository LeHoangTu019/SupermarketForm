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

namespace WindowsFormsApp1.EmployeeFolder
{
    public partial class UpdateEmployeeForm : Form
    {
        private Employee employee;
        public UpdateEmployeeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            loadEmployee();
        }

        private void loadEmployee()
        {
            lbId.Text = employee.ID1.ToString();
            textBoxUsername.Text = employee.Username.ToString();
            textBoxPassword.Text = employee.Password.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPassword.Text.ToString()) || String.IsNullOrEmpty(textBoxUsername.Text.ToString()))
            {
                MessageBox.Show("Chưa đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            employee.Username = textBoxUsername.Text;
            if (employee.Username != "Admin")
            {
                MessageBox.Show("Admin là tên mặc định, không thể chỉnh sửa!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            employee.Password = textBoxPassword.Text;
            DialogResult diaglog = MessageBox.Show("Bạn có thật chỉnh sửa nhân viên này?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaglog == DialogResult.Yes)
            {
                Program.superMarketManagement.updateEmployee(employee);
                MessageBox.Show("Sửa thành công!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
                
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
