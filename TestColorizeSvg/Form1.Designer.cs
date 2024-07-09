namespace TestColorizeSvg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(components);
            document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(components);
            document2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(components);
            document3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(components);
            documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            toolbarFormControl = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            toolbarFormManager = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItemSetAlertt = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemRemoveAlert = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemColorize = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemRestoreLayouts = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            dockManager = new DevExpress.XtraBars.Docking.DockManager(components);
            dockPanel6 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            checkButton1 = new DevExpress.XtraEditors.CheckButton();
            dockPanel5 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            ((System.ComponentModel.ISupportInitialize)documentGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)document1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)document2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)document3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dockManager).BeginInit();
            dockPanel6.SuspendLayout();
            dockPanel1.SuspendLayout();
            dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageListBoxControl1).BeginInit();
            dockPanel2.SuspendLayout();
            dockPanel2_Container.SuspendLayout();
            dockPanel4.SuspendLayout();
            dockPanel4_Container.SuspendLayout();
            SuspendLayout();
            // 
            // documentGroup1
            // 
            documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] { document1, document2, document3 });
            // 
            // document1
            // 
            document1.Caption = "document1";
            document1.ControlName = "document1";
            document1.ControlType = typeof(XtraUserControl1);
            document1.ImageOptions.SvgImage = Properties.Resources.Home1;
            toolTipItem1.Text = "General";
            superToolTip1.Items.Add(toolTipItem1);
            document1.SuperTip = superToolTip1;
            // 
            // document2
            // 
            document2.Caption = "document2";
            document2.ControlName = "document2";
            document2.ControlType = typeof(XtraUserControl2);
            document2.ImageOptions.SvgImage = Properties.Resources.Phone;
            toolTipItem2.Text = "Contact";
            superToolTip2.Items.Add(toolTipItem2);
            document2.SuperTip = superToolTip2;
            // 
            // document3
            // 
            document3.Caption = "document3";
            document3.ControlName = "document3";
            document3.ControlType = typeof(XtraUserControl3);
            document3.ImageOptions.SvgImage = Properties.Resources.Calendar;
            toolTipItem3.Text = "Events";
            superToolTip3.Items.Add(toolTipItem3);
            document3.SuperTip = superToolTip3;
            // 
            // documentManager
            // 
            documentManager.ContainerControl = this;
            documentManager.View = tabbedView;
            documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView });
            // 
            // tabbedView
            // 
            tabbedView.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] { documentGroup1 });
            tabbedView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] { document1, document2, document3 });
            dockingContainer1.Element = documentGroup1;
            tabbedView.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] { dockingContainer1 });
            // 
            // toolbarFormControl
            // 
            toolbarFormControl.Location = new Point(0, 0);
            toolbarFormControl.Manager = toolbarFormManager;
            toolbarFormControl.Name = "toolbarFormControl";
            toolbarFormControl.Size = new Size(1011, 31);
            toolbarFormControl.TabIndex = 1;
            toolbarFormControl.TabStop = false;
            toolbarFormControl.TitleItemLinks.Add(barButtonItemSetAlertt);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemRemoveAlert);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemColorize);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemRestoreLayouts);
            toolbarFormControl.TitleItemLinks.Add(barButtonItemRefresh);
            toolbarFormControl.ToolbarForm = this;
            // 
            // toolbarFormManager
            // 
            toolbarFormManager.DockControls.Add(barDockControlTop);
            toolbarFormManager.DockControls.Add(barDockControlBottom);
            toolbarFormManager.DockControls.Add(barDockControlLeft);
            toolbarFormManager.DockControls.Add(barDockControlRight);
            toolbarFormManager.Form = this;
            toolbarFormManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemSetAlertt, barButtonItemRemoveAlert, barButtonItemColorize, barButtonItemRestoreLayouts, barButtonItemRefresh });
            toolbarFormManager.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 31);
            barDockControlTop.Manager = toolbarFormManager;
            barDockControlTop.Size = new Size(1011, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 651);
            barDockControlBottom.Manager = toolbarFormManager;
            barDockControlBottom.Size = new Size(1011, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 31);
            barDockControlLeft.Manager = toolbarFormManager;
            barDockControlLeft.Size = new Size(0, 620);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1011, 31);
            barDockControlRight.Manager = toolbarFormManager;
            barDockControlRight.Size = new Size(0, 620);
            // 
            // barButtonItemSetAlertt
            // 
            barButtonItemSetAlertt.Caption = "Set Alert";
            barButtonItemSetAlertt.Id = 0;
            barButtonItemSetAlertt.ImageOptions.SvgImage = Properties.Resources.Lightbulb;
            barButtonItemSetAlertt.Name = "barButtonItemSetAlertt";
            barButtonItemSetAlertt.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemRemoveAlert
            // 
            barButtonItemRemoveAlert.Caption = "Remove Alert";
            barButtonItemRemoveAlert.Id = 1;
            barButtonItemRemoveAlert.ImageOptions.SvgImage = Properties.Resources.Lightbulb1;
            barButtonItemRemoveAlert.Name = "barButtonItemRemoveAlert";
            barButtonItemRemoveAlert.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemColorize
            // 
            barButtonItemColorize.Caption = "Colorize";
            barButtonItemColorize.Id = 2;
            barButtonItemColorize.ImageOptions.SvgImage = Properties.Resources.Color;
            barButtonItemColorize.Name = "barButtonItemColorize";
            barButtonItemColorize.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemRestoreLayouts
            // 
            barButtonItemRestoreLayouts.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barButtonItemRestoreLayouts.Caption = "Restore Layouts";
            barButtonItemRestoreLayouts.Id = 3;
            barButtonItemRestoreLayouts.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemRestoreLayouts.ImageOptions.SvgImage");
            barButtonItemRestoreLayouts.Name = "barButtonItemRestoreLayouts";
            // 
            // barButtonItemRefresh
            // 
            barButtonItemRefresh.Caption = "Refresh";
            barButtonItemRefresh.Id = 4;
            barButtonItemRefresh.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemRefresh.ImageOptions.SvgImage");
            barButtonItemRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F5);
            barButtonItemRefresh.Name = "barButtonItemRefresh";
            // 
            // dockManager
            // 
            dockManager.DockingOptions.ShowCaptionImage = true;
            dockManager.Form = this;
            dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] { dockPanel6, dockPanel4 });
            dockManager.TopZIndexControls.AddRange(new string[] { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl" });
            // 
            // dockPanel6
            // 
            dockPanel6.Controls.Add(dockPanel1);
            dockPanel6.Controls.Add(dockPanel2);
            dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            dockPanel6.ID = new Guid("03700814-5057-4e10-8c6d-5669c8ae9cd5");
            dockPanel6.Location = new Point(811, 31);
            dockPanel6.Name = "dockPanel6";
            dockPanel6.OriginalSize = new Size(200, 200);
            dockPanel6.Size = new Size(200, 620);
            dockPanel6.Text = "panelContainer1";
            // 
            // dockPanel1
            // 
            dockPanel1.Controls.Add(dockPanel1_Container);
            dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanel1.FloatVertical = true;
            dockPanel1.ID = new Guid("6e9859d4-e037-4e96-98ba-0116d3a995f0");
            dockPanel1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("dockPanel1.ImageOptions.SvgImage");
            dockPanel1.Location = new Point(0, 0);
            dockPanel1.Name = "dockPanel1";
            dockPanel1.OriginalSize = new Size(200, 204);
            dockPanel1.Size = new Size(200, 310);
            dockPanel1.Text = "Roles";
            // 
            // dockPanel1_Container
            // 
            dockPanel1_Container.Controls.Add(imageListBoxControl1);
            dockPanel1_Container.Location = new Point(4, 40);
            dockPanel1_Container.Name = "dockPanel1_Container";
            dockPanel1_Container.Size = new Size(193, 266);
            dockPanel1_Container.TabIndex = 0;
            // 
            // imageListBoxControl1
            // 
            imageListBoxControl1.Location = new Point(24, 70);
            imageListBoxControl1.Name = "imageListBoxControl1";
            imageListBoxControl1.Size = new Size(110, 105);
            imageListBoxControl1.TabIndex = 1;
            // 
            // dockPanel2
            // 
            dockPanel2.Controls.Add(dockPanel2_Container);
            dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanel2.ID = new Guid("216036b2-bbd3-4fa9-b5e8-b69766138dd2");
            dockPanel2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("dockPanel2.ImageOptions.SvgImage");
            dockPanel2.Location = new Point(0, 310);
            dockPanel2.Name = "dockPanel2";
            dockPanel2.OriginalSize = new Size(200, 204);
            dockPanel2.Size = new Size(200, 310);
            dockPanel2.Text = "Marks";
            // 
            // dockPanel2_Container
            // 
            dockPanel2_Container.Controls.Add(simpleButton1);
            dockPanel2_Container.Location = new Point(4, 40);
            dockPanel2_Container.Name = "dockPanel2_Container";
            dockPanel2_Container.Size = new Size(193, 267);
            dockPanel2_Container.TabIndex = 0;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(34, 31);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(75, 23);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "simpleButton1";
            // 
            // dockPanel4
            // 
            dockPanel4.Controls.Add(dockPanel4_Container);
            dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            dockPanel4.ID = new Guid("9d10561b-3c48-461a-96a0-c365457f10f3");
            dockPanel4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("dockPanel4.ImageOptions.SvgImage");
            dockPanel4.Location = new Point(0, 451);
            dockPanel4.Name = "dockPanel4";
            dockPanel4.OriginalSize = new Size(200, 200);
            dockPanel4.Size = new Size(811, 200);
            dockPanel4.Text = "Errors";
            // 
            // dockPanel4_Container
            // 
            dockPanel4_Container.Controls.Add(checkButton1);
            dockPanel4_Container.Location = new Point(3, 41);
            dockPanel4_Container.Name = "dockPanel4_Container";
            dockPanel4_Container.Size = new Size(805, 156);
            dockPanel4_Container.TabIndex = 0;
            // 
            // checkButton1
            // 
            checkButton1.Location = new Point(146, 53);
            checkButton1.Name = "checkButton1";
            checkButton1.Size = new Size(75, 23);
            checkButton1.TabIndex = 0;
            checkButton1.Text = "checkButton1";
            // 
            // dockPanel5
            // 
            dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            dockPanel5.ID = new Guid("6fe82bd0-41a2-4167-ba7f-c1b6c6b25c47");
            dockPanel5.Location = new Point(811, 31);
            dockPanel5.Name = "dockPanel5";
            dockPanel5.OriginalSize = new Size(200, 200);
            dockPanel5.Size = new Size(200, 620);
            dockPanel5.Text = "panelContainer1";
            // 
            // dockPanel3
            // 
            dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            dockPanel3.ID = new Guid("845921fa-f311-4d23-8f5b-e52ee114ac3a");
            dockPanel3.Location = new Point(811, 31);
            dockPanel3.Name = "dockPanel3";
            dockPanel3.OriginalSize = new Size(200, 200);
            dockPanel3.Size = new Size(200, 620);
            dockPanel3.Tabbed = true;
            dockPanel3.Text = "panelContainer1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 651);
            Controls.Add(dockPanel4);
            Controls.Add(dockPanel6);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Controls.Add(toolbarFormControl);
            Name = "Form1";
            Text = "Form1";
            ToolbarFormControl = toolbarFormControl;
            ((System.ComponentModel.ISupportInitialize)documentGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)document1).EndInit();
            ((System.ComponentModel.ISupportInitialize)document2).EndInit();
            ((System.ComponentModel.ISupportInitialize)document3).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)dockManager).EndInit();
            dockPanel6.ResumeLayout(false);
            dockPanel1.ResumeLayout(false);
            dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageListBoxControl1).EndInit();
            dockPanel2.ResumeLayout(false);
            dockPanel2_Container.ResumeLayout(false);
            dockPanel4.ResumeLayout(false);
            dockPanel4_Container.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSetAlertt;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRemoveAlert;
        private DevExpress.XtraBars.BarButtonItem barButtonItemColorize;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRestoreLayouts;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel5;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel6;
    }
}
