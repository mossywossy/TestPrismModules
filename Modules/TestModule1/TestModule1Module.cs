using Prism.Ioc;
using Prism.Modularity;
using TestModule1.Views;
using TestModule1.ViewModels;
using Prism.Regions;

namespace TestModule1
{
    public class TestModule1Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterRegionServices();
            containerRegistry.RegisterForRegionNavigation<ViewA, ViewAViewModel>();
        }
    }
}
