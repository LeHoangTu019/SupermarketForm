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
    public partial class UpdateProductForm : Form
    {
        private Product product;
        public UpdateProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            loadProduct();
        }
        private void loadProduct()
        {
            lbId.Text = product.Id.ToString();
            TextBoxName.Text = product.Name.ToString();
            TextBoxPrice.Text = product.Price.ToString();   
            TextBoxQuantity.Text = product.Quantity.ToString(); 
        }

        private void BTNUpdate_click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxName.Text.ToString()) || String.IsNullOrEmpty(TextBoxQuantity.Text.ToString())
                || string.IsNullOrEmpty(TextBoxPrice.Text.ToString()))
            {
                MessageBox.Show("Chưa đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            product.Name = TextBoxName.Text;
            product.Price = double.Parse(TextBoxPrice.Text);
            product.Quantity = int.Parse(TextBoxQuantity.Text);
            DialogResult diaglog = MessageBox.Show("Bạn có thật chỉnh sửa mặt hàng này?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaglog == DialogResult.Yes)
            {
                Program.superMarketManagement.updateProduct(product);
                MessageBox.Show("Sửa thành công!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
                
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
    }
}
