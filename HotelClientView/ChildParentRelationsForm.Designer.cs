namespace HotelClientView
{
    partial class ChildParentRelationsForm
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
            this.gridRelations = new DevExpress.XtraGrid.GridControl();
            this.relationsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteRelationButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadChildsButton = new DevExpress.XtraEditors.SimpleButton();
            this.setRelationsButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.childEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.childView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.guestFamilyNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.guestPassportNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.loadParentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.customersLastnameEdit = new DevExpress.XtraEditors.TextEdit();
            this.customerFirstnameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.parentEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.parentView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestFamilyNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestPassportNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersLastnameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFirstnameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRelations
            // 
            this.gridRelations.Location = new System.Drawing.Point(9, 207);
            this.gridRelations.MainView = this.relationsView;
            this.gridRelations.Name = "gridRelations";
            this.gridRelations.Size = new System.Drawing.Size(599, 403);
            this.gridRelations.TabIndex = 4;
            this.gridRelations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.relationsView});
            // 
            // relationsView
            // 
            this.relationsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.relationsView.GridControl = this.gridRelations;
            this.relationsView.Name = "relationsView";
            this.relationsView.OptionsBehavior.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteRelationButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected order operations";
            // 
            // deleteRelationButton
            // 
            this.deleteRelationButton.Location = new System.Drawing.Point(12, 20);
            this.deleteRelationButton.Name = "deleteRelationButton";
            this.deleteRelationButton.Size = new System.Drawing.Size(141, 23);
            this.deleteRelationButton.TabIndex = 8;
            this.deleteRelationButton.Text = "Delete record";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadChildsButton);
            this.groupBox2.Controls.Add(this.setRelationsButton);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.childEdit);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.guestFamilyNameEdit);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.guestPassportNumberEdit);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.loadParentsButton);
            this.groupBox2.Controls.Add(this.customersLastnameEdit);
            this.groupBox2.Controls.Add(this.customerFirstnameEdit);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.parentEdit);
            this.groupBox2.Location = new System.Drawing.Point(9, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 141);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guest";
            // 
            // loadChildsButton
            // 
            this.loadChildsButton.Location = new System.Drawing.Point(447, 108);
            this.loadChildsButton.Name = "loadChildsButton";
            this.loadChildsButton.Size = new System.Drawing.Size(141, 23);
            this.loadChildsButton.TabIndex = 48;
            this.loadChildsButton.Text = "Load childs";
            // 
            // setRelationsButton
            // 
            this.setRelationsButton.Location = new System.Drawing.Point(6, 20);
            this.setRelationsButton.Name = "setRelationsButton";
            this.setRelationsButton.Size = new System.Drawing.Size(141, 23);
            this.setRelationsButton.TabIndex = 45;
            this.setRelationsButton.Text = "Add relation";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(300, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Child";
            // 
            // childEdit
            // 
            this.childEdit.Location = new System.Drawing.Point(300, 110);
            this.childEdit.Name = "childEdit";
            this.childEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.childEdit.Properties.NullText = "";
            this.childEdit.Properties.PopupView = this.childView;
            this.childEdit.Size = new System.Drawing.Size(141, 20);
            this.childEdit.TabIndex = 46;
            // 
            // childView
            // 
            this.childView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.childView.Name = "childView";
            this.childView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.childView.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(447, 49);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Family name";
            // 
            // guestFamilyNameEdit
            // 
            this.guestFamilyNameEdit.Location = new System.Drawing.Point(447, 70);
            this.guestFamilyNameEdit.Name = "guestFamilyNameEdit";
            this.guestFamilyNameEdit.Size = new System.Drawing.Size(141, 20);
            this.guestFamilyNameEdit.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(300, 49);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 13);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Passport number";
            // 
            // guestPassportNumberEdit
            // 
            this.guestPassportNumberEdit.Location = new System.Drawing.Point(300, 70);
            this.guestPassportNumberEdit.Name = "guestPassportNumberEdit";
            this.guestPassportNumberEdit.Size = new System.Drawing.Size(141, 20);
            this.guestPassportNumberEdit.TabIndex = 41;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(153, 49);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 39;
            this.labelControl6.Text = "Lastname";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Firstname";
            // 
            // loadParentsButton
            // 
            this.loadParentsButton.Location = new System.Drawing.Point(153, 107);
            this.loadParentsButton.Name = "loadParentsButton";
            this.loadParentsButton.Size = new System.Drawing.Size(141, 23);
            this.loadParentsButton.TabIndex = 37;
            this.loadParentsButton.Text = "Load parents";
            // 
            // customersLastnameEdit
            // 
            this.customersLastnameEdit.Location = new System.Drawing.Point(153, 70);
            this.customersLastnameEdit.Name = "customersLastnameEdit";
            this.customersLastnameEdit.Size = new System.Drawing.Size(141, 20);
            this.customersLastnameEdit.TabIndex = 36;
            // 
            // customerFirstnameEdit
            // 
            this.customerFirstnameEdit.Location = new System.Drawing.Point(6, 70);
            this.customerFirstnameEdit.Name = "customerFirstnameEdit";
            this.customerFirstnameEdit.Size = new System.Drawing.Size(141, 20);
            this.customerFirstnameEdit.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Parent";
            // 
            // parentEdit
            // 
            this.parentEdit.EditValue = "";
            this.parentEdit.Location = new System.Drawing.Point(6, 110);
            this.parentEdit.Name = "parentEdit";
            this.parentEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.parentEdit.Properties.NullText = "";
            this.parentEdit.Properties.PopupView = this.parentView;
            this.parentEdit.Size = new System.Drawing.Size(141, 20);
            this.parentEdit.TabIndex = 33;
            // 
            // parentView
            // 
            this.parentView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.parentView.Name = "parentView";
            this.parentView.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.parentView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.parentView.OptionsView.ShowGroupPanel = false;
            // 
            // ChildParentRelationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridRelations);
            this.Name = "ChildParentRelationsForm";
            this.Text = "Parents childs relations";
            ((System.ComponentModel.ISupportInitialize)(this.gridRelations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestFamilyNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestPassportNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersLastnameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFirstnameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridRelations;
        private DevExpress.XtraGrid.Views.Grid.GridView relationsView;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton deleteRelationButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit guestFamilyNameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit guestPassportNumberEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton loadParentsButton;
        private DevExpress.XtraEditors.TextEdit customersLastnameEdit;
        private DevExpress.XtraEditors.TextEdit customerFirstnameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit parentEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView parentView;
        private DevExpress.XtraEditors.SimpleButton setRelationsButton;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit childEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView childView;
        private DevExpress.XtraEditors.SimpleButton loadChildsButton;
    }
}