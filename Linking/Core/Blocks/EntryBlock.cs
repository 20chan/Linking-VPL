using System;
using System.Windows.Forms;

namespace Linking.Core.Blocks
{
    public class EntryBlock : Block
    {
        public override Control Control
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        protected override Control CreateControlInstance()
        {
            throw new NotImplementedException();
        }

        public override NodeCollection[] LinkedBlocks
        {
            get
            {
                return base.LinkedBlocks;
            }
            set
            {
                base._linked[0] = (NodeCollection)value[0].Clone();
            }
        }

        public EntryBlock(Board board, Node parent = null) : base(board, parent)
        {
            LinkedBlocks = new NodeCollection[1];
        }

        protected override void ConnectFrom(Block block)
        {
            base.ConnectFrom(block);
        }

        protected override void ConnectTo(Block block, int index = 0)
        {
            base.ConnectTo(block, index);
        }

        public override void Execute()
        {
            base.Execute();
        }
    }
}
