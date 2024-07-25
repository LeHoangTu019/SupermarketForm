namespace WindowsFormsApp1.BillFolder
{
    partial class BillForm
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
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
            this.ID,
            this.Name,
            this.Paid,
            this.Detail});
            this.DGBill.Location = new System.Drawing.Point(12, 105);
            this.DGBill.Name = "DGBill";
            this.DGBill.RowHeadersVisible = false;
            this.DGBill.RowHeadersWidth = 51;
            this.DGBill.RowTemplate.Height = 24;
            this.DGBill.Size = new System.Drawing.Size(429, 423);
            this.DGBill.TabIndex = 0;
            this.DGBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGBill_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Paid
            // 
            this.Paid.HeaderText = "Paid";
            this.Paid.MinimumWidth = 6;
            this.Paid.Name = "Paid";
            this.Paid.Width = 125;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG HÓA ĐƠN TÍNH TIỀN";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGBill);
            this.Text = "BillForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.Label label1;
    }
}