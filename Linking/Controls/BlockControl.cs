using System;
using System.Drawing;
using System.Windows.Forms;
using Linking.Core;
using Linking.Core.Blocks;

namespace Linking.Controls
{
    public partial class BlockControl : UserControl
    {
        public event EventHandler TriedToLinkIn;
        public event EventHandler TriedToLinkOut;

        public ControlCollection InnerControls => InnerPanel.Controls;

        public Block Block { get; private set; }
        public BlockControl(Block block)
        {
            InitializeComponent();
            if (block is ValueBlock)
                throw new NotSupportedException("ValueBlock");
            Block = block;
            InitLinkOutButtons();
            InnerControls.Add(block.Control);

            block.Control.SizeChanged += Control_SizeChanged;
            InitSize();
        }

        private void Control_SizeChanged(object sender, EventArgs e)
        {
            InitSize();
        }

        private void InitLinkOutButtons()
        {
            tableLayoutPanel2.RowStyles.Clear();
            for (int i = 0; i < Block.LinkedBlocks.Length; i++)
            {
                OutButton b = new OutButton(i);
                b.Dock = DockStyle.Fill;
                b.Text = string.Empty;
                b.Click += B_Click;
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / Block.LinkedBlocks.Length));
                tableLayoutPanel2.Controls.Add(b);
            }
        }

        private void InitSize()
        {
            Size siz = Block.Control.Size;
            this.Size = new Size(siz.Width + 124, siz.Height + 22);
        }

        private void B_Click(object sender, EventArgs e)
        {
            int index = ((OutButton)sender).Index;
            TriedToLinkOut?.Invoke(this, new LinkOutEventArgs(index));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TriedToLinkIn?.Invoke(this, new EventArgs());
        }

        private class OutButton: Button { public readonly int Index; public OutButton(int index) { Index = index; } }
    }

    internal class LinkOutEventArgs : EventArgs
    {
        public int Index { get; set; }
        public LinkOutEventArgs(int index) : base()
        {
            Index = index;
        }
    }
}
