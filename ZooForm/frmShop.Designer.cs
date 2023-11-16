namespace ZooForm
{
    partial class frmShop
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
            dgvShop = new DataGridView();
            Date = new Label();
            txtDatetime = new DateTimePicker();
            label2 = new Label();
            txtCustomer = new TextBox();
            item = new Label();
            txtItem = new TextBox();
            dgvOrder = new DataGridView();
            label3 = new Label();
            addBtn = new Button();
            confirmBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvShop
            // 
            dgvShop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShop.Location = new Point(47, 253);
            dgvShop.Name = "dgvShop";
            dgvShop.RowHeadersWidth = 51;
            dgvShop.RowTemplate.Height = 29;
            dgvShop.Size = new Size(709, 251);
            dgvShop.TabIndex = 0;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(47, 46);
            Date.Name = "Date";
            Date.Size = new Size(41, 20);
            Date.TabIndex = 3;
            Date.Text = "Date";
            // 
            // txtDatetime
            // 
            txtDatetime.Enabled = false;
            txtDatetime.Location = new Point(105, 41);
            txtDatetime.Name = "txtDatetime";
            txtDatetime.Size = new Size(250, 27);
            txtDatetime.TabIndex = 4;
            txtDatetime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 90);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Customer";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(125, 87);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(230, 27);
            txtCustomer.TabIndex = 6;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // item
            // 
            item.AutoSize = true;
            item.Location = new Point(47, 141);
            item.Name = "item";
            item.Size = new Size(48, 20);
            item.TabIndex = 5;
            item.Text = "Ticket";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(105, 138);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(250, 27);
            txtItem.TabIndex = 6;
            txtItem.TextChanged += txtCustomer_TextChanged;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(399, 41);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(357, 124);
            dgvOrder.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 9);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 8;
            label3.Text = "Cart";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(261, 198);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(662, 198);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(94, 29);
            confirmBtn.TabIndex = 10;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // frmShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 532);
            Controls.Add(confirmBtn);
            Controls.Add(addBtn);
            Controls.Add(label3);
            Controls.Add(dgvOrder);
            Controls.Add(txtItem);
            Controls.Add(txtCustomer);
            Controls.Add(item);
            Controls.Add(label2);
            Controls.Add(txtDatetime);
            Controls.Add(Date);
            Controls.Add(dgvShop);
            Name = "frmShop";
            Text = "frmShop";
            Load += frmShop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShop;
        private Label Date;
        private DateTimePicker txtDatetime;
        private Label label2;
        private TextBox txtCustomer;
        private Label item;
        private TextBox txtItem;
        private DataGridView dgvOrder;
        private Label label3;
        private Button addBtn;
        private Button confirmBtn;
    }
}