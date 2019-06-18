using System;
using EstudoXamarin.ViewModels.Base;
using Prism.Navigation;
using Prism.Services;

namespace EstudoXamarin.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        protected DetailPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
        }

    }
}
