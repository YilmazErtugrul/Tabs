using Foundation;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using System;
using Tabs.Core.ViewModels;
using UIKit;

namespace Tabs.iOS
{
    [MvxTabPresentation(WrapInNavigationController = true, TabName = "Search", TabIconName = "search")]
    public partial class SecondView : MvxViewController<SecondViewModel>
    {
        public SecondView (IntPtr handle) : base (handle)
        {
        }

        public SecondView()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Search";
        }
    }
}