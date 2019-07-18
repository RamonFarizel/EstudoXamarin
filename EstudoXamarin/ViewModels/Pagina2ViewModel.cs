using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EstudoXamarin.Enums;
using EstudoXamarin.Extentions;
using EstudoXamarin.Models;
using EstudoXamarin.ViewModels.Base;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace EstudoXamarin.ViewModels
{
    public class Pagina2ViewModel : BaseViewModel
    {
        private DelegateCommand _navegar;
        public DelegateCommand Navegar =>
        _navegar ?? (_navegar = new DelegateCommand(async() => await ExecuteNavegar()));


        private IList<Clientes> _listaClientes; 
        public IList<Clientes> ListaClientes
        {
            get => _listaClientes;
            set { SetProperty(ref _listaClientes, value); }
        }

        public Pagina2ViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            ListaClientes = new List<Clientes>();
            ListaClientes.Add(new Clientes
            {
                Nome = "Ramon Farizel",
                Ficha ="12345678",
                TipoFicha ="Ortodontia",
                UrlAvatar = "https://secure.webtoolhub.com/static/resources/icons/set112/ff723a02.png"
            });
            ListaClientes.Add(new Clientes
            {
                Nome = "Mariana Moncores",
                Ficha = "12345678",
                TipoFicha = "Reabilitação",
                UrlAvatar = "https://secure.webtoolhub.com/static/resources/icons/set112/ff723a02.png"
            });
            ListaClientes.Add(new Clientes
            {
                Nome = "Sandro Farizel",
                Ficha = "987654321",
                TipoFicha = "Clínica",
                UrlAvatar = "https://secure.webtoolhub.com/static/resources/icons/set112/ff723a02.png"
            });
        }

        private async Task ExecuteNavegar()
        {
            await NavigationService.NavigateAsync("Pagina1", TiposDeTransicaoEnum.Default);
        }
    }
}
