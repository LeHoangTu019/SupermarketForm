using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BillFolder;
using WindowsFormsApp1.EmployeeFolder;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
    public partial class MenuForm : Form
    {
        
        
        public MenuForm()
        {
            InitializeComponent();
            if (Program.superMarketManagement.LoginEmployee.Type == Employee.ADMIN)
            {
                MessageBox.Show("Chào mừng quản trị viên!", "Welcome", MessageBoxButtons.OK);

            }
            else if(Program.superMarketManagement.LoginEmployee.Type == Employee.EMPLOYEE 
                && Program.superMarketManagement.LoginEmployee.Username == "Thinh")
            {
                MessageBox.Show("Chào mừng Thịnh ngu!", "Welcome", MessageBoxButtons.OK);
            }
            else if (Program.superMarketManagement.LoginEmployee.Type == Employee.EMPLOYEE
                && Program.superMarketManagement.LoginEmployee.Username == "Tu")
            {
                MessageBox.Show("Chào mừng Tú!", "Welcome", MessageBoxButtons.OK);
            }
            else if (Program.superMarketManagement.LoginEmployee.Type == Employee.EMPLOYEE
                && Program.superMarketManagement.LoginEmployee.Username == "Tien")
            {
                MessageBox.Show("Chào mừng Tiến!", "Welcome", MessageBoxButtons.OK);
            }
            else if (Program.superMarketManagement.LoginEmployee.Type == Employee.EMPLOYEE
                && Program.superMarketManagement.LoginEmployee.Username == "wjbu")
            {
                MessageBox.Show("Chào mừng chúa tể Wjbu!", "Welcome", MessageBoxButtons.OK);
            }

            Employee employee = Program.superMarketManagement.LoginEmployee;
            if(employee.Type == Employee.EMPLOYEE)
            {
                this.btnProduct.Visible = false;
                this.btnEmployee.Visible = false;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillForm billform = new BillForm();
            billform.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult diaglog = MessageBox.Show("Bạn có muốn thoát?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaglog == DialogResult.Yes)
                this.Close();
            
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }
    }
}
