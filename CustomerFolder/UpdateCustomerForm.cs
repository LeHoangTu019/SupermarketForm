using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1.CustomerFolder
{
    public partial class UpdateCustomerForm : Form
    {
        private Customer customer;
        public UpdateCustomerForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            loadCustomer();
        }

        private void loadCustomer()
        {
            lbType.Text = customer.Type;
            lbId.Text = customer.Id.ToString();
            textBoxName.Text = customer.Name.ToString();
            textBoxPhone.Text = customer.Phone.ToString();
            textBoxAddress.Text = customer.Address.ToString();
            txtBoxSum.Text = customer.Sum.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text.ToString()) || String.IsNullOrEmpty(textBoxPhone.Text.ToString())
                || string.IsNullOrEmpty(textBoxAddress.Text.ToString()))
            {
                MessageBox.Show("Chưa đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            customer.Name = textBoxName.Text;
            customer.Phone = textBoxPhone.Text;
            customer.Address = textBoxAddress.Text;
            customer.Sum = double.Parse(txtBoxSum.Text);
            customer.Type = customer.updateType(customer.Sum);
            DialogResult diaglog = MessageBox.Show("Bạn có thật chỉnh sửa khách hàng này?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaglog == DialogResult.Yes)
            {
                Program.superMarketManagement.updateCustomer(customer);
                MessageBox.Show("Sửa thành công!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
                
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
