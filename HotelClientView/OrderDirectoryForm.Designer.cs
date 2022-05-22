namespace HotelClientView
{
    partial class OrderDirectoryForm
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
            this.gridOrders = new DevExpress.XtraGrid.GridControl();
            this.ordersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculatePriceButton = new DevExpress.XtraEditors.SimpleButton();
            this.checkOutOrderButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteOrderButton = new DevExpress.XtraEditors.SimpleButton();
            this.guestsOrderButton = new DevExpress.XtraEditors.SimpleButton();
            this.createOrderButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.departureDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.apartmentEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.apartmentView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.hotelEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.hotelView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cityEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cityView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.countryEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.countryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.guestFamilyNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.guestPassportNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.openGuestsDirectory = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.loadCustomersButton = new DevExpress.XtraEditors.SimpleButton();
            this.customersLastnameEdit = new DevExpress.XtraEditors.TextEdit();
            this.customerFirstnameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.customerEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.customerView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestFamilyNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestPassportNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersLastnameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFirstnameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrders
            // 
            this.gridOrders.Location = new System.Drawing.Point(9, 238);
            this.gridOrders.MainView = this.ordersView;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(1081, 372);
            this.gridOrders.TabIndex = 4;
            this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ordersView});
            // 
            // ordersView
            // 
            this.ordersView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ordersView.GridControl = this.gridOrders;
            this.ordersView.Name = "ordersView";
            this.ordersView.OptionsBehavior.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculatePriceButton);
            this.groupBox1.Controls.Add(this.checkOutOrderButton);
            this.groupBox1.Controls.Add(this.deleteOrderButton);
            this.groupBox1.Controls.Add(this.guestsOrderButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected order operations";
            // 
            // calculatePriceButton
            // 
            this.calculatePriceButton.Location = new System.Drawing.Point(168, 24);
            this.calculatePriceButton.Name = "calculatePriceButton";
            this.calculatePriceButton.Size = new System.Drawing.Size(141, 23);
            this.calculatePriceButton.TabIndex = 10;
            this.calculatePriceButton.Text = "Calculate price";
            // 
            // checkOutOrderButton
            // 
            this.checkOutOrderButton.Location = new System.Drawing.Point(326, 24);
            this.checkOutOrderButton.Name = "checkOutOrderButton";
            this.checkOutOrderButton.Size = new System.Drawing.Size(141, 23);
            this.checkOutOrderButton.TabIndex = 9;
            this.checkOutOrderButton.Text = "Paycheck";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(487, 24);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(141, 23);
            this.deleteOrderButton.TabIndex = 8;
            this.deleteOrderButton.Text = "Delete visit";
            // 
            // guestsOrderButton
            // 
            this.guestsOrderButton.Location = new System.Drawing.Point(9, 24);
            this.guestsOrderButton.Name = "guestsOrderButton";
            this.guestsOrderButton.Size = new System.Drawing.Size(141, 23);
            this.guestsOrderButton.TabIndex = 7;
            this.guestsOrderButton.Text = "Edit check-ins";
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(12, 12);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(141, 23);
            this.createOrderButton.TabIndex = 9;
            this.createOrderButton.Text = "Create visit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelControl10);
            this.groupBox3.Controls.Add(this.departureDateEdit);
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.apartmentEdit);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.labelControl2);
            this.groupBox3.Controls.Add(this.labelControl1);
            this.groupBox3.Controls.Add(this.hotelEdit);
            this.groupBox3.Controls.Add(this.cityEdit);
            this.groupBox3.Controls.Add(this.countryEdit);
            this.groupBox3.Location = new System.Drawing.Point(3, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 128);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(168, 71);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(74, 13);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Departure date";
            // 
            // departureDateEdit
            // 
            this.departureDateEdit.EditValue = null;
            this.departureDateEdit.Location = new System.Drawing.Point(168, 90);
            this.departureDateEdit.Name = "departureDateEdit";
            this.departureDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.departureDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.departureDateEdit.Size = new System.Drawing.Size(141, 20);
            this.departureDateEdit.TabIndex = 22;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 71);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Apartment";
            // 
            // apartmentEdit
            // 
            this.apartmentEdit.Location = new System.Drawing.Point(10, 90);
            this.apartmentEdit.Name = "apartmentEdit";
            this.apartmentEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.apartmentEdit.Properties.NullText = "";
            this.apartmentEdit.Properties.PopupView = this.apartmentView;
            this.apartmentEdit.Size = new System.Drawing.Size(141, 20);
            this.apartmentEdit.TabIndex = 20;
            // 
            // apartmentView
            // 
            this.apartmentView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.apartmentView.Name = "apartmentView";
            this.apartmentView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.apartmentView.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(326, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Hotel name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(168, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "City name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Country name";
            // 
            // hotelEdit
            // 
            this.hotelEdit.Location = new System.Drawing.Point(326, 45);
            this.hotelEdit.Name = "hotelEdit";
            this.hotelEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hotelEdit.Properties.NullText = "";
            this.hotelEdit.Properties.PopupView = this.hotelView;
            this.hotelEdit.Size = new System.Drawing.Size(141, 20);
            this.hotelEdit.TabIndex = 14;
            // 
            // hotelView
            // 
            this.hotelView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.hotelView.Name = "hotelView";
            this.hotelView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.hotelView.OptionsView.ShowGroupPanel = false;
            // 
            // cityEdit
            // 
            this.cityEdit.Location = new System.Drawing.Point(168, 45);
            this.cityEdit.Name = "cityEdit";
            this.cityEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cityEdit.Properties.NullText = "";
            this.cityEdit.Properties.PopupView = this.cityView;
            this.cityEdit.Size = new System.Drawing.Size(141, 20);
            this.cityEdit.TabIndex = 13;
            // 
            // cityView
            // 
            this.cityView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cityView.Name = "cityView";
            this.cityView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cityView.OptionsView.ShowGroupPanel = false;
            // 
            // countryEdit
            // 
            this.countryEdit.EditValue = "";
            this.countryEdit.Location = new System.Drawing.Point(9, 45);
            this.countryEdit.Name = "countryEdit";
            this.countryEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.countryEdit.Properties.NullText = "";
            this.countryEdit.Properties.PopupView = this.countryView;
            this.countryEdit.Size = new System.Drawing.Size(141, 20);
            this.countryEdit.TabIndex = 12;
            // 
            // countryView
            // 
            this.countryView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.countryView.Name = "countryView";
            this.countryView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.countryView.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.guestFamilyNameEdit);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.guestPassportNumberEdit);
            this.groupBox2.Controls.Add(this.openGuestsDirectory);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.loadCustomersButton);
            this.groupBox2.Controls.Add(this.customersLastnameEdit);
            this.groupBox2.Controls.Add(this.customerFirstnameEdit);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.customerEdit);
            this.groupBox2.Location = new System.Drawing.Point(484, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 153);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guest";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(447, 20);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Family name";
            // 
            // guestFamilyNameEdit
            // 
            this.guestFamilyNameEdit.Location = new System.Drawing.Point(447, 39);
            this.guestFamilyNameEdit.Name = "guestFamilyNameEdit";
            this.guestFamilyNameEdit.Size = new System.Drawing.Size(141, 20);
            this.guestFamilyNameEdit.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(300, 20);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 13);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Passport number";
            // 
            // guestPassportNumberEdit
            // 
            this.guestPassportNumberEdit.Location = new System.Drawing.Point(300, 39);
            this.guestPassportNumberEdit.Name = "guestPassportNumberEdit";
            this.guestPassportNumberEdit.Size = new System.Drawing.Size(141, 20);
            this.guestPassportNumberEdit.TabIndex = 41;
            // 
            // openGuestsDirectory
            // 
            this.openGuestsDirectory.Location = new System.Drawing.Point(300, 113);
            this.openGuestsDirectory.Name = "openGuestsDirectory";
            this.openGuestsDirectory.Size = new System.Drawing.Size(141, 23);
            this.openGuestsDirectory.TabIndex = 40;
            this.openGuestsDirectory.Text = "Open guests directory";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(153, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 39;
            this.labelControl6.Text = "Lastname";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Firstname";
            // 
            // loadCustomersButton
            // 
            this.loadCustomersButton.Location = new System.Drawing.Point(6, 112);
            this.loadCustomersButton.Name = "loadCustomersButton";
            this.loadCustomersButton.Size = new System.Drawing.Size(141, 23);
            this.loadCustomersButton.TabIndex = 37;
            this.loadCustomersButton.Text = "Load guests";
            // 
            // customersLastnameEdit
            // 
            this.customersLastnameEdit.Location = new System.Drawing.Point(153, 39);
            this.customersLastnameEdit.Name = "customersLastnameEdit";
            this.customersLastnameEdit.Size = new System.Drawing.Size(141, 20);
            this.customersLastnameEdit.TabIndex = 36;
            // 
            // customerFirstnameEdit
            // 
            this.customerFirstnameEdit.Location = new System.Drawing.Point(6, 39);
            this.customerFirstnameEdit.Name = "customerFirstnameEdit";
            this.customerFirstnameEdit.Size = new System.Drawing.Size(141, 20);
            this.customerFirstnameEdit.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(153, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Select guest";
            // 
            // customerEdit
            // 
            this.customerEdit.EditValue = "";
            this.customerEdit.Enabled = false;
            this.customerEdit.Location = new System.Drawing.Point(153, 115);
            this.customerEdit.Name = "customerEdit";
            this.customerEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerEdit.Properties.NullText = "";
            this.customerEdit.Properties.PopupView = this.customerView;
            this.customerEdit.Size = new System.Drawing.Size(141, 20);
            this.customerEdit.TabIndex = 33;
            // 
            // customerView
            // 
            this.customerView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.customerView.Name = "customerView";
            this.customerView.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.customerView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.customerView.OptionsView.ShowGroupPanel = false;
            // 
            // OrderDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 613);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridOrders);
            this.Name = "OrderDirectoryForm";
            this.Text = "Order directory form";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestFamilyNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestPassportNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersLastnameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFirstnameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView ordersView;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton deleteOrderButton;
        private DevExpress.XtraEditors.SimpleButton guestsOrderButton;
        private DevExpress.XtraEditors.SimpleButton createOrderButton;
        private DevExpress.XtraEditors.SimpleButton checkOutOrderButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit hotelEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView hotelView;
        private DevExpress.XtraEditors.SearchLookUpEdit cityEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView cityView;
        private DevExpress.XtraEditors.SearchLookUpEdit countryEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView countryView;
        private DevExpress.XtraEditors.SimpleButton calculatePriceButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit guestPassportNumberEdit;
        private DevExpress.XtraEditors.SimpleButton openGuestsDirectory;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton loadCustomersButton;
        private DevExpress.XtraEditors.TextEdit customersLastnameEdit;
        private DevExpress.XtraEditors.TextEdit customerFirstnameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit customerEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView customerView;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit guestFamilyNameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SearchLookUpEdit apartmentEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView apartmentView;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit departureDateEdit;
    }
}