namespace ZooForm
{
    partial class frmAnimalManagement
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
            radioFalse = new RadioButton();
            radioTrue = new RadioButton();
            label5 = new Label();
            txtSpecies = new TextBox();
            btnReset = new Button();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSearch = new Button();
            btnExit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            txtCreatedDate = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            txtSearch = new TextBox();
            label1 = new Label();
            dgv = new DataGridView();
            label6 = new Label();
            txtLocation = new TextBox();
            label7 = new Label();
            txtClass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // radioFalse
            // 
            radioFalse.AutoSize = true;
            radioFalse.Location = new Point(815, 364);
            radioFalse.Name = "radioFalse";
            radioFalse.Size = new Size(62, 24);
            radioFalse.TabIndex = 86;
            radioFalse.TabStop = true;
            radioFalse.Text = "False";
            radioFalse.UseVisualStyleBackColor = true;
            // 
            // radioTrue
            // 
            radioTrue.AutoSize = true;
            radioTrue.Location = new Point(738, 364);
            radioTrue.Name = "radioTrue";
            radioTrue.Size = new Size(58, 24);
            radioTrue.TabIndex = 85;
            radioTrue.TabStop = true;
            radioTrue.Text = "True";
            radioTrue.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(595, 170);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 84;
            label5.Text = "Species";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(738, 167);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(265, 27);
            txtSpecies.TabIndex = 83;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(477, 162);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 80;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(595, 364);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 79;
            label10.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(595, 317);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 78;
            label9.Text = "Created Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(595, 124);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 77;
            label4.Text = "Animal Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(595, 77);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 76;
            label3.Text = "Animal ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 126);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 75;
            label2.Text = "Search by animal name:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(477, 120);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 74;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(909, 466);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 73;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(750, 466);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 72;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(909, 431);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 71;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(750, 431);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 70;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(595, 431);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 69;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.Location = new Point(738, 314);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.ReadOnly = true;
            txtCreatedDate.Size = new Size(265, 27);
            txtCreatedDate.TabIndex = 68;
            // 
            // txtName
            // 
            txtName.Location = new Point(738, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 27);
            txtName.TabIndex = 67;
            // 
            // txtId
            // 
            txtId.Location = new Point(738, 74);
            txtId.Name = "txtId";
            txtId.Size = new Size(265, 27);
            txtId.TabIndex = 66;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(228, 122);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(243, 27);
            txtSearch.TabIndex = 65;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 52);
            label1.Name = "label1";
            label1.Size = new Size(400, 54);
            label1.TabIndex = 64;
            label1.Text = "Animal Management";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(56, 209);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(515, 286);
            dgv.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(595, 219);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 88;
            label6.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(738, 216);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(265, 27);
            txtLocation.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(595, 272);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 90;
            label7.Text = "Class";
            // 
            // txtClass
            // 
            txtClass.Location = new Point(738, 269);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(265, 27);
            txtClass.TabIndex = 89;
            // 
            // frmAnimalManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 509);
            Controls.Add(label7);
            Controls.Add(txtClass);
            Controls.Add(label6);
            Controls.Add(txtLocation);
            Controls.Add(radioFalse);
            Controls.Add(radioTrue);
            Controls.Add(label5);
            Controls.Add(txtSpecies);
            Controls.Add(btnReset);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtCreatedDate);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "frmAnimalManagement";
            Text = "frmAnimalManagement";
            Load += frmAnimalManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioFalse;
        private RadioButton radioTrue;
        private Label label5;
        private TextBox txtSpecies;
        private Button btnReset;
        private Label label10;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSearch;
        private Button btnExit;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private TextBox txtCreatedDate;
        private TextBox txtName;
        private TextBox txtId;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgv;
        private Label label6;
        private TextBox txtLocation;
        private Label label7;
        private TextBox txtClass;
    }
}