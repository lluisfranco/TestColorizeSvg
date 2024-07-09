using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestColorizeSvg
{
    public partial class XtraUserControl4 : DevExpress.XtraEditors.XtraUserControl, IDetailsModule
    {
        public bool Initialized { get; set; }
        public XtraUserControl4()
        {
            InitializeComponent();
        }

        public async Task RefreshData()
        {
            this.ShowProgressPanel();
            await Task.Delay(2000);
            Initialized = true;
            var parent = FindForm();
            if (parent is not null) parent.Text = $"Updated at {DateTime.Now}";
            this.CloseProgressPanel();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            await RefreshData();
        }
    }
}
