using System.ComponentModel;
using EstudoXamarin.Controls;
using EstudoXamarin.Droid.Renderers;
using EstudoXamarin.Enums;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TransitionNavigationPage), typeof(TransitionNavigationPageRenderer))]
namespace EstudoXamarin.Droid.Renderers
{

    public class TransitionNavigationPageRenderer : NavigationPageRenderer
    {
        private TiposDeTransicaoEnum _TiposDeTransicaoEnum = TiposDeTransicaoEnum.Default;

        public TransitionNavigationPageRenderer(Android.Content.Context context) : base(context)
        {
            
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == Controls.TransitionNavigationPage.TransitionTypeProperty.PropertyName)
                UpdateTransitionType();
        }
       

        protected override void SetupPageTransition(Android.Support.V4.App.FragmentTransaction transaction, bool isPush)
        {
            switch (_TiposDeTransicaoEnum)
            {
                case TiposDeTransicaoEnum.None:
                    return;
                case TiposDeTransicaoEnum.Default:
                    return;
                case TiposDeTransicaoEnum.Fade:
                    transaction.SetCustomAnimations(Resource.Animation.abc_fade_in, Resource.Animation.abc_fade_out,
                                                    Resource.Animation.abc_fade_out, Resource.Animation.abc_fade_in);
                    break;
                case TiposDeTransicaoEnum.Flip:
                    transaction.SetCustomAnimations(Resource.Animation.tooltip_enter, Resource.Animation.tooltip_exit,
                                                    Resource.Animation.tooltip_exit, Resource.Animation.tooltip_enter);
                    break;
                case TiposDeTransicaoEnum.Scale:
                    transaction.SetCustomAnimations(Resource.Animation.design_bottom_sheet_slide_in, Resource.Animation.design_bottom_sheet_slide_out,
                                                    Resource.Animation.design_bottom_sheet_slide_out, Resource.Animation.design_bottom_sheet_slide_in);
                    break;
                case TiposDeTransicaoEnum.SlideFromLeft:
                    if (isPush)
                    {
                        transaction.SetCustomAnimations(Resource.Animation.EnterFromLeft, Resource.Animation.ExitToRight,
                                                        Resource.Animation.EnterFromRight, Resource.Animation.ExitToLeft);
                    }
                    else
                    {
                        transaction.SetCustomAnimations(Resource.Animation.EnterFromRight, Resource.Animation.ExitToLeft,
                                                        Resource.Animation.EnterFromLeft, Resource.Animation.ExitToRight);
                    }
                    break;
                case TiposDeTransicaoEnum.SlideFromRight:
                    if (isPush)
                    {
                        transaction.SetCustomAnimations(Resource.Animation.EnterFromRight, Resource.Animation.ExitToLeft,
                                                        Resource.Animation.EnterFromLeft, Resource.Animation.ExitToRight);
                    }
                    else
                    {
                        transaction.SetCustomAnimations(Resource.Animation.EnterFromLeft, Resource.Animation.ExitToRight,
                                                        Resource.Animation.EnterFromRight, Resource.Animation.ExitToLeft);
                    }
                    break;
                case TiposDeTransicaoEnum.SlideFromTop:
                    if (isPush)
                    {
                        transaction.SetCustomAnimations(Resource.Animation.abc_slide_in_top, Resource.Animation.abc_slide_out_bottom,
                                                        Resource.Animation.abc_slide_in_bottom, Resource.Animation.abc_slide_out_top);
                    }
                    else
                    {
                        transaction.SetCustomAnimations(Resource.Animation.abc_slide_in_bottom, Resource.Animation.abc_slide_out_top,
                                                        Resource.Animation.abc_slide_in_top, Resource.Animation.abc_slide_out_bottom);
                    }
                    break;
                case TiposDeTransicaoEnum.SlideFromBottom:
                    if (isPush)
                    {
                        transaction.SetCustomAnimations(Resource.Animation.abc_slide_in_bottom, Resource.Animation.abc_slide_out_top,
                                                        Resource.Animation.abc_slide_in_top, Resource.Animation.abc_slide_out_bottom);
                    }
                    else
                    {
                        transaction.SetCustomAnimations(Resource.Animation.abc_slide_in_top, Resource.Animation.abc_slide_out_bottom,
                                                        Resource.Animation.abc_slide_in_bottom, Resource.Animation.abc_slide_out_bottom);
                    }
                    break;
                default:
                    return;
            }
        }

        private void UpdateTransitionType()
        {
            var transitionNavigationPage = (Controls.TransitionNavigationPage)Element;
            _TiposDeTransicaoEnum = transitionNavigationPage.TransitionType;
        }
    }
}
