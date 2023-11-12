namespace ZooForm
{
    partial class frmUserManagement
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
            btnReset = new Button();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSearch = new Button();
            btnExit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            txtCreatedDate = new TextBox();
            txtId = new TextBox();
            txtSearch = new TextBox();
            label1 = new Label();
            dgv = new DataGridView();
            label11 = new Label();
            cboRole = new ComboBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            radioTrue = new RadioButton();
            radioFalse = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(428, 117);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 55;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(546, 220);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 54;
            label10.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(546, 173);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 52;
            label9.Text = "Created Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 34);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 46;
            label3.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 45;
            label2.Text = "Search by username:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(428, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 44;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(860, 421);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 43;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(701, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(860, 386);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(701, 386);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(546, 386);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 39;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.Location = new Point(689, 170);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.ReadOnly = true;
            txtCreatedDate.Size = new Size(265, 27);
            txtCreatedDate.TabIndex = 36;
            // 
            // txtId
            // 
            txtId.Location = new Point(689, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(265, 27);
            txtId.TabIndex = 32;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(179, 77);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(243, 27);
            txtSearch.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(355, 54);
            label1.TabIndex = 30;
            label1.Text = "User Management";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(29, 164);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(493, 286);
            dgv.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(546, 269);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 57;
            label11.Text = "Role";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(689, 266);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(265, 28);
            cboRole.TabIndex = 56;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(689, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(265, 27);
            txtUsername.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 81);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 47;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(546, 127);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 60;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(689, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 59;
            // 
            // radioTrue
            // 
            radioTrue.AutoSize = true;
            radioTrue.Location = new Point(689, 220);
            radioTrue.Name = "radioTrue";
            radioTrue.Size = new Size(58, 24);
            radioTrue.TabIndex = 61;
            radioTrue.TabStop = true;
            radioTrue.Text = "True";
            radioTrue.UseVisualStyleBackColor = true;
            radioTrue.CheckedChanged += radioTrue_CheckedChanged;
            // 
            // radioFalse
            // 
            radioFalse.AutoSize = true;
            radioFalse.Location = new Point(766, 220);
            radioFalse.Name = "radioFalse";
            radioFalse.Size = new Size(62, 24);
            radioFalse.TabIndex = 62;
            radioFalse.TabStop = true;
            radioFalse.Text = "False";
            radioFalse.UseVisualStyleBackColor = true;
            radioFalse.CheckedChanged += radioFalse_CheckedChanged;
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 473);
            Controls.Add(radioFalse);
            Controls.Add(radioTrue);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label11);
            Controls.Add(cboRole);
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
            Controls.Add(txtUsername);
            Controls.Add(txtId);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "frmUserManagement";
            Text = "frmUserManagement";
            Load += frmUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private Label label10;
        private ComboBox cboRole;
        private Label label9;
        private Label label3;
        private Label label2;
        private Button btnSearch;
        private Button btnExit;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private TextBox txtCreatedDate;
        private TextBox txtId;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgv;
        private Label label11;
        private ComboBox comboBox1;
        private TextBox txtUsername;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private RadioButton radioTrue;
        private RadioButton radioFalse;
    }
}