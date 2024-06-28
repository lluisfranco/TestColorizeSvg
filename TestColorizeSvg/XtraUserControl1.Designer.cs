namespace TestColorizeSvg
{
    partial class XtraUserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // pictureEdit
            // 
            pictureEdit.Dock = DockStyle.Fill;
            pictureEdit.Location = new Point(0, 0);
            pictureEdit.Name = "pictureEdit";
            pictureEdit.Properties.Appearance.BackColor = Color.Transparent;
            pictureEdit.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit.Size = new Size(150, 150);
            pictureEdit.TabIndex = 0;
            // 
            // XtraUserControl1
            // 
            Appearance.BackColor = Color.FromArgb(255, 192, 192);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureEdit);
            Name = "XtraUserControl1";
            ((System.ComponentModel.ISupportInitialize)pictureEdit.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit;
    }
}
