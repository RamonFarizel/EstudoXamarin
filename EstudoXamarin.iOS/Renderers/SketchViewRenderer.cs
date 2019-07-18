using XFDraw;
using Xamarin.Forms;
using Xamarin.Forms.Platform.[platform];
using XFDraw.[platform];

[assembly: ExportRenderer(typeof(SketchView), typeof(SketchViewRenderer))]
namespace EstudoXamarin.iOS.Renderers
{
    public class SketchViewRenderer : ViewRenderer<SketchView, PaintView>
    {
        public SketchViewRenderer()
        {
        }
    }
}
