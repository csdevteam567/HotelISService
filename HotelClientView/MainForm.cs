using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelClientPresentation;

namespace HotelClientView
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm, IMainView
    {
        private readonly ApplicationContext _context;
        public MainForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            countryDirectoryToolStripMenuItem.Click += (sender, args) => Invoke(OpenCountriesDirectory);
            cityDirectoryToolStripMenuItem.Click += (sender, args) => Invoke(OpenCitiesDirectory);
            hotelDirectoryToolStripMenuItem.Click += (sender, args) => Invoke(OpenHotelsDirectory);
            userDirectoryToolStripMenuItem.Click += (sender, args) => Invoke(OpenUsersDirectory);
            closeToolStripMenuItem.Click += (sender, args) => Invoke(CloseWindow);
            guestDirectoryToolStripMenuItem.Click += (sender, args) => Invoke(OpenGuestsDirectory);
            createOrderToolStripMenuItem.Click += (sender, args) => Invoke(OpenOrdersDirectory);
            checkHotelStatusToolStripMenuItem.Click += (sender, args) => Invoke(OpenStatusForm);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public event Action OpenCountriesDirectory;
        public event Action OpenCitiesDirectory;
        public event Action OpenHotelsDirectory;
        public event Action OpenUsersDirectory;
        public event Action OpenOrdersDirectory;
        public event Action CloseWindow;
        public event Action OpenGuestsDirectory;
        public event Action OpenStatusForm;

        private void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }
    }
}
