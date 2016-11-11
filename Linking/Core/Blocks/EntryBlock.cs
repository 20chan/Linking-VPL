using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        
        public EntryBlock(Board board, Node parent = null) : base(board, parent)
        {
            LinkedBlocks = new NodeCollection[1];
        }

        public override void Execute()
        {
            base.Execute();
        }
    }
}
