namespace HotelClientView
{
    partial class ApartmentDirectoryForm
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
            this.vipStatusEdit = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.roomsNumberEdit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.maxCapacityEdit = new System.Windows.Forms.NumericUpDown();
            this.apartmentPriceEdit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apartmentNumberEdit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.hotelEdit = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.apartmentsGrid = new DevExpress.XtraGrid.GridControl();
            this.apartmentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vipStatusEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNumberEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCapacityEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentPriceEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentNumberEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(6, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions on selected record";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vipStatusEdit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.roomsNumberEdit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maxCapacityEdit);
            this.groupBox2.Controls.Add(this.apartmentPriceEdit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.apartmentNumberEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hotelEdit);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 160);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text fields actions";
            // 
            // vipStatusEdit
            // 
            this.vipStatusEdit.Location = new System.Drawing.Point(175, 125);
            this.vipStatusEdit.Name = "vipStatusEdit";
            this.vipStatusEdit.Properties.Caption = "Has VIP status?";
            this.vipStatusEdit.Size = new System.Drawing.Size(149, 19);
            this.vipStatusEdit.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rooms number";
            // 
            // roomsNumberEdit
            // 
            this.roomsNumberEdit.Location = new System.Drawing.Point(10, 125);
            this.roomsNumberEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomsNumberEdit.Name = "roomsNumberEdit";
            this.roomsNumberEdit.Size = new System.Drawing.Size(149, 21);
            this.roomsNumberEdit.TabIndex = 27;
            this.roomsNumberEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Apartment maximum capacity";
            // 
            // maxCapacityEdit
            // 
            this.maxCapacityEdit.Location = new System.Drawing.Point(340, 76);
            this.maxCapacityEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxCapacityEdit.Name = "maxCapacityEdit";
            this.maxCapacityEdit.Size = new System.Drawing.Size(149, 21);
            this.maxCapacityEdit.TabIndex = 25;
            this.maxCapacityEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // apartmentPriceEdit
            // 
            this.apartmentPriceEdit.DecimalPlaces = 2;
            this.apartmentPriceEdit.Location = new System.Drawing.Point(175, 76);
            this.apartmentPriceEdit.Name = "apartmentPriceEdit";
            this.apartmentPriceEdit.Size = new System.Drawing.Size(149, 21);
            this.apartmentPriceEdit.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apartment price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Apartment number";
            // 
            // apartmentNumberEdit
            // 
            this.apartmentNumberEdit.Location = new System.Drawing.Point(10, 76);
            this.apartmentNumberEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.apartmentNumberEdit.Name = "apartmentNumberEdit";
            this.apartmentNumberEdit.Size = new System.Drawing.Size(149, 21);
            this.apartmentNumberEdit.TabIndex = 20;
            this.apartmentNumberEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hotel name";
            // 
            // hotelEdit
            // 
            this.hotelEdit.Enabled = false;
            this.hotelEdit.Location = new System.Drawing.Point(175, 25);
            this.hotelEdit.Name = "hotelEdit";
            this.hotelEdit.Size = new System.Drawing.Size(314, 20);
            this.hotelEdit.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // apartmentsGrid
            // 
            this.apartmentsGrid.Location = new System.Drawing.Point(6, 223);
            this.apartmentsGrid.MainView = this.apartmentsGridView;
            this.apartmentsGrid.Name = "apartmentsGrid";
            this.apartmentsGrid.Size = new System.Drawing.Size(613, 327);
            this.apartmentsGrid.TabIndex = 12;
            this.apartmentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.apartmentsGridView});
            // 
            // apartmentsGridView
            // 
            this.apartmentsGridView.GridControl = this.apartmentsGrid;
            this.apartmentsGridView.Name = "apartmentsGridView";
            // 
            // ApartmentDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 553);
            this.Controls.Add(this.apartmentsGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ApartmentDirectoryForm";
            this.Text = "Apartment directory form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vipStatusEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNumberEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCapacityEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentPriceEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentNumberEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView citiesGridView;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit hotelEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown apartmentPriceEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown apartmentNumberEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxCapacityEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown roomsNumberEdit;
        private DevExpress.XtraEditors.CheckEdit vipStatusEdit;
        private DevExpress.XtraGrid.GridControl apartmentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView apartmentsGridView;
    }
}