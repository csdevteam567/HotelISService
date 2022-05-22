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
    public partial class PaycheckDirectoryForm: DevExpress.XtraEditors.XtraForm, IPaycheckDirectoryView
    {
        private readonly ApplicationContext _context;
        public PaycheckDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.Load += (sender, args) => Invoke(LoadPaycheck);
        }


        public event Action LoadPaycheck;

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

        public List<DishInfo> DishesDataSource
        {
            set
            {
                dishesGrid.DataSource = value;
            }
        }

        public List<ApartmentPaycheck> ApartmentsDataSource
        {
            set
            {
                apartmentsGrid.DataSource = value;
            }
        }

        public string HotelName
        {
            set
            {
                hotelNameView.Text = value;
            }
        }

        public string CountryName
        {
            set
            {
                countryNameView.Text = value;
            }
        }

        public string CityName
        {
            set
            {
                cityNameView.Text = value;
            }
        }


        public double TotalPrice
        {
            set
            {
                totalPriceView.Text = value.ToString("0.00");
            }
        }
    }
}