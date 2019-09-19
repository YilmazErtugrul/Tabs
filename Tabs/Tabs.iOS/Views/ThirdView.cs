using Foundation;
using MvvmCross.iOS.Views;
using System;
using Tabs.Core.ViewModels;
using UIKit;

namespace Tabs.iOS
{
    public partial class ThirdView : MvxViewController<ThirdViewModel>
    {
        public ThirdView (IntPtr handle) : base (handle)
        {
        }

        public ThirdView()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Settings";
        }
    }
}