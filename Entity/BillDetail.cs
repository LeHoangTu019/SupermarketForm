using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class BillDetail
    {
        private int quantity;
        private int productId;
        private int billID;

        public BillDetail(int billID, int productId, int quantity)
        {
            this.quantity = quantity;
            this.productId = productId;
            this.billID = billID;
        }

        public int Quantity { get => quantity; set => quantity = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int BillID { get => billID; set => billID = value; }
    }
}
