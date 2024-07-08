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
            ((System.ComponentModel.ISupportInitialize)documentGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)document1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)document2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)document3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolbarFormManager).BeginInit();
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
            toolbarFormControl.ToolbarForm = this;
            // 
            // toolbarFormManager
            // 
            toolbarFormManager.DockControls.Add(barDockControlTop);
            toolbarFormManager.DockControls.Add(barDockControlBottom);
            toolbarFormManager.DockControls.Add(barDockControlLeft);
            toolbarFormManager.DockControls.Add(barDockControlRight);
            toolbarFormManager.Form = this;
            toolbarFormManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemSetAlertt, barButtonItemRemoveAlert, barButtonItemColorize });
            toolbarFormManager.MaxItemId = 3;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 651);
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
    }
}
