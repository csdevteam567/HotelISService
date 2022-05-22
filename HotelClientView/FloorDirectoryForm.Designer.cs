namespace HotelClientView
{
    partial class FloorDirectoryForm
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
            this.addApartment = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxApartmentsEdit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.floorNumberEdit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.hotelEdit = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.floorsGrid = new DevExpress.XtraGrid.GridControl();
            this.floorsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxApartmentsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumberEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsGridView)).BeginInit();
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
            this.groupBox1.Controls.Add(this.addApartment);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions on selected record";
            // 
            // addApartment
            // 
            this.addApartment.Location = new System.Drawing.Point(168, 20);
            this.addApartment.Name = "addApartment";
            this.addApartment.Size = new System.Drawing.Size(168, 23);
            this.addApartment.TabIndex = 3;
            this.addApartment.Text = "Add apartments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxApartmentsEdit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.floorNumberEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hotelEdit);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 164);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text fields actions";
            // 
            // maxApartmentsEdit
            // 
            this.maxApartmentsEdit.Location = new System.Drawing.Point(10, 124);
            this.maxApartmentsEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxApartmentsEdit.Name = "maxApartmentsEdit";
            this.maxApartmentsEdit.Size = new System.Drawing.Size(154, 21);
            this.maxApartmentsEdit.TabIndex = 19;
            this.maxApartmentsEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Floor maximum apartments";
            // 
            // floorNumberEdit
            // 
            this.floorNumberEdit.Location = new System.Drawing.Point(168, 124);
            this.floorNumberEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.floorNumberEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floorNumberEdit.Name = "floorNumberEdit";
            this.floorNumberEdit.Size = new System.Drawing.Size(168, 21);
            this.floorNumberEdit.TabIndex = 17;
            this.floorNumberEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Floor number";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // floorsGrid
            // 
            this.floorsGrid.Location = new System.Drawing.Point(6, 234);
            this.floorsGrid.MainView = this.floorsGridView;
            this.floorsGrid.Name = "floorsGrid";
            this.floorsGrid.Size = new System.Drawing.Size(342, 316);
            this.floorsGrid.TabIndex = 12;
            this.floorsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.floorsGridView});
            // 
            // floorsGridView
            // 
            this.floorsGridView.GridControl = this.floorsGrid;
            this.floorsGridView.Name = "floorsGridView";
            // 
            // FloorDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 553);
            this.Controls.Add(this.floorsGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FloorDirectoryForm";
            this.Text = "Floor directory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxApartmentsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumberEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView citiesGridView;
        private System.Windows.Forms.NumericUpDown maxApartmentsEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown floorNumberEdit;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit hotelEdit;
        private DevExpress.XtraEditors.SimpleButton addApartment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraGrid.GridControl floorsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView floorsGridView;
    }
}