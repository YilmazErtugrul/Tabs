using System;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Tabs.Core.ViewModels;

namespace Tabs.iOS.Views
{
    [MvxRootPresentation]
    public class MainView : MvxTabBarViewController<MainContainerViewModel>
    {
        private bool _firstTimePresented = true;

        public MainView()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (_firstTimePresented)
            {
                _firstTimePresented = false;
                ViewModel.NavigateToFirstViewCommand.Execute(null);
                ViewModel.NavigateToSecondViewCommand.Execute(null);
                ViewModel.NavigateToThirdViewCommand.Execute(null);
            }
        }
    }
}
