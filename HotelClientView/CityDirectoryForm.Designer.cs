namespace HotelClientView
{
    partial class CityDirectoryForm
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
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.openCountriesDirectory = new DevExpress.XtraEditors.SimpleButton();
            this.countrySearchEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.countrySearchView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.cityEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.cityGridControl = new DevExpress.XtraGrid.GridControl();
            this.cityGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countrySearchEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countrySearchView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(242, 62);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(225, 22);
            this.deleteButton.StyleController = this.layoutControl1;
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete selected record";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.openCountriesDirectory);
            this.layoutControl1.Controls.Add(this.deleteButton);
            this.layoutControl1.Controls.Add(this.countrySearchEdit);
            this.layoutControl1.Controls.Add(this.addButton);
            this.layoutControl1.Controls.Add(this.cityEdit);
            this.layoutControl1.Location = new System.Drawing.Point(6, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(479, 96);
            this.layoutControl1.TabIndex = 13;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // openCountriesDirectory
            // 
            this.openCountriesDirectory.Location = new System.Drawing.Point(12, 36);
            this.openCountriesDirectory.Name = "openCountriesDirectory";
            this.openCountriesDirectory.Size = new System.Drawing.Size(226, 22);
            this.openCountriesDirectory.StyleController = this.layoutControl1;
            this.openCountriesDirectory.TabIndex = 21;
            this.openCountriesDirectory.Text = "Open country directory";
            // 
            // countrySearchEdit
            // 
            this.countrySearchEdit.Location = new System.Drawing.Point(88, 12);
            this.countrySearchEdit.Name = "countrySearchEdit";
            this.countrySearchEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.countrySearchEdit.Properties.NullText = "";
            this.countrySearchEdit.Properties.PopupView = this.countrySearchView;
            this.countrySearchEdit.Size = new System.Drawing.Size(150, 20);
            this.countrySearchEdit.StyleController = this.layoutControl1;
            this.countrySearchEdit.TabIndex = 20;
            // 
            // countrySearchView
            // 
            this.countrySearchView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.countrySearchView.Name = "countrySearchView";
            this.countrySearchView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.countrySearchView.OptionsView.ShowGroupPanel = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(242, 36);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(225, 22);
            this.addButton.StyleController = this.layoutControl1;
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add record";
            // 
            // cityEdit
            // 
            this.cityEdit.Location = new System.Drawing.Point(318, 12);
            this.cityEdit.Name = "cityEdit";
            this.cityEdit.Size = new System.Drawing.Size(149, 20);
            this.cityEdit.StyleController = this.layoutControl1;
            this.cityEdit.TabIndex = 18;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(479, 96);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.countrySearchEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem1.Text = "Select country:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 50);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(230, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cityEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(230, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(229, 24);
            this.layoutControlItem4.Text = "City name";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.addButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(230, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.deleteButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(230, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(229, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.openCountriesDirectory;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.cityGridControl);
            this.layoutControl2.Location = new System.Drawing.Point(18, 95);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(468, 481);
            this.layoutControl2.TabIndex = 14;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // cityGridControl
            // 
            this.cityGridControl.Location = new System.Drawing.Point(12, 12);
            this.cityGridControl.MainView = this.cityGridView;
            this.cityGridControl.Name = "cityGridControl";
            this.cityGridControl.Size = new System.Drawing.Size(444, 457);
            this.cityGridControl.TabIndex = 13;
            this.cityGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cityGridView});
            // 
            // cityGridView
            // 
            this.cityGridView.GridControl = this.cityGridControl;
            this.cityGridView.Name = "cityGridView";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(468, 481);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cityGridControl;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(448, 461);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // CityDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 576);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CityDirectoryForm";
            this.Text = "City directory form";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countrySearchEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countrySearchView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView citiesGridView;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton openCountriesDirectory;
        private DevExpress.XtraEditors.SearchLookUpEdit countrySearchEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView countrySearchView;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.TextEdit cityEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl cityGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView cityGridView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}