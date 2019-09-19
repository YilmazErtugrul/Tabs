using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Tabs.Core.ViewModels;

namespace Tabs.iOS.Views
{
    [MvxTabPresentation(WrapInNavigationController = true, TabName = "Menu", TabIconName = "menu")]
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public FirstView()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Menu";
        }
    }
}
