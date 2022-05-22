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
    public partial class OrderedApartmentDirectoryForm : DevExpress.XtraEditors.XtraForm, IOrderedApartmentDirectoryView
    {

        private readonly ApplicationContext _context;
        public OrderedApartmentDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            this.Load += (sender, args) => Invoke(LoadApartments);
            this.Load += (sender, args) => Invoke(LoadOrderedApartments);
            this.orderApartmentButton.Click += (sender, args) => Invoke(OrderApartment);
            this.deleteOrderButton.Click += (sender, args) => Invoke(DeleteOrderedApartment);
            this.loadCustomersButton.Click += (sender, args) => Invoke(LoadGuests);
            this.openGuestsDirectory.Click += (sender, args) => Invoke(OpenGuestsDirecory);
            this.checkOutGuestButton.Click += (sender, args) => Invoke(CheckOutGuest);
        }

        public event Action OrderApartment;
        public event Action DeleteOrderedApartment;
        public event Action LoadOrderedApartments;
        public event Action LoadApartments;
        public event Action LoadGuests;
        public event Action CheckOutGuest;
        public event Action OpenGuestsDirecory;

        public new void Show()
        {
            this.MdiParent = _context.MainForm;
            base.Show();
        }

        public List<OrderedApartment> OrderedApartmentsDataSource
        {
            get
            {
                return gridOrders.DataSource as List<OrderedApartment>; 
            }
            set
            {
                gridOrders.DataSource = value;
            }
        }

        public List<Apartment> AvailableApartmentsDataSource
        {
            get
            {
                return apartmentView.DataSource as List<Apartment>;
            }
            set
            {
                apartmentEdit.Properties.DataSource = value;
            }
        }

        public List<Guest> GuestsDataSource
        {
            get
            {
                return customerView.DataSource as List<Guest>;
            }
            set
            {
                customerEdit.Enabled = true;
                customerEdit.Properties.DataSource = value;
            }
        }

        public OrderedApartment CurrentOrderedApartment
        {
            get
            {
                return ordersView.GetRow(ordersView.FocusedRowHandle) as OrderedApartment;
            }
        }

        public Apartment CurrentApartment
        {
            get
            {
                return apartmentEdit.EditValue as Apartment;
            }
        }

        public Guest CurrentGuest
        {
            get
            {
                return customerEdit.EditValue as Guest;
            }

            set
            {
                customerEdit.EditValue = value;
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


        public DateTime DepartureDate
        {
            get 
            {
                return departureDateEdit.DateTime;
            }
        }
    }
}