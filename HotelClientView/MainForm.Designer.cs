namespace HotelClientView
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkHotelStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoriesToolStripMenuItem,
            this.orderingToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1393, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // directoriesToolStripMenuItem
            // 
            this.directoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryDirectoryToolStripMenuItem,
            this.cityDirectoryToolStripMenuItem,
            this.hotelDirectoryToolStripMenuItem,
            this.userDirectoryToolStripMenuItem});
            this.directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            this.directoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.directoriesToolStripMenuItem.Text = "Directories";
            // 
            // countryDirectoryToolStripMenuItem
            // 
            this.countryDirectoryToolStripMenuItem.Name = "countryDirectoryToolStripMenuItem";
            this.countryDirectoryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.countryDirectoryToolStripMenuItem.Text = "Country directory";
            // 
            // cityDirectoryToolStripMenuItem
            // 
            this.cityDirectoryToolStripMenuItem.Name = "cityDirectoryToolStripMenuItem";
            this.cityDirectoryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cityDirectoryToolStripMenuItem.Text = "City directory";
            // 
            // hotelDirectoryToolStripMenuItem
            // 
            this.hotelDirectoryToolStripMenuItem.Name = "hotelDirectoryToolStripMenuItem";
            this.hotelDirectoryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.hotelDirectoryToolStripMenuItem.Text = "Hotel directory";
            // 
            // userDirectoryToolStripMenuItem
            // 
            this.userDirectoryToolStripMenuItem.Name = "userDirectoryToolStripMenuItem";
            this.userDirectoryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.userDirectoryToolStripMenuItem.Text = "User directory";
            // 
            // orderingToolStripMenuItem
            // 
            this.orderingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.guestDirectoryToolStripMenuItem,
            this.checkHotelStatusToolStripMenuItem});
            this.orderingToolStripMenuItem.Name = "orderingToolStripMenuItem";
            this.orderingToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.orderingToolStripMenuItem.Text = "Ordering";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.createOrderToolStripMenuItem.Text = "Orders";
            // 
            // guestDirectoryToolStripMenuItem
            // 
            this.guestDirectoryToolStripMenuItem.Name = "guestDirectoryToolStripMenuItem";
            this.guestDirectoryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.guestDirectoryToolStripMenuItem.Text = "Guest directory";
            // 
            // checkHotelStatusToolStripMenuItem
            // 
            this.checkHotelStatusToolStripMenuItem.Name = "checkHotelStatusToolStripMenuItem";
            this.checkHotelStatusToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkHotelStatusToolStripMenuItem.Text = "Check hotel status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 607);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Main window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkHotelStatusToolStripMenuItem;

    }
}

