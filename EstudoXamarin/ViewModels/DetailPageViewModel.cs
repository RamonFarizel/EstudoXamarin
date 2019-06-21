using System;
using System.Collections.Generic;
using EstudoXamarin.ViewModels.Base;
using Prism.Navigation;
using Prism.Services;

namespace EstudoXamarin.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        private List<string> _lista;
        public List<string> Lista
        {
            get => _lista;
            set { SetProperty(ref _lista, value); }
        }

        protected DetailPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            Lista = new List<string>
            {
                "1",
                "2",
                "3",
                "4"
            };
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
