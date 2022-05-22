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
    public partial class OrderDirectoryForm : DevExpress.XtraEditors.XtraForm, IOrderDirectoryView
    {

        private readonly ApplicationContext _context;
        public OrderDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            this.Load += (sender, args) => Invoke(LoadCountries);
            this.countryEdit.EditValueChanged += (sender, args) => Invoke(LoadCities);
            this.countryEdit.EditValueChanged += (sender, args) => Invoke(LoadHotels);
            this.cityEdit.EditValueChanged += (sender, args) => Invoke(LoadHotels);
            this.createOrderButton.Click += (sender, args) => Invoke(AddOrder);
            this.guestsOrderButton.Click += (sender, args) => Invoke(EditListOfGuests);
            this.hotelEdit.EditValueChanged += (sender, args) => Invoke(LoadOrders);
            this.customerEdit.EditValueChanged += (sender, args) => Invoke(LoadOrders);
            this.deleteOrderButton.Click += (sender, args) => Invoke(DeleteOrder);
            this.loadCustomersButton.Click += (sender, args) => Invoke(LoadGuests);
            this.openGuestsDirectory.Click += (sender, args) => Invoke(OpenGuestsDirectory);
            this.calculatePriceButton.Click += (sender, args) => Invoke(CalculatePrice);
            this.checkOutOrderButton.Click += (sender, args) => Invoke(CheckOutOrder);
            this.hotelEdit.EditValueChanged += (sender, args) => Invoke(LoadApartments);
        }

        public event Action AddOrder;
        public event Action DeleteOrder;
        public event Action LoadOrders;
        public event Action LoadCountries;
        public event Action LoadCities;
        public event Action LoadHotels;
        public event Action LoadGuests;
        public event Action EditListOfGuests;
        public event Action CheckOutOrder;
        public event Action OpenGuestsDirectory;
        public event Action CalculatePrice;
        public event Action LoadApartments;

        public new void Show()
        {
            this.MdiParent = _context.MainForm;
            base.Show();
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

        public Apartment CurrentApartment
        {
            get
            {
                return apartmentEdit.EditValue as Apartment;
            }
        }

        public List<Order> OrdersDataSource
        {
            get
            {
                return gridOrders.DataSource as List<Order>; 
            }
            set
            {
                gridOrders.DataSource = value;
            }
        }

        public List<Country> CountriesDataSource
        {
            get
            {
                return countryView.DataSource as List<Country>;
            }
            set
            {
                countryEdit.Properties.DataSource = value;
            }
        }

        public List<City> CitiesDataSource
        {
            get
            {
                return cityView.DataSource as List<City>;
            }
            set
            {
                cityEdit.Properties.DataSource = value;
            }
        }

        public List<Hotel> HotelsDataSource
        {
            get
            {
                return hotelView.DataSource as List<Hotel>;
            }
            set
            {
                hotelEdit.Properties.DataSource = value;
            }
        }

        public List<Guest> CustomersDataSource
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

        public Order CurrentOrder
        {
            get
            {
                return ordersView.GetRow(ordersView.FocusedRowHandle) as Order;
            }
        }

        public Country CurrentCountry
        {
            get
            {
                return countryEdit.EditValue as Country;
            }
        }

        public City CurrentCity
        {
            get
            {
                return cityEdit.EditValue as City;
            }
        }

        public Hotel CurrentHotel
        {
            get
            {
                return hotelEdit.EditValue as Hotel;
            }
        }

        public Guest CurrentCustomer
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