using System;
using System.ComponentModel;
using System.Runtime.Remoting.Contexts;
using CoreGraphics;
using EstudoXamarin.Controls;
using EstudoXamarin.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ShadowLabel),typeof(ShadowLabelRenderer))]
namespace EstudoXamarin.iOS.Renderers
{
    public class ShadowLabelRenderer : LabelRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.ShadowColor = UIColor.DarkGray.CGColor;
            Control.Layer.ShadowOpacity = 1.0f;
            Control.Layer.ShadowRadius = 2f;
            Control.Layer.ShadowOffset = new CGSize(4, 4);
            Control.Layer.MasksToBounds = false;

        }

    }
}
