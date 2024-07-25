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

namespace WindowsFormsApp1.BillFolder
{
    public partial class DetailForm : Form
    {
        private int stt = 0;
        private Customer customer;
        private Bill bill;
        private List<Product> products = new List<Product>();
        private double sum;
        private bool checksum;
        private double trueSum = 0;

        public DetailForm(int id, bool checksum)
        {

            InitializeComponent();
            this.checksum = checksum;
            bill = SuperMarketManagement.findBillByID(id);
            customer = SuperMarketManagement.findCustomerByID(bill.CustomerId);
            foreach(BillDetail billDetail in bill.BillDetails)
            {
                Product product = SuperMarketManagement.findProductById(billDetail.ProductId);
                products.Add(product);
            }
            loadBill();
        }
        
        private void loadBill()
        {
            lbEmployeeName.Text = Program.superMarketManagement.LoginEmployee.Username;
            lbType.Text = customer.Type;
            lbTypeSum.Text = customer.Type;
            lbCustomerName.Text = customer.Name;
            lbCustomerPhone.Text = customer.Phone;
            lbCustomerAddress.Text = customer.Address;
            lbBillId.Text = bill.BillID.ToString();

            DGBill.Rows.Clear();
            foreach (Product product in products)
            {

                BillDetail billDetail = bill.BillDetails[stt];
                sum = sum + billDetail.Quantity * product.Price;

                DGBill.Rows.Add(++stt, product.Name, billDetail.Quantity, product.Price, billDetail.Quantity * product.Price);

            }

            if (checksum)
            {
                customer.Sum += sum;
                bill.PayType = customer.Type;

            }

            if ( bill.PayType == Customer.NORMAL)
            {
                lbDiscount.Text = "0%";
            }
            if (bill.PayType == Customer.BRONZE)
            {
                lbDiscount.Text = "2%";
            }
            if (bill.PayType == Customer.SILVER)
            {
                lbDiscount.Text = "4%";
            }
            if (bill.PayType == Customer.GOLD)
            {
                lbDiscount.Text = "7%";
            }

            
            
            

            if (bill.PayType == Customer.NORMAL)
            {

                trueSum = sum;
            }
            if (bill.PayType == Customer.BRONZE)
            {
                //Giảm giá 2%
                trueSum = sum * 0.98;
            }
            if (bill.PayType == Customer.SILVER)
            {
                //Giảm giá 4%
                trueSum = sum * 0.96;
            }
            if (bill.PayType == Customer.GOLD)
            {
                //Giảm giá 7%
                trueSum = sum * 0.93;
            }

            customer.Type = customer.updateType(customer.Sum);
            lbSum.Text = sum.ToString();
            //Tam thời
           
            lbFinalSum.Text = trueSum.ToString();
        }
    }
}
