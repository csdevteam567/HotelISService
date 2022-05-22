using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelClientPresentation;
using HotelClientModel;

namespace HotelClientView
{
    public partial class UserDirectoryForm: DevExpress.XtraEditors.XtraForm, IUserDirectoryView
    {
        private readonly ApplicationContext _context;
        public UserDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.Load += (sender, args) => Invoke(LoadUsers);
            deleteButton.Click += (sender, args) => Invoke(DeleteUser);
            addButton.Click += (sender, args) => Invoke(AddUser);
            usersGridView.CellValueChanged += (sender, args) => Invoke(UpdateUser);
            updatePasswordButton.Click += (sender, args) => Invoke(UpdatePassword);
        }

        public event Action AddUser;
        public event Action DeleteUser;
        public event Action UpdateUser;
        public event Action LoadUsers;
        public event Action UpdatePassword;

        public User SelectedUser
        {
            get
            {
                return usersGridView.GetRow(usersGridView.FocusedRowHandle) as User;
            }
        }

        bool IUserDirectoryView.AdminControls
        {
            set
            {
                updatePasswordButton.Enabled = value;
                addButton.Enabled = value;
                deleteButton.Enabled = value;
                usersGridView.OptionsBehavior.ReadOnly = !value;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return usersGridView.RowCount; 
            }
        }

        public new void Show()
        {
            this.MdiParent = _context.MainForm;
            base.Show();
        }

        private void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }

        public void ShowError(string errorMessage)
        {
            string caption = "Input error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errorMessage, caption, buttons);
        }

        public List<User> UsersDataSource
        {
            get
            {
                return usersGrid.DataSource as List<User>;
            }
            set
            {
                usersGrid.DataSource = value;
            }
        }

        public string CurrentUserLogin
        {
            get
            {
                return currentUserLoginEdit.Text;
            }
            set
            {
                currentUserLoginEdit.Text = value;
            }
        }

        public string FirstName
        {
            get
            {
                return userFirstnameEdit.Text;
            }
            set
            {
                userFirstnameEdit.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return userLastnameEdit.Text;
            }
            set
            {
                userLastnameEdit.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordEdit.Text;
            }
            set
            {
                passwordEdit.Text = value;
            }
        }

        public string RepeatedPassword
        {
            get
            {
                return repeatedPasswordEdit.Text;
            }
            set
            {
                repeatedPasswordEdit.Text = value;
            }
        }

        public bool UserRole
        {
            get
            {
                return userRoleEdit.Checked;
            }
            set
            {
                userRoleEdit.Checked = value;
            }
        }
    }
}