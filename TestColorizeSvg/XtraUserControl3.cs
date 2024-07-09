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
    public partial class XtraUserControl3 : DevExpress.XtraEditors.XtraUserControl, IDetailsModule
    {
        public bool Initialized { get; set; }
        public XtraUserControl3()
        {
            InitializeComponent();
        }

        public async Task RefreshData()
        {
            await Task.Delay(2000);
            Initialized = true;
            var parent = FindForm();
            if (parent is not null) parent.Text = $"Updated at {DateTime.Now}";
        }
    }
}
