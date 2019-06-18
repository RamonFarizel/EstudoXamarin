using System;
using System.Threading.Tasks;
using EstudoXamarin.Enums;
using EstudoXamarin.ViewModels.Base;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace EstudoXamarin.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private DelegateCommand _navegar;
        public DelegateCommand Navegar =>
        _navegar ?? (_navegar = new DelegateCommand(async () => await ExecuteNavegar()));


        protected MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) 
            : base(navigationService, pageDialogService)
        {

        }

        private async Task ExecuteNavegar()
        {
             await NavigationService.NavigateAsync("Go2/DetailPage");
        }
    }
}
