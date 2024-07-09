using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraTab;
using System.IO;

namespace TestColorizeSvg
{
    public partial class Form1 : ToolbarForm
    {
        string layoutfile = "layout.xml";
        string layoutfile2 = "layout2.xml";
        public byte[]? DefaultLayoutBytes { get; set; }
        public byte[]? DefaultLayoutBytes2 { get; set; }

        Document? GetDocument() => tabbedView.ActiveDocument as Document;
        public Form1()
        {
            InitializeComponent();
            toolbarFormControl.AddSwitchModeButtons();
            barButtonItemSetAlertt.ItemClick += (s, e) => GetDocument()?.SetAlert();
            barButtonItemRemoveAlert.ItemClick += (s, e) => GetDocument()?.RemoveAlert();
            barButtonItemColorize.ItemClick += (s, e) => SwitchTabHeaderLocation();
            barButtonItemRefresh.ItemClick += async (s, e) => await tabbedView.RefreshActiveModule();
            barButtonItemRestoreLayouts.ItemClick += (s, e) => RestoreDefaultLayoutsFromMemory();
            Load += async (s, e) =>
            {
                SaveDefaultLayoutsToMemory();
                ControlHelper.SuspendLayout(this, dockPanel1, dockPanel2, dockPanel4);
                toolbarFormControl.TitleItemLinks.SyncDockPanesToBar(dockManager);
                if (File.Exists(layoutfile)) documentManager.View.RestoreLayoutFromXml(layoutfile);
                if (File.Exists(layoutfile2)) dockManager.RestoreLayoutFromXml(layoutfile2);
                tabbedView.InitializeView("Loading details...");
                dockManager.InitializeView();
                ControlHelper.ResumeLayout(this, dockPanel1, dockPanel2, dockPanel4);
                dockPanel1.ShowProgressPanel();
                await tabbedView.RefreshActiveModule();
                dockPanel1.CloseProgressPanel();
            };
            FormClosed += (s, e) =>
            {
                documentManager.View.SaveLayoutToXml(layoutfile);
                dockManager.SaveLayoutToXml(layoutfile2);
            };
        }

        private void RestoreDefaultLayoutsFromMemory()
        {
            ControlHelper.SuspendLayout(this, dockPanel1, dockPanel2, dockPanel4);
            documentManager.View.SetControlBytesLayout(DefaultLayoutBytes);
            dockManager.SetControlBytesLayout(DefaultLayoutBytes2);
            tabbedView.InitializeView("Loading details...");
            dockManager.InitializeView();
            ControlHelper.ResumeLayout(this, dockPanel1, dockPanel2, dockPanel4);
        }

        private void SaveDefaultLayoutsToMemory()
        {
            DefaultLayoutBytes = documentManager.View.GetCurrentLayoutStream().ToArray();
            DefaultLayoutBytes2 = dockManager.GetCurrentLayoutStream().ToArray();
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
