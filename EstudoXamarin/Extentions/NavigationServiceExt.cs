using System;
using System.Threading.Tasks;
using EstudoXamarin.Controls;
using EstudoXamarin.Enums;
using Prism.Navigation;

namespace EstudoXamarin.Extentions
{
    public static class NavigationServiceExt
    {
        public static Task NavigateAsync(this INavigationService navigationService,
                                         string name,
                                         TiposDeTransicaoEnum transitionType = TiposDeTransicaoEnum.Default,
                                         NavigationParameters parameters = null,
                                         bool? useModalNavigation = null,
                                         bool animated = true)
        {
            (App.Current.MainPage as TransitionNavigationPage).TransitionType = transitionType;
            return navigationService.NavigateAsync(name, parameters, useModalNavigation, animated);
        }
        public static Task NavigateAsync(this INavigationService navigationService, Uri uri, TiposDeTransicaoEnum transitionType = TiposDeTransicaoEnum.Default, NavigationParameters parameters = null, bool? useModalNavigation = null, bool animated = true)
        {
            (App.Current.MainPage as TransitionNavigationPage).TransitionType = transitionType;
            return navigationService.NavigateAsync(uri, parameters, useModalNavigation, animated);
        }
    }
}
