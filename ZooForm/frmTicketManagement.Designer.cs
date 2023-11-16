namespace ZooForm
{
    partial class frmTicketManagement
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
            dataGridView1 = new DataGridView();
            tbPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateCreated = new DateTimePicker();
            btCreate = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            btSave = new Button();
            cbStatus = new ComboBox();
            tbType = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(970, 334);
            dataGridView1.TabIndex = 0;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(563, 171);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(168, 31);
            tbPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 174);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 232);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 12;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 179);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 13;
            label6.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 229);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 14;
            label7.Text = "Created date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(337, 36);
            label8.Name = "label8";
            label8.Size = new Size(484, 70);
            label8.TabIndex = 15;
            label8.Text = "Ticket Management";
            // 
            // dateCreated
            // 
            dateCreated.Location = new Point(409, 224);
            dateCreated.Name = "dateCreated";
            dateCreated.Size = new Size(322, 31);
            dateCreated.TabIndex = 16;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(814, 129);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(112, 39);
            btCreate.TabIndex = 18;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(814, 177);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(112, 41);
            btDelete.TabIndex = 19;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(814, 224);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(112, 39);
            btUpdate.TabIndex = 20;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(814, 269);
            btSave.Name = "btSave";
            btSave.Size = new Size(112, 41);
            btSave.TabIndex = 21;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(143, 222);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(154, 33);
            cbStatus.TabIndex = 22;
            // 
            // tbType
            // 
            tbType.Location = new Point(132, 171);
            tbType.Name = "tbType";
            tbType.Size = new Size(346, 31);
            tbType.TabIndex = 23;
            // 
            // frmTicketManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 655);
            Controls.Add(tbType);
            Controls.Add(cbStatus);
            Controls.Add(btSave);
            Controls.Add(btUpdate);
            Controls.Add(btDelete);
            Controls.Add(btCreate);
            Controls.Add(dateCreated);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbPrice);
            Controls.Add(dataGridView1);
            Name = "frmTicketManagement";
            Text = "frmTicketManagement";
            Load += frmTicketManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox tbPrice;
        private TextBox tbName;
        private TextBox tbDesc;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateCreated;
        private ComboBox cbType;
        private Button btCreate;
        private Button btDelete;
        private Button btUpdate;
        private Button btSave;
        private ComboBox cbStatus;
        private TextBox textBox1;
        private TextBox tbType;
    }
}