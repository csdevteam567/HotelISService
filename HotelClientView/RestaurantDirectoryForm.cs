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
    public partial class RestaurantDirectoryForm: DevExpress.XtraEditors.XtraForm, IRestaurantDirectoryView
    {
        private readonly ApplicationContext _context;
        public RestaurantDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.Load += (sender, args) => Invoke(LoadRestaurants);
            deleteButton.Click += (sender, args) => Invoke(DeleteRestaurant);
            addButton.Click += (sender, args) => Invoke(AddRestaurant);
            restaurantGridView.CellValueChanged += (sender, args) => Invoke(UpdateRestaurant);
            addDishes.Click += (sender, args) => Invoke(EditMenu);
        }


        public event Action AddRestaurant;
        public event Action DeleteRestaurant;
        public event Action UpdateRestaurant;
        public event Action LoadRestaurants;
        public event Action EditMenu;


        bool IRestaurantDirectoryView.AdminControls
        {
            set
            {
                addButton.Enabled = value;
                deleteButton.Enabled = value;
                restaurantGridView.OptionsBehavior.ReadOnly = !value;
            }
        }

        public Restaurant CurrentRestaurant
        {
            get
            {
                return restaurantGridView.GetRow(restaurantGridView.FocusedRowHandle) as Restaurant;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return restaurantGridView.RowCount; 
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

        public List<Restaurant> RestaurantsDataSource
        {
            get
            {
                return restaurantGrid.DataSource as List<Restaurant>;
            }
            set
            {
                restaurantGrid.DataSource = value;
            }
        }

        public string RestaurantName
        {
            get
            {
                return restaurantNameEdit.Text;
            }
            set
            {
                restaurantNameEdit.Text = value;
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
    }
}