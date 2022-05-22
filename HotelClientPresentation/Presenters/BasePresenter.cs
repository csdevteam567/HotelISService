using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelClientPresentation
{
    public abstract class BasePresener<TView> : IPresenter
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresener(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public void Run()
        {
            View.Show();
        }
    }

    public abstract class BasePresener<TView, TArg> : IPresenter<TArg>
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresener(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg argument);
    }

    public abstract class BasePresener<TView, TArg1, TArg2> : IPresenter<TArg1, TArg2>
    where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresener(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg1 argument1, TArg2 argument2);
    }
}
