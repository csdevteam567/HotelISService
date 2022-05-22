using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelClientPresentation;
using HotelClientModel;
using DevExpress.Utils.Win;
using DevExpress.XtraLayout;

namespace HotelClientView
{
    public partial class ChildParentRelationsForm : DevExpress.XtraEditors.XtraForm, IChildParentDirectoryView
    {

        private readonly ApplicationContext _context;
        public ChildParentRelationsForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            this.setRelationsButton.Click += (sender, args) => Invoke(AddRelation);
            this.deleteRelationButton.Click += (sender, args) => Invoke(DeleteRelation);
            
            this.loadParentsButton.Click += (sender, args) => Invoke(LoadParents);
            this.loadChildsButton.Click += (sender, args) => Invoke(LoadChilds);

            //this.loadParentsButton.Click += (sender, args) => Invoke(LoadRelations);
            //this.loadChildsButton.Click += (sender, args) => Invoke(LoadRelations);

            this.parentEdit.EditValueChanged += (sender, args) => Invoke(ViewUpdated);
            this.childEdit.EditValueChanged += (sender, args) => Invoke(ViewUpdated);

            this.relationsView.SelectionChanged += (sender, args) => Invoke(ViewUpdated);

            this.Load += (sender, args) => Invoke(LoadRelations);
        }

        public event Action AddRelation;
        public event Action DeleteRelation;
        public event Action LoadParents;
        public event Action LoadChilds;
        public event Action LoadRelations;
        public event Action ViewUpdated;

        public new void Show()
        {
            this.MdiParent = _context.MainForm;
            base.Show();
        }

        public List<ParentChild> ChildParentRelationDataSource
        {
            get
            {
                return gridRelations.DataSource as List<ParentChild>; 
            }
            set
            {
                gridRelations.DataSource = value;
            }
        }

        public List<Guest> ChildsDataSource
        {
            get
            {
                return childView.DataSource as List<Guest>;
            }
            set
            {
                childEdit.Properties.DataSource = value;
            }
        }

        public List<Guest> ParentsDataSource
        {
            get
            {
                return parentView.DataSource as List<Guest>;
            }
            set
            {
                parentEdit.Properties.DataSource = value;
            }
        }

        public ParentChild CurrentRelation
        {
            get
            {
                return relationsView.GetRow(relationsView.FocusedRowHandle) as ParentChild;
            }
        }

        Guest IChildParentDirectoryView.CurrentChild
        {
            get
            {
                return childEdit.EditValue as Guest;
            }

            set
            {
                childEdit.EditValue = value;
            }
        }

        public Guest CurrentParent
        {
            get
            {
                return parentEdit.EditValue as Guest;
            }

            set
            {
                parentEdit.EditValue = value;
            }
        }

        public string CustomerLastname
        {
            get
            {
                return customersLastnameEdit.Text;
            }
        }

        public string CustomerFirstname
        {
            get
            {
                return customerFirstnameEdit.Text;
            }
        }

        public string CustomerPassportNumber
        {
            get
            {
                return guestPassportNumberEdit.Text;
            }
        }

        public string CustomerFamily
        {
            get
            {
                return guestFamilyNameEdit.Text;
            }
        }

        public void ShowError(string errorMessage)
        {
            string caption = "Input error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errorMessage, caption, buttons);
        }
    }
}