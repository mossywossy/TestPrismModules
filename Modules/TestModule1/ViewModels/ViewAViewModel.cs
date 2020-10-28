using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestModule1.ViewModels
{
    public class ViewAViewModel : BindableBase, IRegionAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        private string moduleTitleLabelText;
        public string ModuleTitleLabelText
        {
            get { return moduleTitleLabelText; }
            set { SetProperty(ref moduleTitleLabelText, value); }
        }


        public ViewAViewModel()
        {
            Title = "View A";
            ModuleTitleLabelText = "This is my test module View A Content";
        }

        public void OnNavigatedTo(INavigationContext navigationContext)
        {
            
        }

        public bool IsNavigationTarget(INavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(INavigationContext navigationContext)
        {
            
        }
    }
}
