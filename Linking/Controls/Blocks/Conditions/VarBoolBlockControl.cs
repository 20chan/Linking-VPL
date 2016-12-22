using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Blocks;

namespace Linking.Controls.Blocks.Conditions
{
    public partial class VarBoolBlockControl : UserControl
    {
        public string VarName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        private VarBoolBlock _block;
        public VarBoolBlockControl(VarBoolBlock block)
        {
            InitializeComponent();
            _block = block;
        }
    }
}
