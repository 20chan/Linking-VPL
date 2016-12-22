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

        private void SetControl(Control c)
        {
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            this.panel1.Controls.Add(c);
        }

        private void 상수부울BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var val = new ConstBoolBlock(_block.Board, _block);
            _inner = (Conditions.ConstBoolBlockControl)val.Control;
            SetControl(val.Control);

            _block.Condition = val;
        }

        private void 같다면ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 조건문CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var val = new ConditionBoolBlock(_block.Board, _block);
            _inner = (Conditions.CompareBlockControl)val.Control;
            SetControl(val.Control);

            _block.Condition = val;
        }
    }
}
