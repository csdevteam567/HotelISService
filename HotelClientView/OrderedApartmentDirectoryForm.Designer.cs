namespace HotelClientView
{
    partial class OrderedApartmentDirectoryForm
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
            this.checkOutGuestButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteOrderButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departuredate = new DevExpress.XtraEditors.LabelControl();
            this.departureDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.orderApartmentButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.apartmentEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.apartmentView = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentView)).BeginInit();
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
            this.gridOrders.Location = new System.Drawing.Point(9, 207);
            this.gridOrders.MainView = this.ordersView;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(761, 403);
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
            this.groupBox1.Controls.Add(this.checkOutGuestButton);
            this.groupBox1.Controls.Add(this.deleteOrderButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected order operations";
            // 
            // checkOutGuestButton
            // 
            this.checkOutGuestButton.Location = new System.Drawing.Point(15, 20);
            this.checkOutGuestButton.Name = "checkOutGuestButton";
            this.checkOutGuestButton.Size = new System.Drawing.Size(141, 23);
            this.checkOutGuestButton.TabIndex = 9;
            this.checkOutGuestButton.Text = "Check-out guest";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(174, 20);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(141, 23);
            this.deleteOrderButton.TabIndex = 8;
            this.deleteOrderButton.Text = "Delete record";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.departuredate);
            this.groupBox2.Controls.Add(this.departureDateEdit);
            this.groupBox2.Controls.Add(this.orderApartmentButton);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.apartmentEdit);
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
            this.groupBox2.Location = new System.Drawing.Point(9, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 141);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guest";
            // 
            // departuredate
            // 
            this.departuredate.Location = new System.Drawing.Point(10, 90);
            this.departuredate.Name = "departuredate";
            this.departuredate.Size = new System.Drawing.Size(74, 13);
            this.departuredate.TabIndex = 49;
            this.departuredate.Text = "Departure date";
            // 
            // departureDateEdit
            // 
            this.departureDateEdit.EditValue = null;
            this.departureDateEdit.Location = new System.Drawing.Point(10, 105);
            this.departureDateEdit.Name = "departureDateEdit";
            this.departureDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.departureDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.departureDateEdit.Size = new System.Drawing.Size(140, 20);
            this.departureDateEdit.TabIndex = 48;
            // 
            // orderApartmentButton
            // 
            this.orderApartmentButton.Location = new System.Drawing.Point(6, 20);
            this.orderApartmentButton.Name = "orderApartmentButton";
            this.orderApartmentButton.Size = new System.Drawing.Size(141, 23);
            this.orderApartmentButton.TabIndex = 45;
            this.orderApartmentButton.Text = "Check-in";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Apartment";
            // 
            // apartmentEdit
            // 
            this.apartmentEdit.Location = new System.Drawing.Point(9, 65);
            this.apartmentEdit.Name = "apartmentEdit";
            this.apartmentEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.apartmentEdit.Properties.NullText = "";
            this.apartmentEdit.Properties.PopupView = this.apartmentView;
            this.apartmentEdit.Size = new System.Drawing.Size(141, 20);
            this.apartmentEdit.TabIndex = 46;
            // 
            // apartmentView
            // 
            this.apartmentView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.apartmentView.Name = "apartmentView";
            this.apartmentView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.apartmentView.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(609, 44);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Family name";
            // 
            // guestFamilyNameEdit
            // 
            this.guestFamilyNameEdit.Location = new System.Drawing.Point(609, 65);
            this.guestFamilyNameEdit.Name = "guestFamilyNameEdit";
            this.guestFamilyNameEdit.Size = new System.Drawing.Size(141, 20);
            this.guestFamilyNameEdit.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(462, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 13);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Passport number";
            // 
            // guestPassportNumberEdit
            // 
            this.guestPassportNumberEdit.Location = new System.Drawing.Point(462, 65);
            this.guestPassportNumberEdit.Name = "guestPassportNumberEdit";
            this.guestPassportNumberEdit.Size = new System.Drawing.Size(141, 20);
            this.guestPassportNumberEdit.TabIndex = 41;
            // 
            // openGuestsDirectory
            // 
            this.openGuestsDirectory.Location = new System.Drawing.Point(462, 102);
            this.openGuestsDirectory.Name = "openGuestsDirectory";
            this.openGuestsDirectory.Size = new System.Drawing.Size(141, 23);
            this.openGuestsDirectory.TabIndex = 40;
            this.openGuestsDirectory.Text = "Open guests directory";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(315, 44);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 39;
            this.labelControl6.Text = "Lastname";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(168, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Firstname";
            // 
            // loadCustomersButton
            // 
            this.loadCustomersButton.Location = new System.Drawing.Point(315, 103);
            this.loadCustomersButton.Name = "loadCustomersButton";
            this.loadCustomersButton.Size = new System.Drawing.Size(141, 23);
            this.loadCustomersButton.TabIndex = 37;
            this.loadCustomersButton.Text = "Load guests";
            // 
            // customersLastnameEdit
            // 
            this.customersLastnameEdit.Location = new System.Drawing.Point(315, 65);
            this.customersLastnameEdit.Name = "customersLastnameEdit";
            this.customersLastnameEdit.Size = new System.Drawing.Size(141, 20);
            this.customersLastnameEdit.TabIndex = 36;
            // 
            // customerFirstnameEdit
            // 
            this.customerFirstnameEdit.Location = new System.Drawing.Point(168, 65);
            this.customerFirstnameEdit.Name = "customerFirstnameEdit";
            this.customerFirstnameEdit.Size = new System.Drawing.Size(141, 20);
            this.customerFirstnameEdit.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(168, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Select guest";
            // 
            // customerEdit
            // 
            this.customerEdit.EditValue = "";
            this.customerEdit.Enabled = false;
            this.customerEdit.Location = new System.Drawing.Point(168, 105);
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
            // OrderedApartmentDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridOrders);
            this.Name = "OrderedApartmentDirectoryForm";
            this.Text = "Check in";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentView)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit guestFamilyNameEdit;
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
        private DevExpress.XtraEditors.SimpleButton checkOutGuestButton;
        private DevExpress.XtraEditors.LabelControl departuredate;
        private DevExpress.XtraEditors.DateEdit departureDateEdit;
        private DevExpress.XtraEditors.SimpleButton orderApartmentButton;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit apartmentEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView apartmentView;
    }
}