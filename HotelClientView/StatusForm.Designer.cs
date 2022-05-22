namespace HotelClientView
{
    partial class StatusForm
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
            this.apartmentsGrid = new DevExpress.XtraGrid.GridControl();
            this.apartmentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hotelEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.hotelView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.floorsNumbers = new DevExpress.XtraEditors.LabelControl();
            this.floorEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.floorView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cityEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cityView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.countryEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.countryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryView)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentsGrid
            // 
            this.apartmentsGrid.Location = new System.Drawing.Point(9, 101);
            this.apartmentsGrid.MainView = this.apartmentsGridView;
            this.apartmentsGrid.Name = "apartmentsGrid";
            this.apartmentsGrid.Size = new System.Drawing.Size(1081, 509);
            this.apartmentsGrid.TabIndex = 4;
            this.apartmentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.apartmentsGridView});
            // 
            // apartmentsGridView
            // 
            this.apartmentsGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.apartmentsGridView.GridControl = this.apartmentsGrid;
            this.apartmentsGridView.Name = "apartmentsGridView";
            this.apartmentsGridView.OptionsBehavior.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hotelEdit);
            this.groupBox3.Controls.Add(this.floorsNumbers);
            this.groupBox3.Controls.Add(this.floorEdit);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.labelControl2);
            this.groupBox3.Controls.Add(this.labelControl1);
            this.groupBox3.Controls.Add(this.cityEdit);
            this.groupBox3.Controls.Add(this.countryEdit);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1087, 92);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location";
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
            this.hotelEdit.TabIndex = 22;
            // 
            // hotelView
            // 
            this.hotelView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.hotelView.Name = "hotelView";
            this.hotelView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.hotelView.OptionsView.ShowGroupPanel = false;
            // 
            // floorsNumbers
            // 
            this.floorsNumbers.Location = new System.Drawing.Point(485, 28);
            this.floorsNumbers.Name = "floorsNumbers";
            this.floorsNumbers.Size = new System.Drawing.Size(27, 13);
            this.floorsNumbers.TabIndex = 21;
            this.floorsNumbers.Text = "Floor ";
            // 
            // floorEdit
            // 
            this.floorEdit.Location = new System.Drawing.Point(485, 45);
            this.floorEdit.Name = "floorEdit";
            this.floorEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.floorEdit.Properties.NullText = "";
            this.floorEdit.Properties.PopupView = this.floorView;
            this.floorEdit.Size = new System.Drawing.Size(141, 20);
            this.floorEdit.TabIndex = 20;
            // 
            // floorView
            // 
            this.floorView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.floorView.Name = "floorView";
            this.floorView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.floorView.OptionsView.ShowGroupPanel = false;
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
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 613);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.apartmentsGrid);
            this.Name = "StatusForm";
            this.Text = "Status form";
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl apartmentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView apartmentsGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cityEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView cityView;
        private DevExpress.XtraEditors.SearchLookUpEdit countryEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView countryView;
        private DevExpress.XtraEditors.LabelControl floorsNumbers;
        private DevExpress.XtraEditors.SearchLookUpEdit floorEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView floorView;
        private DevExpress.XtraEditors.SearchLookUpEdit hotelEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView hotelView;
    }
}