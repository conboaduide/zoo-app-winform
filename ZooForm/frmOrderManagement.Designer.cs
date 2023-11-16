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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            txtID = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dtgvOrder
            // 
            dtgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrder.Location = new Point(11, 131);
            dtgvOrder.Margin = new Padding(2);
            dtgvOrder.Name = "dtgvOrder";
            dtgvOrder.RowHeadersWidth = 62;
            dtgvOrder.RowTemplate.Height = 33;
            dtgvOrder.Size = new Size(938, 459);
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
            // button1
            // 
            button1.Location = new Point(615, 75);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(809, 75);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 4;
            label2.Text = "ID";
            label2.UseMnemonic = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(65, 74);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 5;
            txtID.TextChanged += textBox1_TextChanged_1;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(377, 72);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 601);
            Controls.Add(btnShow);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txtID;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnShow;
    }
}