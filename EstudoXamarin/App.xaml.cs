using System;
using System.Threading.Tasks;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoXamarin
{
    public partial class App : PrismApplication
    {
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
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<MainPage>();
        }

        private Task InitalizeNavigation() => NavigationService.NavigateAsync("MainPage");


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
