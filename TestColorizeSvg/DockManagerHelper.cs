using DevExpress.Utils;
using DevExpress.XtraBars.Docking;

namespace TestColorizeSvg
{
    public static class DockManagerHelper
    {
        public static void InitializeView(this DockManager dock)
        {
            const int SIZE = 16;
            dock.DockingOptions.AllowDockToCenter = DefaultBoolean.False;           
            foreach (DockPanel item in dock.Panels)
            {
                item.Options.ShowAutoHideButton = false;
                item.ImageOptions.SvgImageSize = new Size(SIZE, SIZE);
                //item.Options.AllowDockFill = false;
                item.Options.AllowDockAsTabbedDocument = false;
            }
        }
    }

}
