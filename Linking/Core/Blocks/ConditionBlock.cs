using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;
using Linking.Core.Conds;
using Linking.Controls.Blocks;

namespace Linking.Core.Blocks
{
    public class ConditionBlock : Block
    {
        private ConditionBlockControl _control;
        public override Control Control => _control;
        
        public virtual BoolBlock Condition { get; set; }

        public ConditionBlock(Board board, Node parent = null, BoolBlock condition = null) : base(board, parent)
        {
            _linked = new Block[2];
            Condition = condition;
            _control = new ConditionBlockControl(this);
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
