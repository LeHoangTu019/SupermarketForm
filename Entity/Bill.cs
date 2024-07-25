using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class Bill
    {
        private List<BillDetail> billDetails;
        private int billID;
        private int customerId;
        private bool check;
        private string payType;
        

        public Bill() { }

        public Bill(List<BillDetail> billDetails, int billID, int customerId)
        {
            this.billDetails = billDetails;
            this.billID = billID;
            this.customerId = customerId;
            this.check = true;
            
        }

        public List<BillDetail> BillDetails { get => billDetails; set => billDetails = value; }
        public int BillID { get => billID; set => billID = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public bool Check { get => check; set => check = value; }
        public string PayType { get => payType; set => payType = value; }

        public double CalculatePay()
        {
            double pay = 0;
            foreach (BillDetail billDetail in billDetails)
            {
                Product product = SuperMarketManagement.findProductById(billDetail.ProductId);
                pay = pay + product.Price * billDetail.Quantity;
            }
            return pay;
        }
    }
}
