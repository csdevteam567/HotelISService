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
    public partial class CityDirectoryForm : DevExpress.XtraEditors.XtraForm, ICityDirectoryView
    {
        private readonly ApplicationContext _context;
        public CityDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            deleteButton.Click += (sender, args) => Invoke(DeleteCity);
            addButton.Click += (sender, args) => Invoke(AddCity);
            cityGridView.CellValueChanged += (sender, args) => Invoke(UpdateCity);
            this.Load += (sender, args) => Invoke(LoadCountries);
            this.countrySearchEdit.EditValueChanged += (sender, args) => Invoke(LoadCities);
            this.openCountriesDirectory.Click += (sender, args) => Invoke(OpenCountriesDirectory);
        }

        public bool AdminControls
        {
            set
            {
                addButton.Enabled = value;
                deleteButton.Enabled = value;
                cityGridView.OptionsBehavior.ReadOnly = !value;
            }
        }

        public City CurrentCity
        {
            get 
            {
                return cityGridView.GetRow(cityGridView.FocusedRowHandle) as City;
            }
        }

        public string CityName
        {
            get
            {
                return cityEdit.Text;
            }
            set
            {
                cityEdit.Text = value;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return cityGridView.RowCount; 
            }
        }

        public new void Show()
        {
            this.MdiParent = _context.MainForm;
            if (!base.Visible)
            {
                base.Show();
            }
        }

        public event Action AddCity;
        public event Action DeleteCity;
        public event Action LoadCities;
        public event Action LoadCountries;
        public event Action UpdateCity;
        public event Action OpenCountriesDirectory;

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

        public List<City> CitiesDataSource
        {
            get
            {
                return cityGridControl.DataSource as List<City>;
            }
            set
            {
                cityGridControl.DataSource = value;
            }
        }

        public List<Country> CountriesDataSource
        {
            get
            {
                return countrySearchView.DataSource as List<Country>;
            }
            set
            {
                countrySearchEdit.Properties.DataSource = value;
            }
        }

        public Country CurrentCountry
        {
            get
            {
                return countrySearchEdit.EditValue as Country;
            }
        }
    }
}