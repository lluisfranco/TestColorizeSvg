using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;

namespace TestColorizeSvg
{
    public static class BarHelper
    {
        public static void SyncDockPanesToBar(this BarItemLinkCollection barLinks, params DockPanel[] panes)
        {            
            int i = 0;
            foreach (var pane in panes)
            {
                var checkItem = new BarCheckItem()
                {
                    Caption = $"Show {pane.Text} pane",
                    Checked = pane.Visibility == DockVisibility.Visible,
                };
                checkItem.ImageOptions.SvgImage = GetImageFromPane(pane);
                checkItem.ImageOptions.SvgImageSize = new Size(16, 16);
                checkItem.CheckedChanged += (s, e) =>
                {
                    pane.Visibility = checkItem.Checked ? DockVisibility.Visible : DockVisibility.Hidden;
                };
                barLinks.Add(checkItem, beginGroup: i == 0);
                i++;
                pane.VisibilityChanged += (s, e) =>
                {
                    checkItem.Checked = pane.Visibility == DockVisibility.Visible;
                };
            }
        }

        private static SvgImage? GetImageFromPane(DockPanel pane)
        {
            SvgImage? image;
            if (pane.ImageOptions.SvgImage != null)
            {
                image = pane.ImageOptions.SvgImage;
            }
            else
            {
                if (pane.DockManager?.Images is SvgImageCollection imagecollection &&
                    pane.ImageOptions.ImageIndex != -1)
                {
                    image = imagecollection[pane.ImageOptions.ImageIndex];
                }
                else
                {
                    image = null;// SvgHelper.GetImageFromResources("_FimargeApp.DockPane");
                }
            }
            return image;
        }
    }

}
