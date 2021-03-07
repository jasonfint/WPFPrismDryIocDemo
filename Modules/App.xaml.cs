using DryIoc;
using ModuleA;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using System;

namespace Modules
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
        /* 以下几个任选一个，效果一样 */

        ///// <summary>
        ///// 07-Modules - Code
        ///// </summary>
        ///// <param name="moduleCatalog"></param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //直接
            moduleCatalog.AddModule<ModuleA.ModuleAModule>();
        }

        ///// <summary>
        ///// 07-Modules - AppConfig
        ///// </summary>
        ///// <param name="moduleCatalog"></param>
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    ModuleCatalog catalog = new ModuleCatalog();
        //    catalog.AddModule(typeof(ModuleAModule));
        //    return catalog;
        //}

        /// <summary>
        /// 07-Modules - Directory 指向 ModuleA.dll地址
        /// </summary>
        /// <param name="moduleCatalog"></param>
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new DirectoryModuleCatalog() { ModulePath = @"C:\Users\80493\source\repos\WPFPrismDryIocDemo\Modules\bin\Debug" };
        //}

        /// <summary>
        /// 07-Modules - LoadManual -未调通，暂时不生效
        /// </summary>
        /// <param name="moduleCatalog"></param>
        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{       

        //    //将MedicineModule模块设置为按需加载
        //    //反射获取模块信息
        //    var moduleAType = typeof(ModuleAModule);
        //    //设置为按需加载
        //    moduleCatalog.AddModule(new ModuleInfo()
        //    {       //模块名
        //        ModuleName = moduleAType.Name,
        //        //模块类型
        //        ModuleType = moduleAType.AssemblyQualifiedName,
        //        //按需加载		初始化模式=按需
        //        InitializationMode = InitializationMode.OnDemand
        //    });

        //}



        /// <summary>
        /// 07-Modules - XMAL -未调通，暂时不生效
        /// </summary>
        /// <param name="moduleCatalog"></param>
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new XamlModuleCatalog(new Uri("/Modules;component/ModuleCatalog.xaml", UriKind.Relative));
        //}
    }
}
