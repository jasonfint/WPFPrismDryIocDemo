
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using RMLModuleA;
using System.Windows;


namespace RegionMemberLifetime
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
            moduleCatalog.AddModule<RMLModuleAModule>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }


    }
}
