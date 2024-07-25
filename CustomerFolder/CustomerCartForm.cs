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
    public partial class CustomerCartForm : Form
    {
        private Customer customer;
        private List<BillDetail> billDetailList = new List<BillDetail>();

        //Dưới đây phục vụ mục đích cho vui
        private int checkClick = 0;
        private int more = 0;

        public CustomerCartForm(Customer customer)
        {
            InitializeComponent();
            lbType.Text = customer.Type;
            lbCustomerId.Text = customer.Id.ToString();
            lbCustomerName.Text = customer.Name.ToString();
            lbCustomerPhone.Text = customer.Phone.ToString();
            this.customer = customer;
            foreach (Product product in Program.superMarketManagement.Products)
            {
                BillDetail billDetail = new BillDetail(0, product.Id, 0);
                DGCart.Rows.Add(product.Id, product.Name, product.Price, billDetail.Quantity);
                billDetailList.Add(billDetail);
            }
       
        }

        private void loadCart()
        {
            DGCart.Rows.Clear();
            foreach(BillDetail billDetail in billDetailList)
            {
                Product product = findProductById(billDetail.ProductId);
                DGCart.Rows.Add(billDetail.ProductId, product.Name, product.Price, billDetail.Quantity);

            }


        }

        private void DGCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            int id = int.Parse(DGCart.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[4] &&
                e.RowIndex >= 0) //Thêm hàng hóa
            {

                AddProduct(id);
                loadCart();
            }
            else if (senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[5] &&
                e.RowIndex >= 0)
            {
                SubtractProduct(id);
                loadCart();
                checkClick++;
            }
        }
        private Product findProductById(int id)
        {
            foreach(Product product in Program.superMarketManagement.Products)
            {
                if(product.Id == id) return product;
            }
            return null;
        }
        private void AddProduct(int id)
        {
            // Kiểm tra trong nguyên danh sách billdetail có tồn tại bất kỳ đối tượng nào chưa
            foreach(BillDetail billDetail1 in billDetailList)
            {
                //Nếu có thì sẽ tiến hành cộng
                if(billDetail1.ProductId == id)
                {
                    foreach (Product product in Program.superMarketManagement.Products)
                    {
                        // Check trùng id vật phẩm và kiểm tra số lượng mua có lớn hơn số lượng tồn kho
                        if (product.Id == id && billDetail1.Quantity +1 <= product.Quantity)
                        {
                            billDetail1.Quantity++;
                            return;

                        }
                    }
                }
            }
            //
            MessageBox.Show("Trong kho đã hết hàng!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SubtractProduct(int id)
        {
            foreach(BillDetail billDetail1 in billDetailList)
            {
                if(billDetail1.ProductId == id)
                {
                    foreach(Product product in Program.superMarketManagement.Products)
                    {
                        if(product.Id == id && billDetail1.Quantity -1 >= 0)
                        {
                            billDetail1.Quantity--;
                            return;
                        }
                    }
                }
            }

            if(more == 3)
            {
                MessageBox.Show("Có bị mù chữ không???\nGiỏ hàng trống trơn mà mày trừ làm gì??? Nhập hàng cho kho à?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                more = 0;
                return ;

            }

            if (checkClick == 3)
            {
                MessageBox.Show("Xin bạn vui lòng đừng tiếp tục spam", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                more++;
                checkClick = 0;
                return;
            }

                MessageBox.Show("Bạn chưa thêm gì vào giỏ hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            bool check = false;
            List <BillDetail> billDetails = new List <BillDetail>();
            foreach(BillDetail billdetail in billDetailList)
            {
                if(billdetail.Quantity != 0)
                {
                    billDetails.Add(billdetail);
                    Product product = findProductById(billdetail.ProductId);
                    product.Quantity -= billdetail.Quantity;
                    check = true;
                }

            }
            if (check)
            {
                Bill bill = new Bill(billDetails, 0, customer.Id);
                Program.superMarketManagement.addBill(bill);
                MessageBox.Show("Bạn đã thanh toán thành công!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm gì vào giỏ hàng", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
