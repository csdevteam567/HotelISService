namespace HotelClientView
{
    partial class UserDirectoryForm
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
            this.updatePasswordButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordEdit = new System.Windows.Forms.TextBox();
            this.repeatedPasswordEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userRoleEdit = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.userLastnameEdit = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.currentUserLoginEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.userFirstnameEdit = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usersGrid = new DevExpress.XtraGrid.GridControl();
            this.usersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLastnameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentUserLoginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFirstnameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
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
            this.groupBox1.Controls.Add(this.updatePasswordButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions on selected record";
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.Location = new System.Drawing.Point(168, 20);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(177, 24);
            this.updatePasswordButton.TabIndex = 3;
            this.updatePasswordButton.Text = "Update selected user password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwordEdit);
            this.groupBox2.Controls.Add(this.repeatedPasswordEdit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.userRoleEdit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.userLastnameEdit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.currentUserLoginEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.userFirstnameEdit);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 139);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text fields actions";
            // 
            // passwordEdit
            // 
            this.passwordEdit.Location = new System.Drawing.Point(168, 69);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.PasswordChar = '*';
            this.passwordEdit.Size = new System.Drawing.Size(149, 21);
            this.passwordEdit.TabIndex = 30;
            // 
            // repeatedPasswordEdit
            // 
            this.repeatedPasswordEdit.Location = new System.Drawing.Point(323, 69);
            this.repeatedPasswordEdit.Name = "repeatedPasswordEdit";
            this.repeatedPasswordEdit.PasswordChar = '*';
            this.repeatedPasswordEdit.Size = new System.Drawing.Size(149, 21);
            this.repeatedPasswordEdit.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Repeat user password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "User password";
            // 
            // userRoleEdit
            // 
            this.userRoleEdit.Location = new System.Drawing.Point(168, 108);
            this.userRoleEdit.Name = "userRoleEdit";
            this.userRoleEdit.Properties.Caption = "Is user admin";
            this.userRoleEdit.Size = new System.Drawing.Size(128, 19);
            this.userRoleEdit.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "User lastname";
            // 
            // userLastnameEdit
            // 
            this.userLastnameEdit.Location = new System.Drawing.Point(10, 108);
            this.userLastnameEdit.Name = "userLastnameEdit";
            this.userLastnameEdit.Size = new System.Drawing.Size(149, 20);
            this.userLastnameEdit.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Current user login";
            // 
            // currentUserLoginEdit
            // 
            this.currentUserLoginEdit.Enabled = false;
            this.currentUserLoginEdit.Location = new System.Drawing.Point(168, 24);
            this.currentUserLoginEdit.Name = "currentUserLoginEdit";
            this.currentUserLoginEdit.Size = new System.Drawing.Size(149, 20);
            this.currentUserLoginEdit.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "User firstname";
            // 
            // userFirstnameEdit
            // 
            this.userFirstnameEdit.Location = new System.Drawing.Point(10, 69);
            this.userFirstnameEdit.Name = "userFirstnameEdit";
            this.userFirstnameEdit.Size = new System.Drawing.Size(149, 20);
            this.userFirstnameEdit.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // usersGrid
            // 
            this.usersGrid.Location = new System.Drawing.Point(6, 209);
            this.usersGrid.MainView = this.usersGridView;
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(701, 342);
            this.usersGrid.TabIndex = 12;
            this.usersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGridView});
            // 
            // usersGridView
            // 
            this.usersGridView.GridControl = this.usersGrid;
            this.usersGridView.Name = "usersGridView";
            // 
            // UserDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 553);
            this.Controls.Add(this.usersGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserDirectoryForm";
            this.Text = "User directory form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLastnameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentUserLoginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFirstnameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView citiesGridView;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit userFirstnameEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit userLastnameEdit;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit currentUserLoginEdit;
        private DevExpress.XtraEditors.SimpleButton updatePasswordButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CheckEdit userRoleEdit;
        private System.Windows.Forms.TextBox passwordEdit;
        private System.Windows.Forms.TextBox repeatedPasswordEdit;
        private DevExpress.XtraGrid.GridControl usersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView usersGridView;
    }
}