namespace HotelClientView
{
    partial class PaycheckDirectoryForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.totalPriceView = new DevExpress.XtraEditors.TextEdit();
            this.dishesGrid = new DevExpress.XtraGrid.GridControl();
            this.dishesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.apartmentsGrid = new DevExpress.XtraGrid.GridControl();
            this.apartmentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cityNameView = new DevExpress.XtraEditors.TextEdit();
            this.countryNameView = new DevExpress.XtraEditors.TextEdit();
            this.hotelNameView = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityNameView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryNameView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelNameView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.totalPriceView);
            this.layoutControl1.Controls.Add(this.dishesGrid);
            this.layoutControl1.Controls.Add(this.apartmentsGrid);
            this.layoutControl1.Controls.Add(this.cityNameView);
            this.layoutControl1.Controls.Add(this.countryNameView);
            this.layoutControl1.Controls.Add(this.hotelNameView);
            this.layoutControl1.Location = new System.Drawing.Point(4, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(936, 661);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // totalPriceView
            // 
            this.totalPriceView.Location = new System.Drawing.Point(72, 629);
            this.totalPriceView.Name = "totalPriceView";
            this.totalPriceView.Properties.ReadOnly = true;
            this.totalPriceView.Size = new System.Drawing.Size(852, 20);
            this.totalPriceView.StyleController = this.layoutControl1;
            this.totalPriceView.TabIndex = 25;
            // 
            // dishesGrid
            // 
            this.dishesGrid.Location = new System.Drawing.Point(458, 36);
            this.dishesGrid.MainView = this.dishesGridView;
            this.dishesGrid.Name = "dishesGrid";
            this.dishesGrid.Size = new System.Drawing.Size(466, 589);
            this.dishesGrid.TabIndex = 24;
            this.dishesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dishesGridView});
            // 
            // dishesGridView
            // 
            this.dishesGridView.GridControl = this.dishesGrid;
            this.dishesGridView.Name = "dishesGridView";
            this.dishesGridView.OptionsBehavior.ReadOnly = true;
            // 
            // apartmentsGrid
            // 
            this.apartmentsGrid.Location = new System.Drawing.Point(12, 36);
            this.apartmentsGrid.MainView = this.apartmentsGridView;
            this.apartmentsGrid.Name = "apartmentsGrid";
            this.apartmentsGrid.Size = new System.Drawing.Size(442, 589);
            this.apartmentsGrid.TabIndex = 23;
            this.apartmentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.apartmentsGridView});
            // 
            // apartmentsGridView
            // 
            this.apartmentsGridView.GridControl = this.apartmentsGrid;
            this.apartmentsGridView.Name = "apartmentsGridView";
            this.apartmentsGridView.OptionsBehavior.ReadOnly = true;
            // 
            // cityNameView
            // 
            this.cityNameView.Location = new System.Drawing.Point(360, 12);
            this.cityNameView.Name = "cityNameView";
            this.cityNameView.Properties.ReadOnly = true;
            this.cityNameView.Size = new System.Drawing.Size(244, 20);
            this.cityNameView.StyleController = this.layoutControl1;
            this.cityNameView.TabIndex = 22;
            // 
            // countryNameView
            // 
            this.countryNameView.Location = new System.Drawing.Point(72, 12);
            this.countryNameView.Name = "countryNameView";
            this.countryNameView.Properties.ReadOnly = true;
            this.countryNameView.Size = new System.Drawing.Size(224, 20);
            this.countryNameView.StyleController = this.layoutControl1;
            this.countryNameView.TabIndex = 21;
            // 
            // hotelNameView
            // 
            this.hotelNameView.Location = new System.Drawing.Point(668, 12);
            this.hotelNameView.Name = "hotelNameView";
            this.hotelNameView.Properties.ReadOnly = true;
            this.hotelNameView.Size = new System.Drawing.Size(256, 20);
            this.hotelNameView.StyleController = this.layoutControl1;
            this.hotelNameView.TabIndex = 20;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(936, 661);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.countryNameView;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(288, 24);
            this.layoutControlItem1.Text = "Country: ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.hotelNameView;
            this.layoutControlItem2.Location = new System.Drawing.Point(596, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(320, 24);
            this.layoutControlItem2.Text = "Hotel: ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cityNameView;
            this.layoutControlItem3.Location = new System.Drawing.Point(288, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(308, 24);
            this.layoutControlItem3.Text = "City:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.apartmentsGrid;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(446, 593);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dishesGrid;
            this.layoutControlItem5.Location = new System.Drawing.Point(446, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(470, 593);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.totalPriceView;
            this.layoutControlItem6.CustomizationFormText = "Total price";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 617);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(916, 24);
            this.layoutControlItem6.Text = "Total price: ";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(57, 13);
            // 
            // PaycheckDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 665);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PaycheckDirectoryForm";
            this.Text = "Paycheck form";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityNameView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryNameView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelNameView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView citiesGridView;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit countryNameView;
        private DevExpress.XtraEditors.TextEdit hotelNameView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit cityNameView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit totalPriceView;
        private DevExpress.XtraGrid.GridControl dishesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView dishesGridView;
        private DevExpress.XtraGrid.GridControl apartmentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView apartmentsGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}