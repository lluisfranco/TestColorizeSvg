namespace TestColorizeSvg
{
    partial class XtraUserControl2
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
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // memoEdit1
            // 
            memoEdit1.Dock = DockStyle.Fill;
            memoEdit1.Location = new Point(10, 10);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(130, 130);
            memoEdit1.TabIndex = 0;
            // 
            // XtraUserControl2
            // 
            Appearance.BackColor = Color.FromArgb(192, 192, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(memoEdit1);
            Name = "XtraUserControl2";
            Padding = new Padding(10);
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}
