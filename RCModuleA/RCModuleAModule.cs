using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCModuleA
{
    public class RCModuleAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(PersonList));
            regionManager.RegisterViewWithRegion("PersonDetailsRegion", typeof(PersonDetail));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
