using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraTab;

namespace TestColorizeSvg
{
    public static class DocumentManagerHelper
    {
        public static void InitializeView(this TabbedView view, string? loadingText = null, int tableWidth = 60)
        {
            const int SIZE = 20;
            view.DocumentGroupProperties.HeaderLocation = TabHeaderLocation.Left;
            view.DocumentGroupProperties.HeaderOrientation = TabOrientation.Horizontal;
            view.DocumentProperties.AllowClose = false;
            view.DocumentProperties.AllowFloat = false;
            view.EnableFreeLayoutMode = DefaultBoolean.True;
            if (loadingText is not null)
                view.LoadingIndicatorProperties.Description = loadingText;
            else
                view.UseLoadingIndicator = DefaultBoolean.False;
            foreach (var doc in view.Documents)
            {
                doc.Header = (doc as Document)?.SuperTip.Items.OfType<ToolTipItem>().FirstOrDefault()?.Text;
                doc.Caption = null;
                doc.ImageOptions.SvgImageSize = new Size(SIZE, SIZE);
            }
            view.DocumentGroupProperties.HeaderOrientation = TabOrientation.Horizontal;
            view.DocumentProperties.TabWidth = tableWidth;
            view.DocumentActivated += async (s, e) =>
            {
                if (e.Document.Control is IDetailsModule module)
                {
                    if (module.Initialized) return;
                    await module.InitializeAndRefreshModule();
                }
            };
        }

        public static async Task RefreshActiveModules(this TabbedView view)
        {
            await Task.Delay(100);
            var tasks = new List<Task>();
            foreach (var item in view.Documents)
            {
                var module = item.Control as IDetailsModule;
                if (module is not null)
                    tasks.Add(module.InitializeAndRefreshModule());
            }
            await Task.WhenAll(tasks);
        }

        private static async Task InitializeAndRefreshModule(this IDetailsModule module)
        {
            module.GetControl().ShowProgressPanel();
            if (!module.Initialized) await module.Initialize();
            await module.RefreshData();
            module.GetControl().CloseProgressPanel();
        }

        public static Document SetAlert(this Document doc, Color backColor = default, Color imageColor = default)
        {
            const int SELECTED_COLOR_FACTOR = -25;
            if (backColor == default) backColor = DXSkinColors.FillColors.Danger;
            if (imageColor == default) imageColor = Color.White;
            doc.Appearance.Header.BackColor = backColor;
            doc.Appearance.HeaderHotTracked.BackColor = HighLight(backColor);
            doc.Appearance.HeaderSelected.BackColor = HighLight(backColor, SELECTED_COLOR_FACTOR);
            if (imageColor != default) doc.SetImageColor(imageColor);
            return doc;
        }

        public static Document RemoveAlert(this Document doc)
        {
            doc.Appearance.Header.BackColor = Color.Transparent;
            doc.Appearance.HeaderHotTracked.BackColor = Color.Transparent;
            doc.Appearance.HeaderSelected.BackColor = Color.Transparent;
            doc.RemoveImageColor();
            return doc;
        }

        public static Document SetImageColor(this Document doc, Color imageColor = default)
        {
            if (imageColor == default) imageColor = Color.White;
            doc.ImageOptions.SvgImage = doc.ImageOptions.SvgImage.SetImageFillColor(imageColor);
            doc.ImageOptions.SvgImageColorizationMode = SvgImageColorizationMode.None;
            return doc;
        }

        public static Document RemoveImageColor(this Document doc)
        {
            if (doc.ImageOptions.SvgImage.Tag is null) return doc;
            var color = ColorTranslator.FromHtml(doc.ImageOptions.SvgImage.Tag.ToString() ?? string.Empty);
            doc.ImageOptions.SvgImage = doc.ImageOptions.SvgImage.SetImageFillColor(color);
            doc.ImageOptions.SvgImageColorizationMode = SvgImageColorizationMode.Default;
            return doc;
        }

        public static SvgImage SetImageFillColor(this SvgImage img, Color color)
        {
            var colorstring = $"#{color.R:X2}{color.G:X2}{color.B:X2}";            
            var style = img.Styles.FirstOrDefault();
            if (style is not null)
            {
                if (img.Tag is null) img.Tag = style.Attributes["fill"];
                style.SetValue("fill", colorstring);
                return img;
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
