using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linking.Core.Blocks
{
    public class DeclareVariableBlock : Block
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

        public Var.Variable Variable { get; set; }
        
        public DeclareVariableBlock(Board board, Node parent = null) : base(board, parent)
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

        public override void Execute(Var.VariableTable table)
        {
            // TODO: Declare Var!
            base.Execute(table);
        }
    }
}