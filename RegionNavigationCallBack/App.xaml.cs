using BRNModuleA;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using System.Windows;
using System.Windows.Controls;

namespace BasicRegionNavigation
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

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<BRNModuleAModule>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }


    }
}
