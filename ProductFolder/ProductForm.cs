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
using WindowsFormsApp1.ProductFolder;

namespace WindowsFormsApp1
{
    public partial class ProductForm : Form
    {
        
        public ProductForm()
        {
            InitializeComponent();
            loadProduct();
        }

        private void loadProduct()
        {
            DGProduct.Rows.Clear();
            foreach (Product product in Program.superMarketManagement.Products)
            {
                DGProduct.Rows.Add(product.Id, product.Name, product.Quantity, product.Price, ResourceImage.pencil, ResourceImage.Bin);
            }
        }

        private void DGProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            Product product = new Product();
            if (senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[4] &&
                e.RowIndex >= 0) //Sửa hàng hóa
            {
                product.Id = int.Parse(DGProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                product.Name = DGProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.Quantity = int.Parse(DGProduct.Rows[e.RowIndex].Cells[2].Value.ToString());
                product.Price = double.Parse(DGProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
                UpdateProductForm form = new UpdateProductForm(product);
                form.ShowDialog();
                loadProduct();
            }
            else if (senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[5] && e.RowIndex >= 0)
            { // Xóa hàng hóa
                product.Id = int.Parse(DGProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                product.Name = DGProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.Quantity = int.Parse(DGProduct.Rows[e.RowIndex].Cells[2].Value.ToString());
                product.Price = double.Parse(DGProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
                DialogResult diaglog = MessageBox.Show("Bạn có thật sự muốn xóa?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaglog == DialogResult.Yes)
                    Program.superMarketManagement.deleteProduct(product);
                loadProduct();
            }


         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductForm formAddP = new AddProductForm();
            formAddP.ShowDialog();
            loadProduct();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
