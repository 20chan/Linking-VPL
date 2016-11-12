using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linking.Core.Blocks.Var
{
    public class ChangeVariableValueBlock : Block
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

        public Core.Var.Variable Variable { get; set; }

        public ChangeVariableValueBlock(Board board, Node parent = null) : base(board, parent)
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
            if (Variable == null)
                throw new VariableException("변수가 비어있습니다.");
            if (!table.Contains(Variable))
                throw new VariableException("변수가 정의되어 있지 않습니다.");
            table[Variable.Name] = Variable;
            Next = _linked[0];
            base.Execute(table);
        }
    }
}
