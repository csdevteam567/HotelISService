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
    public partial class ApartmentDirectoryForm: DevExpress.XtraEditors.XtraForm, IApartmentDirectoryView
    {
        private readonly ApplicationContext _context;
        public ApartmentDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.Load += (sender, args) => Invoke(LoadApartments);
            deleteButton.Click += (sender, args) => Invoke(DeleteApartment);
            addButton.Click += (sender, args) => Invoke(AddApartment);
            apartmentsGridView.CellValueChanged += (sender, args) => Invoke(UpdateApartment);
        }

        public event Action AddApartment;
        public event Action DeleteApartment;
        public event Action UpdateApartment;
        public event Action LoadApartments;

        bool IApartmentDirectoryView.AdminControls
        {
            set
            {
                addButton.Enabled = value;
                deleteButton.Enabled = value;
                apartmentsGridView.OptionsBehavior.ReadOnly = !value;
            }
        }

        public Apartment CurrentApartment
        {
            get
            {
                return apartmentsGridView.GetRow(apartmentsGridView.FocusedRowHandle) as Apartment;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return apartmentsGridView.RowCount; 
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

        public List<Apartment> ApartmentDataSource
        {
            get
            {
                return apartmentsGrid.DataSource as List<Apartment>;
            }
            set
            {
                apartmentsGrid.DataSource = value;
            }
        }

        public string HotelName
        {
            get
            {
                return hotelEdit.Text;
            }
            set
            {
                hotelEdit.Text = value;
            }
        }

        public int ApartmentNumber
        {
            get
            {
                return (int)apartmentNumberEdit.Value;
            }
            set
            {
                apartmentNumberEdit.Value = value;
            }
        }

        public float ApartmentPrice
        {
            get
            {
                return (float)apartmentPriceEdit.Value;
            }
            set
            {
                apartmentPriceEdit.Value = (decimal)value;
            }
        }

        public bool HasStatusVip
        {
            get
            {
                return vipStatusEdit.Checked;
            }
            set
            {
                vipStatusEdit.Checked = value;
            }
        }

        public int MaxCapacity
        {
            get
            {
                return (int)maxCapacityEdit.Value;
            }
            set
            {
                maxCapacityEdit.Value = value;
            }
        }

        public int RoomsNumber
        {
            get
            {
                return (int)roomsNumberEdit.Value;
            }
            set
            {
                roomsNumberEdit.Value = value;
            }
        }
    }
}