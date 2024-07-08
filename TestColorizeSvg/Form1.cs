using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System.IO;

namespace TestColorizeSvg
{
    public partial class Form1 : ToolbarForm
    {
        string layoutfile = "layout.xml";
        Document? GetDocument() => tabbedView.ActiveDocument as Document;
        public Form1()
        {
            InitializeComponent();
            toolbarFormControl.AddSwitchModeButtons();
            tabbedView.InitializeView();
            barButtonItemSetAlertt.ItemClick += (s, e) => GetDocument()?.SetAlert();
            barButtonItemRemoveAlert.ItemClick += (s, e) => GetDocument()?.RemoveAlert();
            barButtonItemColorize.ItemClick += (s, e) =>
            {
                //document3.SetAlert().SetImageColor(Color.White);
            };
            Load += (s, e) =>
            {
                if (File.Exists(layoutfile)) documentManager.View.RestoreLayoutFromXml(layoutfile);
            };
            FormClosed += (s, e) => documentManager.View.SaveLayoutToXml(layoutfile);
        }
    }

}
