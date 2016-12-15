using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Blocks;

namespace Linking.Controls.Blocks
{
    public partial class ConditionBlockControl : UserControl
    {
        private IBoolBlockControl _inner;
        private ConditionBlock _block;
        public ConditionBlockControl(ConditionBlock block)
        {
            InitializeComponent();
            _block = block;
        }

        private void 상수부울BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var val = new ConstBoolBlock(_block.Board, _block);
            ConstBoolBlockControl block = new ConstBoolBlockControl(val);
            _inner = block;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            this.panel1.Controls.Add(block);

            _block.Condition = val;
        }
    }
}
