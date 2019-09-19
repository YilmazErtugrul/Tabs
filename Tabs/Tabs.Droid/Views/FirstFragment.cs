using MvvmCross.Droid.Views.Attributes;
using Tabs.Core.ViewModels;

namespace Tabs.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    public class FirstFragment : BaseFragment<FirstViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_first;
    }
}