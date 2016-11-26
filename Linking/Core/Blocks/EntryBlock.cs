using System;
using System.Drawing;
using System.Windows.Forms;

namespace Linking.Core.Blocks
{
    public class EntryBlock : Block
    {
        public override Control Control
        {
            get
            {
                return new Controls.Blocks.EntryBlockControl(this);
            }
        }

        public EntryBlock(Board board, Node parent = null) : base(board, parent)
        {
            _linked = new Block[1];
        }

        protected override void ConnectFrom(Block block)
        {
            base.ConnectFrom(block);
        }

        protected override void ConnectTo(Block block, int index = 0)
        {
            base.ConnectTo(block, index);
        }

        public override void Execute(Core.Var.VariableTable table)
        {
            base.Execute(table);
            Next = LinkedBlocks[0];
        }
    }
}