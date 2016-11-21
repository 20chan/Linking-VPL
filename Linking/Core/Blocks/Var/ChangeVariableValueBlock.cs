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

        public string Name { get; set; }
        public Func<Board, object, object> Delegate { get; set; }

        public ChangeVariableValueBlock(Board board, string name = "", Node parent = null, Func<Board, object, object> func = null) : base(board, parent)
        {
            _linked = new Block[1];
            Name = name;
            Delegate = func;
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
            base.Execute(table);
            if (string.IsNullOrEmpty(Name))
                throw new VariableException("변수가 비어있습니다.");
            if (!table.Contains(Name))
                throw new VariableException("변수가 정의되어 있지 않습니다.");
            table[Name].Value = Delegate(this.Board, table[Name].Value);
            Next = _linked[0];
        }

        public static ChangeVariableValueBlock VarVar(Board board, string name, string opName, Func<object, object, object> func)
            => new ChangeVariableValueBlock(board, name, null, (b, v) => func(b._table[name].Value, b._table[opName].Value));

        public static ChangeVariableValueBlock VarVal(Board board, string name, object value, Func<object, object, object> func)
            => new ChangeVariableValueBlock(board, name, null, (b, v) => func(b._table[name].Value, value));

        public static ChangeVariableValueBlock VarVal(Board board, string name, object value)
             => new ChangeVariableValueBlock(board, name, null, (b, v) => value);
    }
}
