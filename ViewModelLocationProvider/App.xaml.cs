using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;
using ViewModelLocationProvider.ViewModel;
using Prism.Mvvm;

namespace ViewModelLocationProvider
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve(typeof(MainWindow)) as MainWindow;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            // type / type
            //ViewModelLocationProvider.Register(typeof(MainWindow).ToString(), typeof(CustomViewModel));

            // type / factory
            //ViewModelLocationProvider.Register(typeof(MainWindow).ToString(), () => Container.Resolve<CustomViewModel>());

            // generic factory
            //ViewModelLocationProvider.Register<MainWindow>(() => Container.Resolve<CustomViewModel>());

            // generic type<MainWindow, CustomViewModel>
         Prism.Mvvm.ViewModelLocationProvider.Register<MainWindow, CustomViewModel>();
            //ViewModelLocationProvider.Register(typeof(MainWindow),typeof(CustomViewModel));
        }
    }
}
