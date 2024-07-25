using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;


namespace WindowsFormsApp1.BillFolder
{
    public partial class BillForm : Form
    {
        
        
        
        public BillForm()
        {
            InitializeComponent();
            loadbill();
        }

        private void loadbill()
        {
            DGBill.Rows.Clear();
            foreach(Bill bill in Program.superMarketManagement.Bills)
            {
                
                Customer customer = SuperMarketManagement.findCustomerByID(bill.CustomerId);
                if (customer != null)
                {
                DGBill.Rows.Add(bill.BillID, customer.Name, bill.CalculatePay(), "Xem chi tiết");
                }
                
            }
        }

        private void DGBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] == senderGrid.Columns[3] &&
                e.RowIndex >= 0) //Xem chi tiết
            {
                DialogResult diaglog = MessageBox.Show("Bạn muốn in hóa đơn?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaglog == DialogResult.Yes)
                {
                    var id = int.Parse(DGBill.Rows[e.RowIndex].Cells[0].Value.ToString());


                    foreach (Bill bill in Program.superMarketManagement.Bills)
                    {
                        if (bill.BillID == id)
                        {
                            DetailForm detailForm = new DetailForm(id, bill.Check);
                            detailForm.ShowDialog();
                            bill.Check = false;
                        }
                    }
                }
                    
                
                
            }    
        }
    }
}
