namespace TestColorizeSvg
{
    public static class ControlHelper
    {
        public static void SuspendLayout(this Control control, params Control[] controls)
        {
            control.SuspendLayout();
            foreach (var c in controls)
            {
                c.SuspendLayout();
            }
        }

        public static void ResumeLayout(this Control control, params Control[] controls)
        {
            control.ResumeLayout(false);
            foreach (var c in controls)
            {
                c.ResumeLayout(false);
            }
            control.PerformLayout();
        }
    }
}
