namespace HotelClientView
{
    partial class RestaurantDirectoryForm
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
            this.components = new System.ComponentModel.Container();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addDishes = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restaurantNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hotelEdit = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurantGrid = new DevExpress.XtraGrid.GridControl();
            this.restaurantGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(153, 24);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete selected record";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 22);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add restaurant";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addDishes);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions on selected record";
            // 
            // addDishes
            // 
            this.addDishes.Location = new System.Drawing.Point(168, 20);
            this.addDishes.Name = "addDishes";
            this.addDishes.Size = new System.Drawing.Size(168, 23);
            this.addDishes.TabIndex = 3;
            this.addDishes.Text = "Edit menu button";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.restaurantNameEdit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hotelEdit);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 149);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text fields actions";
            // 
            // restaurantNameEdit
            // 
            this.restaurantNameEdit.Location = new System.Drawing.Point(10, 120);
            this.restaurantNameEdit.Name = "restaurantNameEdit";
            this.restaurantNameEdit.Size = new System.Drawing.Size(326, 20);
            this.restaurantNameEdit.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Restaurant name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hotel name";
            // 
            // hotelEdit
            // 
            this.hotelEdit.Enabled = false;
            this.hotelEdit.Location = new System.Drawing.Point(10, 69);
            this.hotelEdit.Name = "hotelEdit";
            this.hotelEdit.Size = new System.Drawing.Size(326, 20);
            this.hotelEdit.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // restaurantGrid
            // 
            this.restaurantGrid.Location = new System.Drawing.Point(6, 212);
            this.restaurantGrid.MainView = this.restaurantGridView;
            this.restaurantGrid.Name = "restaurantGrid";
            this.restaurantGrid.Size = new System.Drawing.Size(342, 341);
            this.restaurantGrid.TabIndex = 12;
            this.restaurantGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.restaurantGridView});
            // 
            // restaurantGridView
            // 
            this.restaurantGridView.GridControl = this.restaurantGrid;
            this.restaurantGridView.Name = "restaurantGridView";
            // 
            // RestaurantDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 553);
            this.Controls.Add(this.restaurantGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RestaurantDirectoryForm";
            this.Text = "Restaurant directory form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView citiesGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit hotelEdit;
        private DevExpress.XtraEditors.SimpleButton addDishes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.TextEdit restaurantNameEdit;
        private DevExpress.XtraGrid.GridControl restaurantGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView restaurantGridView;
    }
}