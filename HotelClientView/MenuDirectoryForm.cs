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
    public partial class MenuDirectoryForm: DevExpress.XtraEditors.XtraForm, IMenuDirectoryView
    {
        private readonly ApplicationContext _context;
        public MenuDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.Load += (sender, args) => Invoke(LoadMenu);
            deleteButton.Click += (sender, args) => Invoke(DeleteDish);
            addButton.Click += (sender, args) => Invoke(AddDish);
            dishesGridView.CellValueChanged += (sender, args) => Invoke(UpdateDish);
        }


        public event Action AddDish;
        public event Action DeleteDish;
        public event Action UpdateDish;
        public event Action LoadMenu;

        bool IMenuDirectoryView.AdminControls
        {
            set
            {
                addButton.Enabled = value;
                deleteButton.Enabled = value;
                dishesGridView.OptionsBehavior.ReadOnly = !value;
            }
        }

        public HotelClientModel.Menu CurrentDish
        {
            get 
            {
                return dishesGridView.GetRow(dishesGridView.FocusedRowHandle) as HotelClientModel.Menu;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return dishesGridView.RowCount; 
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

        public List<HotelClientModel.Menu> MenuDataSource
        {
            get
            {
                return dishesGrid.DataSource as List<HotelClientModel.Menu>;
            }
            set
            {
                dishesGrid.DataSource = value;
            }
        }

        public string RestaurantName
        {
            get
            {
                return restaurantEdit.Text;
            }
            set
            {
                restaurantEdit.Text = value;
            }
        }

        public string DishName
        {
            get
            {
                return dishNameEdit.Text;
            }
            set
            {
                dishNameEdit.Text = value;
            }
        }

        public float DishPrice
        {
            get
            {
                return (float)priceEdit.Value;
            }
            set
            {
                priceEdit.Value = (decimal)value;
            }
        }
    }
}