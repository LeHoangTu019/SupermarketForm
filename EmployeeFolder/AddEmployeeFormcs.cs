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
    public partial class AddEmployeeFormcs : Form
    {
        public AddEmployeeFormcs()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text.ToString()) || String.IsNullOrEmpty(textBoxPass.Text.ToString()))
            {
                MessageBox.Show("Chưa đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee employee = new Employee();
            foreach(Employee item in Program.superMarketManagement.Employees)
            {
                if(item.Username == textBoxUsername.Text)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại\nXin vui lòng nhập lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                
            }
            employee.Username = textBoxUsername.Text;
            employee.Password = textBoxPass.Text;
            employee.Type = Employee.EMPLOYEE;
            Program.superMarketManagement.addEmployee(employee);
            DialogResult diaglog = MessageBox.Show("Đã thêm thành công!!!\nBạn có muốn ghi thêm không?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaglog == DialogResult.No)
                this.Close();
            textBoxUsername.Text = "";
            textBoxPass.Text = "";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
