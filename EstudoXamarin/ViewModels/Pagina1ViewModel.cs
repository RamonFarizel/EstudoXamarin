using System;
using EstudoXamarin.ViewModels.Base;
using Prism.Navigation;
using Prism.Services;

namespace EstudoXamarin.ViewModels
{
    public class Pagina1ViewModel : BaseViewModel
    {

        public Pagina1ViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {

        }
    }
}
