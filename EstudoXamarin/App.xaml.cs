using System;
using System.Threading.Tasks;
using EstudoXamarin.Controls;
using EstudoXamarin.Enums;
using EstudoXamarin.ViewModels;
using EstudoXamarin.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoXamarin
{
    public partial class App : PrismApplication
    {
        public static TiposDeTransicaoEnum TipoAnimacao = TiposDeTransicaoEnum.Default;

        public App(): this(null) { }

        public App(IPlatformInitializer iplataformaInitializer) : base(iplataformaInitializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

#if DEBUG
            HotReloader.Current.Run(this);
#endif

            await InitalizeNavigation();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>("Go");
            containerRegistry.RegisterForNavigation<TransitionNavigationPage>("Go2");

            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<DetailPage>();
            containerRegistry.RegisterForNavigation<Pagina1>();
            containerRegistry.RegisterForNavigation<Pagina2>();
        }

        private Task InitalizeNavigation() => NavigationService.NavigateAsync("Go2/MainPage");


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
