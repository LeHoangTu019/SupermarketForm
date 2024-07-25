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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            loadEmployee();
        }
        

        private void loadEmployee()
        {
            DGEmployee.Rows.Clear();
            foreach(Employee employee in Program.superMarketManagement.Employees)
            {
                DGEmployee.Rows.Add(employee.ID1, employee.Username, employee.Password, employee.Type, ResourceImage.pencil, ResourceImage.Bin);
            }
        }

        private void DGEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            Employee employee = new Employee();
            if(senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[4] &&
                e.RowIndex >= 0) //Sửa
            {
                employee.ID1 = int.Parse(DGEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());
                employee.Username = DGEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                employee.Password = DGEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                employee.Type = DGEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                UpdateEmployeeForm updateEmployeeForm = new UpdateEmployeeForm(employee);
                updateEmployeeForm.ShowDialog();
                loadEmployee();
            }
            else if(senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[5] && e.RowIndex >= 0)
            {
                
                employee.ID1 = int.Parse(DGEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());
                employee.Username = DGEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                employee.Password = DGEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                employee.Type = DGEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (employee.Type == Employee.ADMIN)
                {
                    MessageBox.Show("Bạn không thể xóa quản trị viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult diaglog = MessageBox.Show("Bạn có thật sự muốn xóa?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaglog == DialogResult.Yes)
                    Program.superMarketManagement.deleteEmployee(employee);
                loadEmployee();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeFormcs employeeForm = new AddEmployeeFormcs();
            employeeForm.ShowDialog();
            loadEmployee();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
