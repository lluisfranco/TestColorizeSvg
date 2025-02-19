﻿using DevExpress.Utils.Svg;
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
    public partial class XtraUserControl1 : DevExpress.XtraEditors.XtraUserControl, IDetailsModule
    {
        public Control GetControl() => this;
        public bool Initialized { get; set; }
        public XtraUserControl1()
        {
            InitializeComponent();
        }

        public async Task Initialize()
        {
            Initialized = true;
        }

        public async Task RefreshData()
        {
            await Task.Delay(2500);
            var parent = FindForm();
            if (parent is not null) parent.Text = $"Updated at {DateTime.Now}";
        }
    }
}
