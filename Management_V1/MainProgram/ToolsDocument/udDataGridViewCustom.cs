using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace ToolsDocument
{
    public partial class udDataGridViewCustom : Component
    {
        public udDataGridViewCustom()
        {
            InitializeComponent();
        }

        public udDataGridViewCustom(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
