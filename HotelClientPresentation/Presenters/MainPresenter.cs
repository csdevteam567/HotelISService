using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelClientModel;

namespace HotelClientPresentation
{
    public class MainPresener : BasePresener<IMainView, LoginResult>
    {
        private LoginResult _user;

        public MainPresener(IApplicationController controller, IMainView view)
            : base(controller, view)
        {
            View.OpenCountriesDirectory += OpenCountriesDirectory;
            View.OpenCitiesDirectory += OpenCitiesDirectory;
            View.OpenHotelsDirectory += OpenHotelsDirectory;
            View.OpenUsersDirectory += OpenUsersDirectory;
            View.OpenGuestsDirectory += OpenGuestsDirectory;
            View.CloseWindow += CloseMainWindow;
            View.OpenOrdersDirectory += OpenOrdersDirectory;
            View.OpenStatusForm += OpenStatusForm;
        }

        public override void Run(LoginResult argument)
        {
            _user = argument;
            View.Show();
        }

        private void OpenCountriesDirectory()
        {
            Controller.Run<CountryDirectoryPresenter, LoginResult>(_user);
        }

        private void OpenUsersDirectory()
        {
            Controller.Run<UserDirectoryPresenter, LoginResult>(_user);
        }

        private void OpenCitiesDirectory()
        {
            Controller.Run<CityDirectoryPresenter, LoginResult>(_user);
        }

        private void OpenHotelsDirectory()
        {
            Controller.Run<HotelDirectoryPresenter, LoginResult>(_user);
        }

        private void OpenGuestsDirectory()
        {
            Controller.Run<GuestDirectoryPresenter>();
        }

        private void OpenOrdersDirectory()
        {
            Controller.Run<OrderDirectoryPresenter, LoginResult>(_user);
        }

        private void OpenStatusForm()
        {
            Controller.Run<StatusPresenter>();
        }

        private void CloseMainWindow()
        {
            View.Close();
        }
    }
}
