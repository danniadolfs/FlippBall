using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SkiaSharp.Views.Forms;
using SkiaSharp;

namespace FlippBall
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class gameActivity : ContentPage
	{
        public gameActivity()
        {
            InitializeComponent();
            Title = "Fling";

            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }
        
        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.PaleVioletRed.ToSKColor(),
                StrokeWidth = 5
            };
            canvas.DrawCircle(info.Width / 2, info.Height-50, 50, paint);

        }
    }
}
