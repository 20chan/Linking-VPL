using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;
using Linking.Core.Conds;

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
        
        public virtual ConditionBoolBlock Condition{ get; set; }

        public ConditionBlock(Board board, Node parent = null, ConditionBoolBlock condition = null) : base(board, parent)
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
            base.Execute(table);
            if (Condition == null)
                throw new ArgumentNullException("Condition");

            if (this.Condition.GetValue(table))
                Next = _linked[0];
            else
                Next = _linked[1];
        }
    }
}
