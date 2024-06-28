using DevExpress.XtraBars.ToolbarForm;
using System.IO;

namespace TestColorizeSvg
{
    public partial class Form1 : ToolbarForm
    {
        string layoutfile = "layout.xml";
        public Form1()
        {
            InitializeComponent();
            toolbarFormControl.AddSwitchModeButtons();
            tabbedView.InitializeView();
            barButtonItemSetAlertt.ItemClick += (s, e) => document2.SetAlert();
            barButtonItemRemoveAlert.ItemClick += (s, e) => document2.RemoveAlert();
            barButtonItemColorize.ItemClick += (s, e) =>
            {
                document3.SetImageColor(Color.White);
                (document1.Control as XtraUserControl1)?.SetImage(document3.ImageOptions.SvgImage);
            };
            Load += (s, e) =>
            {
                if (File.Exists(layoutfile)) documentManager.View.RestoreLayoutFromXml(layoutfile);
            };
            FormClosed += (s, e) => documentManager.View.SaveLayoutToXml(layoutfile);
        }
    }

}
