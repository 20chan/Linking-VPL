using System;
using System.Windows.Forms;
using Linking.Core;
using Linking.Core.Blocks;

namespace Linking.Controls
{
    public partial class BlockControl : UserControl
    {
        public Action TriedToLinkIn;
        public Action<int> TriedToLinkOut;

        private Block _block;
        public BlockControl(Block block)
        {
            InitializeComponent();
            _block = block;
            InitLinkOutButtons();
        }

        private void InitLinkOutButtons()
        {
            tableLayoutPanel2.RowStyles.Clear();
            for (int i = 0; i < _block.LinkedBlocks.Length; i++)
            {
                OutButton b = new OutButton(i);
                b.Dock = DockStyle.Fill;
                b.Text = string.Empty;
                b.Click += B_Click;
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / _block.LinkedBlocks.Length));
                tableLayoutPanel2.Controls.Add(b);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            int index = ((OutButton)sender).Index;
            TriedToLinkOut?.Invoke(index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TriedToLinkIn?.Invoke();
        }

        private class OutButton: Button { public readonly int Index; public OutButton(int index) { Index = index; } }
    }
}
