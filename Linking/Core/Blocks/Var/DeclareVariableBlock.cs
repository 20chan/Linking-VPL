using System;
using Linking.Core.Var;
using System.Windows.Forms;

namespace Linking.Core.Blocks.Var
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

        public Variable Variable { get; set; }
        
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

        public override void Execute(VariableTable table)
        {
            if (Variable == null)
                throw new VariableException("변수가 비어있습니다.");
            if (table.Contains(Variable))
                throw new VariableException("이미 같은 이름의 변수가 정의되어 있습니다.");
            table.Add(Variable);
            Next = _linked[0];
            base.Execute(table);
        }
    }
}