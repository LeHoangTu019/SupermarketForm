namespace WindowsFormsApp1.BillFolder
{
    partial class DetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGBill = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBillId = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbFinalSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTypeSum = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGBill)).BeginInit();
            this.SuspendLayout();
            // 
            // DGBill
            // 
            this.DGBill.AllowUserToAddRows = false;
            this.DGBill.AllowUserToDeleteRows = false;
            this.DGBill.AllowUserToResizeColumns = false;
            this.DGBill.AllowUserToResizeRows = false;
            this.DGBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Name,
            this.Quantity,
            this.tablePrice,
            this.Pay});
            this.DGBill.Location = new System.Drawing.Point(18, 173);
            this.DGBill.Name = "DGBill";
            this.DGBill.RowHeadersVisible = false;
            this.DGBill.RowHeadersWidth = 51;
            this.DGBill.RowTemplate.Height = 24;
            this.DGBill.Size = new System.Drawing.Size(448, 324);
            this.DGBill.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "SL";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 40;
            // 
            // tablePrice
            // 
            this.tablePrice.HeaderText = "Đơn giá";
            this.tablePrice.MinimumWidth = 6;
            this.tablePrice.Name = "tablePrice";
            this.tablePrice.Width = 125;
            // 
            // Pay
            // 
            this.Pay.HeaderText = "Thành tiền";
            this.Pay.MinimumWidth = 6;
            this.Pay.Name = "Pay";
            this.Pay.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(258, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(95, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(31, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã đơn hàng:";
            // 
            // lbBillId
            // 
            this.lbBillId.AutoSize = true;
            this.lbBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBillId.Location = new System.Drawing.Point(147, 78);
            this.lbBillId.Name = "lbBillId";
            this.lbBillId.Size = new System.Drawing.Size(18, 20);
            this.lbBillId.TabIndex = 1;
            this.lbBillId.Text = "1";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCustomerName.Location = new System.Drawing.Point(113, 108);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(106, 20);
            this.lbCustomerName.TabIndex = 1;
            this.lbCustomerName.Text = "Lê Hoàng Tú";
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCustomerPhone.Location = new System.Drawing.Point(86, 139);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(96, 20);
            this.lbCustomerPhone.TabIndex = 1;
            this.lbCustomerPhone.Text = "0919719xxx";
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCustomerAddress.Location = new System.Drawing.Point(330, 139);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(145, 20);
            this.lbCustomerAddress.TabIndex = 1;
            this.lbCustomerAddress.Text = "201 Trần Quý Đôn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(30, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(32, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng tiền";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSum.Location = new System.Drawing.Point(356, 515);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(55, 29);
            this.lbSum.TabIndex = 2;
            this.lbSum.Text = "700";
            this.lbSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFinalSum
            // 
            this.lbFinalSum.AutoSize = true;
            this.lbFinalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFinalSum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFinalSum.Location = new System.Drawing.Point(356, 599);
            this.lbFinalSum.Name = "lbFinalSum";
            this.lbFinalSum.Size = new System.Drawing.Size(55, 29);
            this.lbFinalSum.TabIndex = 2;
            this.lbFinalSum.Text = "700";
            this.lbFinalSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(258, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hội viên:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbType.Location = new System.Drawing.Point(343, 108);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(18, 20);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(32, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giảm giá cho hội viên:";
            // 
            // lbTypeSum
            // 
            this.lbTypeSum.AutoSize = true;
            this.lbTypeSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTypeSum.Location = new System.Drawing.Point(235, 556);
            this.lbTypeSum.Name = "lbTypeSum";
            this.lbTypeSum.Size = new System.Drawing.Size(51, 20);
            this.lbTypeSum.TabIndex = 1;
            this.lbTypeSum.Text = "Vàng";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiscount.Location = new System.Drawing.Point(365, 556);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(39, 20);
            this.lbDiscount.TabIndex = 1;
            this.lbDiscount.Text = "-7%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(258, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nhân viên:";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmployeeName.Location = new System.Drawing.Point(354, 78);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(18, 20);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(35, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 2);
            this.panel1.TabIndex = 3;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(492, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbFinalSum);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCustomerAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCustomerPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbTypeSum);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbBillId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGBill);
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBillId;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbFinalSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTypeSum;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Panel panel1;
    }
}