namespace HotelClientView
{
    partial class GuestDirectoryForm
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
            this.editRelations = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passportNumberEdit = new System.Windows.Forms.TextBox();
            this.lastnameEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.filterButton = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.hotelEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.hotelView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label11 = new System.Windows.Forms.Label();
            this.cityEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cityView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label10 = new System.Windows.Forms.Label();
            this.countryEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.countryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sexEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.emailEdit = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneEdit = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOfBirthEdit = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.middlenameEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.firstnameEdit = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guestsGrid = new DevExpress.XtraGrid.GridControl();
            this.guestsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlenameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsGridView)).BeginInit();
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
            this.groupBox1.Controls.Add(this.editRelations);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions on selected record";
            // 
            // editRelations
            // 
            this.editRelations.Location = new System.Drawing.Point(175, 20);
            this.editRelations.Name = "editRelations";
            this.editRelations.Size = new System.Drawing.Size(149, 23);
            this.editRelations.TabIndex = 3;
            this.editRelations.Text = "Parent-childs relations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.passportNumberEdit);
            this.groupBox2.Controls.Add(this.lastnameEdit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.filterButton);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.hotelEdit);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cityEdit);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.countryEdit);
            this.groupBox2.Controls.Add(this.sexEdit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.emailEdit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.phoneEdit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateOfBirthEdit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.middlenameEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.firstnameEdit);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 149);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text fields actions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Passport number ?";
            // 
            // passportNumberEdit
            // 
            this.passportNumberEdit.Location = new System.Drawing.Point(175, 119);
            this.passportNumberEdit.Name = "passportNumberEdit";
            this.passportNumberEdit.Size = new System.Drawing.Size(149, 21);
            this.passportNumberEdit.TabIndex = 45;
            // 
            // lastnameEdit
            // 
            this.lastnameEdit.Location = new System.Drawing.Point(175, 69);
            this.lastnameEdit.Name = "lastnameEdit";
            this.lastnameEdit.Size = new System.Drawing.Size(149, 20);
            this.lastnameEdit.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Lastname ?";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(501, 20);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(153, 23);
            this.filterButton.TabIndex = 33;
            this.filterButton.Text = "Load guests";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(830, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Hotel ?";
            // 
            // hotelEdit
            // 
            this.hotelEdit.Location = new System.Drawing.Point(833, 69);
            this.hotelEdit.Name = "hotelEdit";
            this.hotelEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hotelEdit.Properties.NullText = "";
            this.hotelEdit.Properties.PopupView = this.hotelView;
            this.hotelEdit.Size = new System.Drawing.Size(149, 20);
            this.hotelEdit.TabIndex = 41;
            // 
            // hotelView
            // 
            this.hotelView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.hotelView.Name = "hotelView";
            this.hotelView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.hotelView.OptionsView.ShowGroupPanel = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "City ?";
            // 
            // cityEdit
            // 
            this.cityEdit.Location = new System.Drawing.Point(667, 120);
            this.cityEdit.Name = "cityEdit";
            this.cityEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cityEdit.Properties.NullText = "";
            this.cityEdit.Properties.PopupView = this.cityView;
            this.cityEdit.Size = new System.Drawing.Size(149, 20);
            this.cityEdit.TabIndex = 39;
            // 
            // cityView
            // 
            this.cityView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cityView.Name = "cityView";
            this.cityView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cityView.OptionsView.ShowGroupPanel = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(664, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Country ?";
            // 
            // countryEdit
            // 
            this.countryEdit.Location = new System.Drawing.Point(667, 69);
            this.countryEdit.Name = "countryEdit";
            this.countryEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.countryEdit.Properties.NullText = "";
            this.countryEdit.Properties.PopupView = this.countryView;
            this.countryEdit.Size = new System.Drawing.Size(149, 20);
            this.countryEdit.TabIndex = 37;
            // 
            // countryView
            // 
            this.countryView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.countryView.Name = "countryView";
            this.countryView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.countryView.OptionsView.ShowGroupPanel = false;
            // 
            // sexEdit
            // 
            this.sexEdit.EditValue = "";
            this.sexEdit.Location = new System.Drawing.Point(339, 119);
            this.sexEdit.Name = "sexEdit";
            this.sexEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sexEdit.Properties.NullText = "";
            this.sexEdit.Size = new System.Drawing.Size(149, 20);
            this.sexEdit.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Email";
            // 
            // emailEdit
            // 
            this.emailEdit.Location = new System.Drawing.Point(501, 119);
            this.emailEdit.Name = "emailEdit";
            this.emailEdit.Size = new System.Drawing.Size(149, 20);
            this.emailEdit.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Phone";
            // 
            // phoneEdit
            // 
            this.phoneEdit.Location = new System.Drawing.Point(501, 69);
            this.phoneEdit.Name = "phoneEdit";
            this.phoneEdit.Size = new System.Drawing.Size(149, 20);
            this.phoneEdit.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date of birth ?";
            // 
            // dateOfBirthEdit
            // 
            this.dateOfBirthEdit.EditValue = null;
            this.dateOfBirthEdit.Location = new System.Drawing.Point(339, 69);
            this.dateOfBirthEdit.Name = "dateOfBirthEdit";
            this.dateOfBirthEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfBirthEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfBirthEdit.Size = new System.Drawing.Size(149, 20);
            this.dateOfBirthEdit.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Middlename";
            // 
            // middlenameEdit
            // 
            this.middlenameEdit.Location = new System.Drawing.Point(10, 120);
            this.middlenameEdit.Name = "middlenameEdit";
            this.middlenameEdit.Size = new System.Drawing.Size(149, 20);
            this.middlenameEdit.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Firstname ?";
            // 
            // firstnameEdit
            // 
            this.firstnameEdit.Location = new System.Drawing.Point(10, 69);
            this.firstnameEdit.Name = "firstnameEdit";
            this.firstnameEdit.Size = new System.Drawing.Size(149, 20);
            this.firstnameEdit.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // guestsGrid
            // 
            this.guestsGrid.Location = new System.Drawing.Point(6, 219);
            this.guestsGrid.MainView = this.guestsGridView;
            this.guestsGrid.Name = "guestsGrid";
            this.guestsGrid.Size = new System.Drawing.Size(1000, 332);
            this.guestsGrid.TabIndex = 12;
            this.guestsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.guestsGridView});
            // 
            // guestsGridView
            // 
            this.guestsGridView.GridControl = this.guestsGrid;
            this.guestsGridView.Name = "guestsGridView";
            // 
            // GuestDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 551);
            this.Controls.Add(this.guestsGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuestDirectoryForm";
            this.Text = "Guest registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlenameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView citiesGridView;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit firstnameEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.DateEdit dateOfBirthEdit;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit middlenameEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit emailEdit;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit phoneEdit;
        private DevExpress.XtraEditors.SimpleButton filterButton;
        private DevExpress.XtraGrid.GridControl guestsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView guestsGridView;
        private DevExpress.XtraEditors.LookUpEdit sexEdit;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SearchLookUpEdit hotelEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView hotelView;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SearchLookUpEdit cityEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView cityView;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SearchLookUpEdit countryEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView countryView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passportNumberEdit;
        private DevExpress.XtraEditors.TextEdit lastnameEdit;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton editRelations;
    }
}