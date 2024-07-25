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

namespace WindowsFormsApp1.CustomerFolder
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text.ToString()) || String.IsNullOrEmpty(textBoxPhone.Text.ToString())
                || string.IsNullOrEmpty(textBoxAddress.Text.ToString()))
            {
                MessageBox.Show("Chưa đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer customer = new Customer();
            customer.Name = textBoxName.Text;
            customer.Phone = textBoxPhone.Text;
            customer.Address = textBoxAddress.Text;
            customer.Type = customer.updateType(customer.Sum);
            Program.superMarketManagement.addCustomer(customer);
            DialogResult diaglog = MessageBox.Show("Đã thêm thành công!!!\nBạn có muốn ghi thêm không?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaglog == DialogResult.No)
                this.Close();
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }
    }
}
