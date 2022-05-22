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
    public partial class HotelDirectoryForm : DevExpress.XtraEditors.XtraForm, IHotelDirectoryView
    {
        private readonly ApplicationContext _context;
        public HotelDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            deleteButton.Click += (sender, args) => Invoke(DeleteHotel);
            addButton.Click += (sender, args) => Invoke(AddHotel);
            addFloorsButton.Click += (sender, args) => Invoke(AddFloors);
            addRestaurant.Click += (sender, args) => Invoke(AddRestaurants);
            this.Load += (sender, args) => Invoke(LoadCountries);
            this.countryEdit.EditValueChanged += (sender, args) => Invoke(LoadCities);
            //this.countryEdit.EditValueChanged += (sender, args) => Invoke(LoadHotels);
            this.cityEdit.EditValueChanged += (sender, args) => Invoke(LoadHotels);
            hotelGridView.CellValueChanged += (sender, args) => Invoke(UpdateHotel);
        }

        bool IHotelDirectoryView.AdminControls
        {
            set
            {
                addButton.Enabled = value;
                deleteButton.Enabled = value;
                hotelGridView.OptionsBehavior.ReadOnly = !value;
            }
        }

        public City CurrentCity
        {
            get
            {
                return cityEdit.EditValue as City;
            }
        }

        public Country CurrentCountry
        {
            get
            {
                return countryEdit.EditValue as Country;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return hotelGridView.RowCount; 
            }
        }

        public new void Show()
        {
            this.MdiParent = _context.MainForm;
            base.Show();
        }

        public event Action AddHotel;
        public event Action DeleteHotel;
        public event Action UpdateHotel;
        public event Action LoadHotels;
        public event Action LoadCities;
        public event Action LoadCountries;
        public event Action AddFloors;
        public event Action AddRestaurants;

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

        public List<Country> CountriesDataSource
        {
            get
            {
                return countryEditView.DataSource as List<Country>;
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
                return cityEditView.DataSource as List<City>;
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
                return hotelGridControl.DataSource as List<Hotel>;
            }
            set
            {
                hotelGridControl.DataSource = value;
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

        public int HotelRating
        {
            get
            {
                return (int)ratingEdit.Value;
            }
            set
            {
                ratingEdit.Value = value;
            }
        }

        public int HotelFloorsCount
        {
            get
            {
                return (int)floorsCountEdit.Value;
            }
            set
            {
                floorsCountEdit.Value = value;
            }
        }

        public Hotel CurrentHotel
        {
            get
            {
                return hotelGridView.GetRow(hotelGridView.FocusedRowHandle) as Hotel;
            }
        }
    }
}