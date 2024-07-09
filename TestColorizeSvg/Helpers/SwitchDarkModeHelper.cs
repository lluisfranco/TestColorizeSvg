using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ToolbarForm;

namespace TestColorizeSvg
{
    public static class SwitchDarkModeHelper
    {
        const string SKIN_NAME = "WXI";

        static bool UseDarkMode;
        static BarButtonItem? barButtonItemSwitchToDarkMode;
        static BarButtonItem? barButtonItemSwitchToLightMode;
        public static void AddSwitchModeButtons(this ToolbarFormControl toolbar, bool? darkTheme = null)
        {
            UseDarkMode = darkTheme ?? true;// RegisterAppService.GetSystemUseDarkMode();
            var images = CreateSwitchThemeImages();
            barButtonItemSwitchToDarkMode = new BarButtonItem();
            barButtonItemSwitchToLightMode = new BarButtonItem();
            toolbar.TitleItemLinks.Add(barButtonItemSwitchToLightMode);
            toolbar.TitleItemLinks.Add(barButtonItemSwitchToDarkMode);
            barButtonItemSwitchToDarkMode.Alignment = BarItemLinkAlignment.Right;
            barButtonItemSwitchToDarkMode.Caption = "Switch to Dark mode";
            barButtonItemSwitchToDarkMode.Id = 0;
            barButtonItemSwitchToDarkMode.ImageOptions.SvgImage = images["weather_moon"];
            barButtonItemSwitchToDarkMode.Name = "barButtonItemSwitchToDarkMode";
            barButtonItemSwitchToLightMode.Alignment = BarItemLinkAlignment.Right;
            barButtonItemSwitchToLightMode.Caption = "Switch to Light mode";
            barButtonItemSwitchToLightMode.Id = 1;
            barButtonItemSwitchToLightMode.ImageOptions.SvgImage = images["weather_sunny"];
            barButtonItemSwitchToLightMode.Name = "barButtonItemSwitchToLightMode";
            barButtonItemSwitchToDarkMode.ItemClick += (s, e) =>
            {
                UseDarkMode = true;
                SetDarkMode();
                SetLightOrDarkModeButtonsVisibility();
            };
            barButtonItemSwitchToLightMode.ItemClick += (s, e) =>
            {
                UseDarkMode = false;
                SetLightMode();
                SetLightOrDarkModeButtonsVisibility();
            };
            if (UseDarkMode)
                SetDarkMode();
            else
                SetLightMode();
            SetLightOrDarkModeButtonsVisibility();
        }

        private static void SetLightOrDarkModeButtonsVisibility()
        {
            if (barButtonItemSwitchToDarkMode != null)
                barButtonItemSwitchToDarkMode.Visibility = UseDarkMode ?
                    BarItemVisibility.Never : BarItemVisibility.Always;
            if (barButtonItemSwitchToLightMode != null)
                barButtonItemSwitchToLightMode.Visibility = UseDarkMode ?
                BarItemVisibility.Always : BarItemVisibility.Never;
        }

        public static void SetLightMode()
        {
            if (UserLookAndFeel.Default.SkinName != SKIN_NAME)
                UserLookAndFeel.Default.SetSkinStyle(SKIN_NAME);
            var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            var palette = skin.CustomSvgPalettes["Freshness"];
            skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        public static void SetDarkMode()
        {
            if (UserLookAndFeel.Default.SkinName != SKIN_NAME)
                UserLookAndFeel.Default.SetSkinStyle(SKIN_NAME);
            var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            var palette = skin.CustomSvgPalettes["Darkness"];
            skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        private static SvgImageCollection CreateSwitchThemeImages()
        {
            return new SvgImageCollection
            {
                { "weather_sunny", "image://svgimages/icon builder/weather_sunny.svg" },
                { "weather_moon", "image://svgimages/icon builder/weather_moon.svg" }
            };
        }
    }

}
