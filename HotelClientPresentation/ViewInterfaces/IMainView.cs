using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelClientPresentation
{
    public interface IMainView : IView
    {
        event Action OpenHotelsDirectory;
        event Action OpenCountriesDirectory;
        event Action OpenCitiesDirectory;
        event Action OpenUsersDirectory;
        event Action OpenOrdersDirectory;
        event Action CloseWindow;
        event Action OpenGuestsDirectory;
        event Action OpenStatusForm;
    }
}
