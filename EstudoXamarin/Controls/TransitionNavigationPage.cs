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

        public TransitionNavigationPage() : base()
        {
        }

        public TransitionNavigationPage(Page root) : base(root)
        {
           
        }
        
    }
}
