using System;
using System.Threading.Tasks;
using EstudoXamarin.Enums;
using EstudoXamarin.Extentions;
using EstudoXamarin.ViewModels.Base;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

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

        private DelegateCommand<string> _navegar;
        public DelegateCommand<string> Navegar =>
        _navegar ?? (_navegar = new DelegateCommand<string>(async (parametro) => await ExecuteNavegar(parametro),CanExecuteMethod => false));

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) 
            : base(navigationService, pageDialogService)
        {
            Nome = "Ramon";
            Senha = "123";
        }

        //private bool CanExecuteMethod(string arg)
        //{
        //    if (string.IsNullOrEmpty(Nome) && string.IsNullOrEmpty(Senha))
        //        return false;

        //    return true;
        //}


        private async Task ExecuteNavegar(string parametro)
        {
            var navParameters = new NavigationParameters()
            {
                {"Nome", Nome},
                {"Senha",Senha}
            };

            await NavigationService.NavigateAsync($"{parametro}", TiposDeTransicaoEnum.SlideFromRight,navParameters);
        }
    }
}
