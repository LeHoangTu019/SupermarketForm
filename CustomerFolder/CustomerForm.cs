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
using WindowsFormsApp1.CustomerFolder;
using WindowsFormsApp1.Properties;


namespace WindowsFormsApp1
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            loadCustomer();
        }
        private void loadCustomer()
        {
            DGCustomer.Rows.Clear();
            foreach (Customer customer in Program.superMarketManagement.Customers)
            {
                string nowtype = customer.updateType(customer.Sum);
                DGCustomer.Rows.Add(customer.Id,customer.Name,customer.Phone,customer.Address,nowtype,customer.Sum,ResourceImage.pencil, ResourceImage.Bin, ResourceImage.cartResize);
            }
            
        }

        private void DGCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            Customer customer = new Customer();
            if (senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[6] &&
                e.RowIndex >= 0) //Sửa khách hàng
            {
                customer.Id = int.Parse(DGCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                customer.Name = DGCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customer.Phone = DGCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customer.Address = DGCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customer.Type = DGCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                customer.Sum = double.Parse(DGCustomer.Rows[e.RowIndex].Cells[5].Value.ToString());
                UpdateCustomerForm form = new UpdateCustomerForm(customer);
                form.ShowDialog();
                loadCustomer();
            }
            else if (senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[7] && e.RowIndex >= 0)
            {
                if(Program.superMarketManagement.LoginEmployee.Type == Employee.ADMIN)
                {
                    customer.Id = int.Parse(DGCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                    customer.Name = DGCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                    customer.Phone = DGCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                    customer.Address = DGCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                    customer.Type = DGCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                    customer.Sum = double.Parse(DGCustomer.Rows[e.RowIndex].Cells[5].Value.ToString());
                    DialogResult diaglog = MessageBox.Show("Bạn có thật sự muốn xóa?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaglog == DialogResult.Yes)
                        Program.superMarketManagement.deleteCustomer(customer);
                        loadCustomer();

                }
                else
                {
                    MessageBox.Show("Bạn không có quyền hạn thực hiện điều này!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else if (senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[8] && e.RowIndex >= 0)
            {
                customer.Id = int.Parse(DGCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                customer.Name = DGCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customer.Phone = DGCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customer.Address = DGCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customer.Type = DGCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                customer.Sum = double.Parse(DGCustomer.Rows[e.RowIndex].Cells[5].Value.ToString());
                CustomerCartForm customerCartForm = new CustomerCartForm(customer);
                customerCartForm.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
            loadCustomer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
