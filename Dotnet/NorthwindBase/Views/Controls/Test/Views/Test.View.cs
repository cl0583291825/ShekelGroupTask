using ENV;
using ENV.Data;
using Firefly.Box;
using Firefly.Box.UI.Advanced;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Northwind.Views.Controls.Test.Views
{
    partial class TestView : Shared.Theme.Controls.CompatibleForm
    {
        Test _controller;
        public TestView(Test controller)
        {
            _controller = controller;
            InitializeComponent();
        }
    }
}