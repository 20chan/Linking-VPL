using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;

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

        // TODO: Condition클래스로 대체
        public virtual Func<bool> Condition { get; set; }

        public ConditionBlock(Board board, Node parent = null, Func<bool> condition = null) : base(board, parent)
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

            if (Condition())
                Next = _linked[0];
            else
                Next = _linked[1];
            base.Execute(table);
        }
    }
}
