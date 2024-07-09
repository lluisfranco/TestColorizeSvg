namespace TestColorizeSvg
{
    partial class XtraUserControl3
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
            imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            ((System.ComponentModel.ISupportInitialize)imageListBoxControl1).BeginInit();
            SuspendLayout();
            // 
            // imageListBoxControl1
            // 
            imageListBoxControl1.Dock = DockStyle.Fill;
            imageListBoxControl1.Location = new Point(10, 10);
            imageListBoxControl1.Name = "imageListBoxControl1";
            imageListBoxControl1.Size = new Size(130, 130);
            imageListBoxControl1.TabIndex = 1;
            // 
            // XtraUserControl3
            // 
            Appearance.BackColor = Color.FromArgb(255, 192, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imageListBoxControl1);
            Name = "XtraUserControl3";
            Padding = new Padding(10);
            ((System.ComponentModel.ISupportInitialize)imageListBoxControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
    }
}
