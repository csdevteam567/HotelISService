namespace HotelClientView
{
    partial class MenuDirectoryForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priceEdit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dishNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.restaurantEdit = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dishesGrid = new DevExpress.XtraGrid.GridControl();
            this.dishesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).BeginInit();
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
            this.addButton.Text = "Add typed record";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions on selected record";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceEdit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dishNameEdit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.restaurantEdit);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 149);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text fields actions";
            // 
            // priceEdit
            // 
            this.priceEdit.DecimalPlaces = 2;
            this.priceEdit.Location = new System.Drawing.Point(168, 121);
            this.priceEdit.Name = "priceEdit";
            this.priceEdit.Size = new System.Drawing.Size(168, 21);
            this.priceEdit.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dish price";
            // 
            // dishNameEdit
            // 
            this.dishNameEdit.Location = new System.Drawing.Point(10, 120);
            this.dishNameEdit.Name = "dishNameEdit";
            this.dishNameEdit.Size = new System.Drawing.Size(149, 20);
            this.dishNameEdit.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dish name";
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
            // restaurantEdit
            // 
            this.restaurantEdit.Enabled = false;
            this.restaurantEdit.Location = new System.Drawing.Point(10, 69);
            this.restaurantEdit.Name = "restaurantEdit";
            this.restaurantEdit.Size = new System.Drawing.Size(326, 20);
            this.restaurantEdit.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dishesGrid
            // 
            this.dishesGrid.Location = new System.Drawing.Point(6, 219);
            this.dishesGrid.MainView = this.dishesGridView;
            this.dishesGrid.Name = "dishesGrid";
            this.dishesGrid.Size = new System.Drawing.Size(342, 329);
            this.dishesGrid.TabIndex = 12;
            this.dishesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dishesGridView});
            // 
            // dishesGridView
            // 
            this.dishesGridView.GridControl = this.dishesGrid;
            this.dishesGridView.Name = "dishesGridView";
            // 
            // MenuDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 553);
            this.Controls.Add(this.dishesGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuDirectoryForm";
            this.Text = "Menu directory form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit restaurantEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.TextEdit dishNameEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceEdit;
        private DevExpress.XtraGrid.GridControl dishesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView dishesGridView;
    }
}