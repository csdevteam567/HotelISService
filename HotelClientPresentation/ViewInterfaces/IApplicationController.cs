using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelClientPresentation
{
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        IApplicationController RegisterInstance<TArgument>(TArgument instance);

        IApplicationController RegisterService<TService, TImplementation>()
            where TImplementation : class, TService;

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        void Run<TPresenter, TArgumnent>(TArgumnent argumnent)
            where TPresenter : class, IPresenter<TArgumnent>;

        void Run<TPresenter, TArgumnent1, TArgument2>(TArgumnent1 argumnent1, TArgument2 argument2)
            where TPresenter : class, IPresenter<TArgumnent1, TArgument2>;
    }
}
