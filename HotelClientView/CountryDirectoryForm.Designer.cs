namespace HotelClientView
{
    partial class CountryDirectoryForm
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.countryGridControl = new DevExpress.XtraGrid.GridControl();
            this.countryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.countryEdit = new DevExpress.XtraEditors.TextEdit();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.countryGridControl);
            this.layoutControl1.Controls.Add(this.countryEdit);
            this.layoutControl1.Controls.Add(this.addButton);
            this.layoutControl1.Controls.Add(this.deleteButton);
            this.layoutControl1.Controls.Add(this.refreshButton);
            this.layoutControl1.Location = new System.Drawing.Point(13, 13);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(443, 382);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(443, 382);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // countryGridControl
            // 
            this.countryGridControl.Location = new System.Drawing.Point(12, 62);
            this.countryGridControl.MainView = this.countryGridView;
            this.countryGridControl.Name = "countryGridControl";
            this.countryGridControl.Size = new System.Drawing.Size(419, 308);
            this.countryGridControl.TabIndex = 10;
            this.countryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.countryGridView});
            // 
            // countryGridView
            // 
            this.countryGridView.GridControl = this.countryGridControl;
            this.countryGridView.Name = "countryGridView";
            // 
            // countryEdit
            // 
            this.countryEdit.Location = new System.Drawing.Point(88, 38);
            this.countryEdit.Name = "countryEdit";
            this.countryEdit.Size = new System.Drawing.Size(343, 20);
            this.countryEdit.StyleController = this.layoutControl1;
            this.countryEdit.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 22);
            this.addButton.StyleController = this.layoutControl1;
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(148, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(137, 22);
            this.deleteButton.StyleController = this.layoutControl1;
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(289, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(142, 22);
            this.refreshButton.StyleController = this.layoutControl1;
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.countryGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(423, 312);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.countryEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem2.Text = "Country name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.addButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(136, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.deleteButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(136, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(141, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.refreshButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(277, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(146, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // CountryDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 401);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CountryDirectoryForm";
            this.Text = "Country directory";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl countryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView countryGridView;
        private DevExpress.XtraEditors.TextEdit countryEdit;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}