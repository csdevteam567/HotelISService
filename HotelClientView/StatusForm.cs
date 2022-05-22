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
    public partial class StatusForm : DevExpress.XtraEditors.XtraForm, IStatusView
    {

        private readonly ApplicationContext _context;
        public StatusForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            this.Load += (sender, args) => Invoke(LoadCountries);
            this.countryEdit.EditValueChanged += (sender, args) => Invoke(LoadCities);
            this.cityEdit.EditValueChanged += (sender, args) => Invoke(LoadHotels);
            this.hotelEdit.EditValueChanged += (sender, args) => Invoke(LoadFloors);
            this.floorEdit.EditValueChanged += (sender, args) => Invoke(LoadStatus);
        }

        public event Action LoadCountries;
        public event Action LoadCities;
        public event Action LoadHotels;
        public event Action LoadFloors;
        public event Action LoadStatus;

        public new void Show()
        {
            this.MdiParent = _context.MainForm;
            base.Show();
        }

        public List<OrderedApartment> StatusDataSource
        {
            get
            {
                return apartmentsGrid.DataSource as List<OrderedApartment>;
            }
            set
            {
                apartmentsGrid.DataSource = value;
            }
        }
        public List<Floor> FloorsDataSource
        {
            get
            {
                return floorView.DataSource as List<Floor>;
            }
            set
            {
                floorEdit.Properties.DataSource = value;
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

        public Floor CurrentFloor
        {
            get
            {
                return floorEdit.EditValue as Floor;
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