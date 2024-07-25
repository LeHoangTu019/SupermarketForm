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

namespace WindowsFormsApp1.ProductFolder
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TextBoxName.Text.ToString()) || String.IsNullOrEmpty(TextBoxQuantity.Text.ToString())
                || string.IsNullOrEmpty(TextBoxPrice.Text.ToString()))
            {
                MessageBox.Show("Chưa đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            Product product = new Product();
            product.Name = TextBoxName.Text;
            product.Price = double.Parse(TextBoxPrice.Text);
            product.Quantity = int.Parse(TextBoxQuantity.Text);
            Program.superMarketManagement.addProduct(product);
            DialogResult diaglog = MessageBox.Show("Đã thêm thành công!!!\nBạn có muốn ghi thêm không?", "Success", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if( diaglog == DialogResult.No )
                this.Close();
            TextBoxName.Text = "";
            TextBoxPrice.Text = "";
            TextBoxQuantity.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }

        private void TextBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
