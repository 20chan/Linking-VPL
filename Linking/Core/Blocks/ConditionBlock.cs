using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;
using Linking.Core.Cond;

namespace Linking.Core.Blocks
{
    public class ConditionBlock : Block
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
        
        public virtual Condition Condition { get; set; }

        public ConditionBlock(Board board, Node parent = null, Condition condition = null) : base(board, parent)
        {
            _linked = new Block[2];
            Condition = condition;
        }

        protected override void ConnectTo(Block block, int index)
        {
            base.ConnectTo(block, index);
        }

        public override void Execute(VariableTable table)
        {
            if (Condition == null)
                throw new ArgumentNullException("Condition");

            if (Condition.Check(Board))
                Next = _linked[0];
            else
                Next = _linked[1];
            base.Execute(table);
        }
    }
}
