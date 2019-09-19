using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace Tabs.Core.ViewModels
{
    public class MainContainerViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainContainerViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand NavigateToFirstViewCommand => new MvxAsyncCommand(async () => await _navigationService.Navigate<FirstViewModel>());
        public IMvxAsyncCommand NavigateToSecondViewCommand => new MvxAsyncCommand(async () => await _navigationService.Navigate<SecondViewModel>());
        public IMvxAsyncCommand NavigateToThirdViewCommand => new MvxAsyncCommand(async () => await _navigationService.Navigate<ThirdViewModel>());

    }
}
