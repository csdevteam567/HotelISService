using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using HotelClientPresentation;
using HotelClientModel;

namespace HotelClientView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<ILoginView, LoginWindow>()
                .RegisterView<IMainView, MainForm>()
                .RegisterView<ICountryDirectoryView, CountryDirectoryForm>()
                .RegisterView<ICityDirectoryView, CityDirectoryForm>()
                .RegisterView<IHotelDirectoryView, HotelDirectoryForm>()
                .RegisterView<IFloorDirectoryView, FloorDirectoryForm>()
                .RegisterView<IRestaurantDirectoryView, RestaurantDirectoryForm>()
                .RegisterView<IMenuDirectoryView, MenuDirectoryForm>()
                .RegisterView<IApartmentDirectoryView, ApartmentDirectoryForm>()
                .RegisterView<IUserDirectoryView, UserDirectoryForm>()
                .RegisterView<IGuestDirectoryView, GuestDirectoryForm>()
                .RegisterView<IOrderDirectoryView, OrderDirectoryForm>()
                .RegisterView<IOrderedApartmentDirectoryView, OrderedApartmentDirectoryForm>()
                .RegisterView<IPaycheckDirectoryView, PaycheckDirectoryForm>()
                .RegisterView<IStatusView, StatusForm>()
                .RegisterView<IChildParentDirectoryView, ChildParentRelationsForm>()
                .RegisterService<ILoginService, LoginService>()
                .RegisterService<ICountryDataService, CountryDataService>()
                .RegisterService<ICityDataService, CityDataService>()
                .RegisterService<IHotelDataService, HotelDataService>()
                .RegisterService<IFloorDataService, FloorDataService>()
                .RegisterService<IRestaurantDataService, RestaurantDataService>()
                .RegisterService<IMenuDataService, MenuDataService>()
                .RegisterService<IApartmentDataService, ApartmentDataService>()
                .RegisterService<IUserDataService, UserDataService>()
                .RegisterService<IGuestDataService, GuestDataService>()
                .RegisterService<IOrderDataService, OrderDataService>()
                .RegisterService<IOrderedApartmentDataService, OrderedApartmentDataService>()
                .RegisterService<IParentChildDataService, ParentChildDataService>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<LoginPresenter>();
        }
    }
}
