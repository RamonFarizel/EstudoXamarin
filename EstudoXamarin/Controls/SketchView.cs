using System;
using Xamarin.Forms;

namespace EstudoXamarin.Controls
{
    public class SketchView : View
    {
        public static readonly BindableProperty MultiTouchEnabledProperty =
            BindableProperty.Create("MultiTouchEnabled", typeof(bool), typeof(SketchView), false);


        public bool MultiTouchEnabled
        {
            get => (bool)GetValue(MultiTouchEnabledProperty);
            set => SetValue(MultiTouchEnabledProperty, value);
        }

    }
}
