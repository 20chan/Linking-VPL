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
        private Controls.Blocks.ChangeVarBlockControl _control;
        public override Control Control => _control;

        public string Name
        {
            get { return _control.VarName; }
            set { }
        }
        public Func<object, object, object> Delegate
        {
            get { return _control.Delegate; }
            set { }
        }

        public ChangeVariableValueBlock(Board board, Node parent = null, string name = "", Func<object, object, object> func = null) : base(board, parent)
        {
            _linked = new Block[1];
            Name = name;
            Delegate = func;
            _control = new Controls.Blocks.ChangeVarBlockControl(this);
        }

        private object RValue(VariableTable table)
        {
            if (_control.ValueType == Conds.Condition.ValueType.Var)
                return table[_control.Value.ToString()];
            else
                return _control.Value;
        }

        public override void Execute(VariableTable table)
        {
            base.Execute(table);
            if (string.IsNullOrEmpty(Name))
                throw new VariableException("변수가 비어있습니다.");
            if (!table.Contains(Name))
                throw new VariableException("변수가 정의되어 있지 않습니다.");
            table[Name].Value = Delegate(table[Name].Value, RValue(table));
            Next = _linked[0];
        }
    }
}