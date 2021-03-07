using Prism.Mvvm;
using Prism.Regions;

namespace RMLModuleA
{
    public class ViewBViewModel : BindableBase, INavigationAware
    {
        public ViewBViewModel()
        {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }
    }
}
