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
    public partial class CountryDirectoryForm : DevExpress.XtraEditors.XtraForm, ICountryDirectoryView
    {
        private readonly ApplicationContext _context;
        public CountryDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            refreshButton.Click += (sender, args) => Invoke(LoadCountries);
            this.Load += (sender, args) => Invoke(LoadCountries);
            deleteButton.Click += (sender, args) => Invoke(DeleteCountry);
            addButton.Click += (sender, args) => Invoke(AddCountry);
            countryGridView.CellValueChanged += (sender, args) => Invoke(UpdateCountry);
        }

        bool ICountryDirectoryView.AdminControls
        {
            set
            {
                addButton.Enabled = value;
                deleteButton.Enabled = value;
                countryGridView.OptionsBehavior.ReadOnly = !value;
            }
        }

        public List<Country> CountriesDataSource
        {
            get
            {
                return countryGridControl.DataSource as List<Country>;
            }
            set
            {
                countryGridControl.DataSource = value;
            }
        }

        public Country CurrentCountry
        {
            get 
            { 
                return countryGridView.GetRow(countryGridView.FocusedRowHandle) as Country;
            }
        }

        public string CountryName
        {
            get
            {
                return countryEdit.Text;
            }
            set
            {
                countryEdit.Text = value;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return countryGridView.RowCount; 
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

        public event Action AddCountry;
        public event Action DeleteCountry;
        public event Action LoadCountries;
        public event Action UpdateCountry;

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
    }
}