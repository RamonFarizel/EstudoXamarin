using System;
using EstudoXamarin.Enums;
using Xamarin.Forms;

namespace EstudoXamarin.Controls
{
    public class TransitionNavigationPage : NavigationPage
    {
        public static readonly BindableProperty TransitionTypeProperty =
             BindableProperty.Create("TransitionType", typeof(TiposDeTransicaoEnum), typeof(TransitionNavigationPage), TiposDeTransicaoEnum.SlideFromLeft);

        public TiposDeTransicaoEnum TransitionType
        {
            get { return (TiposDeTransicaoEnum)GetValue(TransitionTypeProperty); }
            set { SetValue(TransitionTypeProperty, value); }
        }

        public TransitionNavigationPage() 
        {
            SetStyle();
        }

        public TransitionNavigationPage(Page root) : base(root)
        {
            SetStyle();
        }

        void SetStyle()
        {
            BarBackgroundColor = Color.FromHex("#1A1917");
            BarTextColor = Color.White;


        }


    }
}
