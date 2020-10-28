using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrismModules.ViewModels
{
    public class MainPageViewModel : ViewModelBase, INavigatedAware
    {
        private IRegionManager _regionManager;

        public MainPageViewModel(INavigationService navigationService, IRegionManager regionManager)
            : base(navigationService)
        {
            _regionManager = regionManager;
            Title = "Main Page";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            // In WPF I would have been used to RegisterViewWithRegion but seeing as that method doesn't seem to be available 
            // in Prism.Forms, this was my work-around i.e. to call RequestNavigate to the Module's View upon Navigating to the 
            // Page that hosts the Region.

            _regionManager.RequestNavigate("FlexRegion", "ViewA");
        }
    }
}
