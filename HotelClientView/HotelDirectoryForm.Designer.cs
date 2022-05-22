namespace HotelClientView
{
    partial class HotelDirectoryForm
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
            this.hotelGridControl = new DevExpress.XtraGrid.GridControl();
            this.hotelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addFloorsButton = new DevExpress.XtraEditors.SimpleButton();
            this.addRestaurant = new DevExpress.XtraEditors.SimpleButton();
            this.countryEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cityEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.hotelEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ratingEdit = new System.Windows.Forms.NumericUpDown();
            this.floorsCountEdit = new System.Windows.Forms.NumericUpDown();
            this.countryEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cityEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEditView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsCountEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelGridControl
            // 
            this.hotelGridControl.Location = new System.Drawing.Point(6, 230);
            this.hotelGridControl.MainView = this.hotelGridView;
            this.hotelGridControl.Name = "hotelGridControl";
            this.hotelGridControl.Size = new System.Drawing.Size(637, 377);
            this.hotelGridControl.TabIndex = 12;
            this.hotelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hotelGridView,
            this.gridView1});
            // 
            // hotelGridView
            // 
            this.hotelGridView.GridControl = this.hotelGridControl;
            this.hotelGridView.Name = "hotelGridView";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.hotelGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(153, 24);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete selected record";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addFloorsButton);
            this.groupBox1.Controls.Add(this.addRestaurant);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions on selected record";
            // 
            // addFloorsButton
            // 
            this.addFloorsButton.Location = new System.Drawing.Point(324, 21);
            this.addFloorsButton.Name = "addFloorsButton";
            this.addFloorsButton.Size = new System.Drawing.Size(152, 23);
            this.addFloorsButton.TabIndex = 24;
            this.addFloorsButton.Text = "Manage floors";
            // 
            // addRestaurant
            // 
            this.addRestaurant.Location = new System.Drawing.Point(165, 20);
            this.addRestaurant.Name = "addRestaurant";
            this.addRestaurant.Size = new System.Drawing.Size(152, 23);
            this.addRestaurant.TabIndex = 23;
            this.addRestaurant.Text = "Manage restaurants";
            // 
            // countryEditView
            // 
            this.countryEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.countryEditView.Name = "countryEditView";
            this.countryEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.countryEditView.OptionsView.ShowGroupPanel = false;
            // 
            // cityEditView
            // 
            this.cityEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cityEditView.Name = "cityEditView";
            this.cityEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cityEditView.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cityEdit);
            this.groupBox2.Controls.Add(this.countryEdit);
            this.groupBox2.Controls.Add(this.floorsCountEdit);
            this.groupBox2.Controls.Add(this.ratingEdit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hotelEdit);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 160);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text fields actions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "City";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 22);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add hotel";
            // 
            // hotelEdit
            // 
            this.hotelEdit.Location = new System.Drawing.Point(323, 69);
            this.hotelEdit.Name = "hotelEdit";
            this.hotelEdit.Size = new System.Drawing.Size(153, 20);
            this.hotelEdit.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hotel rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hotel name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hotel max floors count";
            // 
            // ratingEdit
            // 
            this.ratingEdit.Location = new System.Drawing.Point(9, 116);
            this.ratingEdit.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingEdit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ratingEdit.Name = "ratingEdit";
            this.ratingEdit.Size = new System.Drawing.Size(150, 21);
            this.ratingEdit.TabIndex = 22;
            this.ratingEdit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // floorsCountEdit
            // 
            this.floorsCountEdit.Location = new System.Drawing.Point(168, 117);
            this.floorsCountEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.floorsCountEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floorsCountEdit.Name = "floorsCountEdit";
            this.floorsCountEdit.Size = new System.Drawing.Size(149, 21);
            this.floorsCountEdit.TabIndex = 23;
            this.floorsCountEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // countryEdit
            // 
            this.countryEdit.Location = new System.Drawing.Point(6, 68);
            this.countryEdit.Name = "countryEdit";
            this.countryEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.countryEdit.Properties.NullText = "";
            this.countryEdit.Size = new System.Drawing.Size(153, 20);
            this.countryEdit.TabIndex = 24;
            // 
            // cityEdit
            // 
            this.cityEdit.Location = new System.Drawing.Point(165, 69);
            this.cityEdit.Name = "cityEdit";
            this.cityEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cityEdit.Properties.NullText = "";
            this.cityEdit.Size = new System.Drawing.Size(152, 20);
            this.cityEdit.TabIndex = 25;
            // 
            // HotelDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 608);
            this.Controls.Add(this.hotelGridControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HotelDirectoryForm";
            this.Text = "Hotel directory form";
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEditView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsCountEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl hotelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView hotelGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton addFloorsButton;
        private DevExpress.XtraEditors.SimpleButton addRestaurant;
        private DevExpress.XtraGrid.Views.Grid.GridView countryEditView;
        private DevExpress.XtraGrid.Views.Grid.GridView cityEditView;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SearchLookUpEdit cityEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit countryEdit;
        private System.Windows.Forms.NumericUpDown floorsCountEdit;
        private System.Windows.Forms.NumericUpDown ratingEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit hotelEdit;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}