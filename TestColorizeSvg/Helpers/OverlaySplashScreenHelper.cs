using DevExpress.LookAndFeel;
using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;

namespace TestColorizeSvg
{
    public static class OverlaySplashScreenHelper
    {
        public static IOverlaySplashScreenHandle? ShowProgressPanel(this Control control, string? text = null)
        {
            IOverlaySplashScreenHandle handle;
            if (control.Tag is not null) return null;
            if (text is not null)
            {
                var overlayLabel = new OverlayTextPainterEx
                {
                    Text = text,
                    Color = DXSkinColors.ForeColors.DisabledText
                };
                handle = SplashScreenManager.ShowOverlayForm(control, 
                    customPainter: new OverlayWindowCompositePainter(overlayLabel));
            }
            else
            {
                handle = SplashScreenManager.ShowOverlayForm(control);
            }
            control.Tag = handle;
            return handle;
        }
        public static void CloseProgressPanel(this Control control)
        {
            var handle = control.Tag as IOverlaySplashScreenHandle;
            if (handle is not null) SplashScreenManager.CloseOverlayForm(handle);
            control.Tag = null;
        }
    }

    class OverlayTextPainterEx : OverlayTextPainter
    {
        protected override Rectangle CalcTextBounds(OverlayLayeredWindowObjectInfoArgs drawArgs)
        {
            Size textSz = CalcTextSize(drawArgs);
            return textSz.AlignWith(drawArgs.Bounds).WithY(drawArgs.ImageBounds.Top - textSz.Height);
        }
    }
}
