namespace ZooForm
{
    partial class frmOrderManagement
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
            dtgvOrder = new DataGridView();
            label1 = new Label();
            btnCreate = new Button();
            label2 = new Label();
            cbTicket = new ComboBox();
            txtPrice = new TextBox();
            label3 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            textBox1 = new TextBox();
            txtOrderId = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dtgvOrder
            // 
            dtgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrder.Location = new Point(319, 91);
            dtgvOrder.Margin = new Padding(2);
            dtgvOrder.Name = "dtgvOrder";
            dtgvOrder.RowHeadersWidth = 62;
            dtgvOrder.RowTemplate.Height = 33;
            dtgvOrder.Size = new Size(630, 499);
            dtgvOrder.TabIndex = 0;
            dtgvOrder.CellClick += dtgvOrder_CellClick;
            dtgvOrder.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(310, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 41);
            label1.TabIndex = 1;
            label1.Text = "Order Management";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 445);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Ticket";
            // 
            // cbTicket
            // 
            cbTicket.FormattingEnabled = true;
            cbTicket.Location = new Point(95, 170);
            cbTicket.Name = "cbTicket";
            cbTicket.Size = new Size(191, 28);
            cbTicket.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(95, 223);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(191, 27);
            txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 526);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(158, 445);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(158, 526);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 11;
            // 
            // txtOrderId
            // 
            txtOrderId.AutoSize = true;
            txtOrderId.Location = new Point(12, 122);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(24, 20);
            txtOrderId.TabIndex = 12;
            txtOrderId.Text = "ID";
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 601);
            Controls.Add(txtOrderId);
            Controls.Add(textBox1);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(cbTicket);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(dtgvOrder);
            Margin = new Padding(2);
            Name = "frmOrderManagement";
            Text = "frmOrderManagement";
            Load += frmOrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvOrder;
        private Label label1;
        private Button btnCreate;
        private Label label2;
        private ComboBox cbTicket;
        private TextBox txtPrice;
        private Label label3;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private TextBox textBox1;
        private Label txtOrderId;
    }
}