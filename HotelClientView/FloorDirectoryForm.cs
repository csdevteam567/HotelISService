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
    public partial class FloorDirectoryForm: DevExpress.XtraEditors.XtraForm, IFloorDirectoryView
    {
        private readonly ApplicationContext _context;
        public FloorDirectoryForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.Load += (sender, args) => Invoke(LoadFloors);
            deleteButton.Click += (sender, args) => Invoke(DeleteFloor);
            addButton.Click += (sender, args) => Invoke(AddFloor);
            addApartment.Click += (sender, args) => Invoke(AddApartments);
            floorsGridView.CellValueChanged += (sender, args) => Invoke(UpdateFloor);
        }

        public event Action AddFloor;
        public event Action DeleteFloor;
        public event Action UpdateFloor;
        public event Action LoadFloors;
        public event Action AddApartments;


        bool IFloorDirectoryView.AdminControls
        {
            set
            {
                addButton.Enabled = value;
                deleteButton.Enabled = value;
                floorsGridView.OptionsBehavior.ReadOnly = !value;
            }
        }

        public Floor CurrentFloor
        {
            get
            {
                return floorsGridView.GetRow(floorsGridView.FocusedRowHandle) as Floor;
            }
        }

        public int TableRowCount
        {
            get 
            { 
                return floorsGridView.RowCount; 
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

        public List<Floor> FloorsDataSource
        {
            get
            {
                return floorsGrid.DataSource as List<Floor>;
            }
            set
            {
                floorsGrid.DataSource = value;
            }
        }

        public int MaxApartmentsCount
        {
            get
            {
                return (int)maxApartmentsEdit.Value;
            }
            set
            {
                maxApartmentsEdit.Value = value;
            }
        }

        public int FloorNumber
        {
            get
            {
                return (int)floorNumberEdit.Value;
            }
            set
            {
                floorNumberEdit.Value = value;
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