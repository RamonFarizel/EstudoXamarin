using System.Threading.Tasks;
using EstudoXamarin.Enums;
using EstudoXamarin.Extentions;
using EstudoXamarin.Services;
using EstudoXamarin.ViewModels.Base;
using Plugin.Permissions;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Plugin.Permissions.Abstractions;
using System;

namespace EstudoXamarin.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _nome = string.Empty;
        public string Nome
        {
            get => _nome;
            set { SetProperty(ref _nome, value); }
        }

        private string _senha = string.Empty;
        public string Senha
        {
            get => _senha;
            set { SetProperty(ref _senha, value); }
        }

        //public string Telefone => _deviceInfo.GetPhoneNumber();

        private DelegateCommand<string> _navegar;
        public DelegateCommand<string> Navegar =>
        _navegar ?? (_navegar = new DelegateCommand<string>(async (parametro) => await ExecuteNavegar(parametro),CanExecuteMethod => false));

        private IDeviceInfo _deviceInfo;

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IDeviceInfo deviceInfo) 
            : base(navigationService, pageDialogService)
        {
            Nome = "Ramon";
            Senha = "123";

            //_deviceInfo = deviceInfo;
            
        }

        private async Task ExecuteNavegar(string parametro)
        {
            //var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Phone });

            //var teste = _deviceInfo.GetPhoneNumber();
            //await PageDialogService.DisplayAlertAsync("FDP", $"Seu numero é: {teste}", "OK");
            //var navParameters = new NavigationParameters()
            //{
            //    {"Nome", Nome},
            //    {"Senha",Senha}
            //};

            //await NavigationService.NavigateAsync($"{parametro}", TiposDeTransicaoEnum.SlideFromRight, navParameters);
        }
    }
}
