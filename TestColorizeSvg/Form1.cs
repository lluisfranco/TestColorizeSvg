using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System.IO;
using DevExpress.XtraTab;
using DevExpress.Utils.Serializing;

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
            barButtonItemColorize.ItemClick += (s, e) =>
            {
                SwitchTabHeaderLocation();
            };
            Load += (s, e) =>
            {
                SaveDefaultLayouts();
                SuspendLayout();
                toolbarFormControl.TitleItemLinks.SyncDockPanesToBar(dockManager);
                //toolbarFormControl.TitleItemLinks.SyncDockPanesToBar(dockPanel1, dockPanel2);
                if (File.Exists(layoutfile)) documentManager.View.RestoreLayoutFromXml(layoutfile);
                if (File.Exists(layoutfile2)) dockManager.RestoreLayoutFromXml(layoutfile2);
                tabbedView.InitializeView();
                dockManager.InitializeView();
                ResumeLayout(false);
            };
            FormClosed += (s, e) =>
            {
                documentManager.View.SaveLayoutToXml(layoutfile);
                dockManager.SaveLayoutToXml(layoutfile2);
            };
            barButtonItemRestoreLayouts.ItemClick += (s, e) =>
            {
                SetControlBytesLayout(documentManager.View, DefaultLayoutBytes);
                SetControlBytesLayout(dockManager, DefaultLayoutBytes2);
                tabbedView.InitializeView();
                dockManager.InitializeView();
            };
        }

        private void SaveDefaultLayouts()
        {
            DefaultLayoutBytes = GetCurrentLayoutStream(documentManager.View).ToArray();
            DefaultLayoutBytes2 = GetCurrentLayoutStream(dockManager).ToArray();
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
        public MemoryStream GetCurrentLayoutStream(ISupportXtraSerializer control)
        {
            var stream = new MemoryStream();
            control?.SaveLayoutToStream(stream);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        private void SetControlBytesLayout(ISupportXtraSerializer control, byte[]? bytes)
        {
            try
            {
                if (bytes is null || bytes.Length == 0) return;
                var stream = new MemoryStream(bytes);
                control?.RestoreLayoutFromStream(stream);
                stream.Seek(0, SeekOrigin.Begin);
            }
            catch
            {

            }
        }
    }
}
