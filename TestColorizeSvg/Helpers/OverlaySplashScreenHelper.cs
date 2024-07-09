using DevExpress.XtraSplashScreen;

namespace TestColorizeSvg
{
    public static class OverlaySplashScreenHelper
    {
        public static IOverlaySplashScreenHandle ShowProgressPanel(this Control control)
        {
            var handle = SplashScreenManager.ShowOverlayForm(control);
            control.Tag = handle;
            return handle;
        }
        public static void CloseProgressPanel(this Control control)
        {
            var handle = control.Tag as IOverlaySplashScreenHandle;
            if (handle is not null) SplashScreenManager.CloseOverlayForm(handle);
        }
    }
}
