using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System.IO;
using DevExpress.XtraTab;

namespace TestColorizeSvg
{
    public partial class Form1 : ToolbarForm
    {
        string layoutfile = "layout.xml";
        string layoutfile2 = "layout2.xml";
        Document? GetDocument() => tabbedView.ActiveDocument as Document;
        public Form1()
        {
            InitializeComponent();
            toolbarFormControl.AddSwitchModeButtons();
            barButtonItemSetAlertt.ItemClick += (s, e) => GetDocument()?.SetAlert();
            barButtonItemRemoveAlert.ItemClick += (s, e) => GetDocument()?.RemoveAlert();
            barButtonItemColorize.ItemClick += (s, e) =>
            {
                SwitchTabHeaderLocation();
            };
            Load += (s, e) =>
            {
                toolbarFormControl.TitleItemLinks.SyncDockPanesToBar(dockPanel1, dockPanel2);
                if (File.Exists(layoutfile)) documentManager.View.RestoreLayoutFromXml(layoutfile);
                if (File.Exists(layoutfile2)) dockManager.RestoreLayoutFromXml(layoutfile2);
                tabbedView.InitializeView();
                dockManager.InitializeView();
            };
            FormClosed += (s, e) =>
            {
                documentManager.View.SaveLayoutToXml(layoutfile);
                dockManager.SaveLayoutToXml(layoutfile2);
            };
        }

        private void SwitchTabHeaderLocation()
        {
            if (tabbedView.DocumentGroupProperties.HeaderLocation == TabHeaderLocation.Left)
            {
                tabbedView.DocumentGroupProperties.HeaderLocation = TabHeaderLocation.Bottom;
                return;
            }
            if (tabbedView.DocumentGroupProperties.HeaderLocation == TabHeaderLocation.Bottom)
            {
                tabbedView.DocumentGroupProperties.HeaderLocation = TabHeaderLocation.Right;
                return;
            }
            if (tabbedView.DocumentGroupProperties.HeaderLocation == TabHeaderLocation.Right)
            {
                tabbedView.DocumentGroupProperties.HeaderLocation = TabHeaderLocation.Top;
                return;
            }
            if (tabbedView.DocumentGroupProperties.HeaderLocation == TabHeaderLocation.Top)
            {
                tabbedView.DocumentGroupProperties.HeaderLocation = TabHeaderLocation.Left;
                return;
            }
        }
    }

}
