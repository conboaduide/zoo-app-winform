namespace ZooForm
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            shopToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            ticketToolStripMenuItem = new ToolStripMenuItem();
            animalToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { shopToolStripMenuItem, orderToolStripMenuItem, userToolStripMenuItem, ticketToolStripMenuItem, animalToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // shopToolStripMenuItem
            // 
            shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            shopToolStripMenuItem.Size = new Size(57, 24);
            shopToolStripMenuItem.Text = "Shop";
            shopToolStripMenuItem.Click += shopToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(52, 24);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // ticketToolStripMenuItem
            // 
            ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            ticketToolStripMenuItem.Size = new Size(62, 24);
            ticketToolStripMenuItem.Text = "Ticket";
            ticketToolStripMenuItem.Click += ticketToolStripMenuItem_Click;
            // 
            // animalToolStripMenuItem
            // 
            animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            animalToolStripMenuItem.Size = new Size(70, 24);
            animalToolStripMenuItem.Text = "Animal";
            animalToolStripMenuItem.Click += animalToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(74, 24);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem shopToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem ticketToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}