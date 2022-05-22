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
    public partial class GuestDirectoryForm: DevExpress.XtraEditors.XtraForm, IGuestDirectoryView
    {
        private readonly ApplicationContext _context;
        public GuestDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            
            deleteButton.Click += (sender, args) => Invoke(DeleteGuest);
            addButton.Click += (sender, args) => Invoke(AddGuest);
            guestsGridView.CellValueChanged += (sender, args) => Invoke(UpdateGuest);
            filterButton.Click += (sender, args) => Invoke(LoadGuests);
            this.Load += (sender, args) => Invoke(LoadCountries);
            this.countryEdit.EditValueChanged += (sender, args) => Invoke(LoadCities);
            this.countryEdit.EditValueChanged += (sender, args) => Invoke(LoadHotels);
            editRelations.Click += (sender, args) => Invoke(EditChildParentRelations);
        }

        public event Action AddGuest;
        public event Action DeleteGuest;
        public event Action UpdateGuest;
        public event Action LoadGuests;
        public event Action LoadCountries;
        public event Action LoadCities;
        public event Action LoadHotels;
        public event Action EditChildParentRelations;

        public Guest CurrentGuest
        {
            get
            {
                return guestsGridView.GetRow(guestsGridView.FocusedRowHandle) as Guest;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return guestsGridView.RowCount; 
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

        public List<Guest> GuestsDataSource
        {
            get
            {
                return guestsGrid.DataSource as List<Guest>;
            }
            set
            {
                guestsGrid.DataSource = value;
            }
        }

        public List<Country> CountryDataSource
        {
            set
            {
                countryEdit.Properties.DataSource = value;
            }
        }

        public List<City> CityDataSource
        {
            set
            {
                cityEdit.Properties.DataSource = value;
            }
        }

        public List<Hotel> HotelDataSource
        {
            set
            {
                hotelEdit.Properties.DataSource = value;
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

        public string FirstName
        {
            get
            {
                return firstnameEdit.Text;
            }
            set
            {
                firstnameEdit.Text = value;
            }
        }

        public string PassportNumber
        {
            get
            {
                return passportNumberEdit.Text;
            }
            set
            {
                passportNumberEdit.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastnameEdit.Text;
            }
            set
            {
                lastnameEdit.Text = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middlenameEdit.Text;
            }
            set
            {
                middlenameEdit.Text = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirthEdit.DateTime;
            }
            set
            {
                dateOfBirthEdit.Text = value.ToString();
            }
        }

        public string Sex
        {
            get
            {
                return sexEdit.Text;
            }
            set
            {
                sexEdit.Text = value;
            }
        }

        public string Phone
        {
            get
            {
                return phoneEdit.Text;
            }
            set
            {
                phoneEdit.Text = value;
            }
        }

        public string Email
        {
            get
            {
                return emailEdit.Text;
            }
            set
            {
                emailEdit.Text = value;
            }
        }

        public List<string> SexEditDataSource
        {
            set
            {
                sexEdit.Properties.DataSource = value;
            }
        }


    }
}