using MvvmCross.Droid.Views.Attributes;
using Tabs.Core.ViewModels;

namespace Tabs.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    public class ThirdFragment : BaseFragment<ThirdViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_third;
    }
}