using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraTab;
using System.Collections;

namespace TestColorizeSvg
{
    public static class DocumentManagerHelper
    {
        public static void InitializeView(this TabbedView view, string? loadingText = null)
        {
            view.DocumentGroupProperties.HeaderLocation = TabHeaderLocation.Left;
            view.DocumentGroupProperties.HeaderOrientation = TabOrientation.Horizontal;
            view.DocumentProperties.AllowClose = false;
            view.DocumentProperties.AllowFloat = false;
            if (loadingText is not null)
                view.LoadingIndicatorProperties.Description = loadingText;
            else
                view.UseLoadingIndicator = DefaultBoolean.False;
            foreach (var doc in view.Documents)
            {
                doc.Caption = null;
            }
            view.DocumentGroupProperties.HeaderOrientation = TabOrientation.Horizontal;
            view.DocumentProperties.TabWidth = 60;
        }

        public static Document SetAlert(this Document doc, Color color = default)
        {
            if (color == default) color = DXSkinColors.FillColors.Danger;
            doc.Appearance.Header.BackColor = color;
            doc.Appearance.HeaderHotTracked.BackColor = HighLight(color);
            doc.Appearance.HeaderSelected.BackColor = HighLight(color, -25);
            return doc;
        }

        public static Document RemoveAlert(this Document doc)
        {
            doc.Appearance.Header.BackColor = Color.Transparent;
            doc.Appearance.HeaderHotTracked.BackColor = Color.Transparent;
            doc.Appearance.HeaderSelected.BackColor = Color.Transparent;
            return doc;
        }

        public static Document SetImageColor(this Document doc, Color color = default)
        {
            if (color == default) color = Color.White;
            doc.ImageOptions.SvgImage = doc.ImageOptions.SvgImage.SetImageFillColor(color);
            return doc;
        }

        public static SvgImage SetImageFillColor(this SvgImage img, Color color)
        {
            var colorstring = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            var style = img.Styles.FirstOrDefault();
            if (style is not null)
            {
                style.SetValue("fill", colorstring);
                return img.Clone();
            }
            return img;
        }

        private static Color HighLight(Color c, int highlightfactor = 100)
        {
            var r = c.R + highlightfactor > 255 ? 255 : c.R + highlightfactor;
            var g = c.G + highlightfactor > 255 ? 255 : c.G + highlightfactor;
            var b = c.B + highlightfactor > 255 ? 255 : c.B + highlightfactor;
            return Color.FromArgb(r < 0 ? 0 : r, g < 0 ? 0 : g, b < 0 ? 0 : b);
        }
    }

}
