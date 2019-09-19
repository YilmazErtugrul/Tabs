using System;
using System.Windows.Input;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using MvvmCross.Binding.BindingContext;
using Tabs.Core.ViewModels;

namespace Tabs.Droid.Views
{
    [Activity(WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    public class MainContainerActivity : BaseActivity<MainContainerViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.activity_main_container;

        BottomNavigationView bottomNavigation;

        public ICommand GoToFirstViewCommand { get; set; }
        public ICommand GoToThirdViewCommand { get; set; }
        public ICommand GoToSecondViewCommand { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            AddBottomNavigation();
        }

        private void AddBottomNavigation()
        {
            bottomNavigation = (BottomNavigationView)FindViewById(Resource.Id.bottom_navigation);
            if (bottomNavigation != null)
            {
                bottomNavigation.NavigationItemSelected += BottomNavigation_NavigationItemSelected;
                var set = this.CreateBindingSet<MainContainerActivity, MainContainerViewModel>();
                set.Bind(this).For(v => v.GoToFirstViewCommand).To(vm => vm.NavigateToFirstViewCommand);
                set.Bind(this).For(v => v.GoToSecondViewCommand).To(vm => vm.NavigateToSecondViewCommand);
                set.Bind(this).For(v => v.GoToThirdViewCommand).To(vm => vm.NavigateToThirdViewCommand);
                set.Apply();
            }
        }

        private void BottomNavigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            try
            {
                if (e.Item.ItemId == Resource.Id.menu_first)
                    if (GoToFirstViewCommand != null && GoToFirstViewCommand.CanExecute(null))
                        GoToFirstViewCommand.Execute(null);
                if (e.Item.ItemId == Resource.Id.menu_second)
                    if (GoToSecondViewCommand != null && GoToSecondViewCommand.CanExecute(null))
                        GoToSecondViewCommand.Execute(null);
                if (e.Item.ItemId == Resource.Id.menu_third)
                    if (GoToThirdViewCommand != null && GoToThirdViewCommand.CanExecute(null))
                        GoToThirdViewCommand.Execute(null);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine($"Exception: {exception.Message}");
            }
        }
    }
}
