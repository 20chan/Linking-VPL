using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;

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

        public string Name { get; set; }
        public Func<Variable, Variable> Delegate { get; set; }

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

        public override void Execute(VariableTable table)
        {
            if (string.IsNullOrEmpty(Name))
                throw new VariableException("변수가 비어있습니다.");
            if (!table.Contains(Name))
                throw new VariableException("변수가 정의되어 있지 않습니다.");
            table[Name] = Delegate(table[Name]);
            Next = _linked[0];
            base.Execute(table);
        }
    }
}
