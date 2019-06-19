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

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            //if (parameters.ContainsKey("Teste"))
               // var resultado = parameters.GetValue<string>("Teste");

            var resultado = parameters["Teste"] as string;

        }

    }
}
