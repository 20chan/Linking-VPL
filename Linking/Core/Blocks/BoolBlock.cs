using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;
using Linking.Core.Conds;
using Linking.Controls.Blocks.Conditions;

namespace Linking.Core.Blocks
{
    public abstract class BoolBlock : ValueBlock
    {
        public BoolBlock(Board board, Node parent = null) : base(board, parent)
        {

        }

        public abstract bool GetValue(VariableTable table);
    }

    public class ConstBoolBlock : BoolBlock
    {
        private Controls.Blocks.Conditions.ConstBoolBlockControl _control;
        public override Control Control => _control;

        public bool Value
        {
            get { return ((Controls.Blocks.Conditions.ConstBoolBlockControl)Control).Value; }
            set { ((Controls.Blocks.Conditions.ConstBoolBlockControl)Control).Value = value; }
        }
        public ConstBoolBlock(Board board, Node parent) : base(board, parent)
        {
            _control = new Controls.Blocks.Conditions.ConstBoolBlockControl(this);
        }

        public override bool GetValue(VariableTable table)
            => Value;

        public override void Execute(VariableTable table)
        {
            base.Execute(table);
            throw new NotSupportedException("BoolBlock cannot be Execute");
        }
    }

    public class VarBoolBlock : BoolBlock
    {
        private VarBoolBlockControl _control;
        public override Control Control => _control;

        public string Name
        {
            get { return _control.VarName; }
            set { _control.VarName = value; }
        }
        public VarBoolBlock(Board board, Node parent, string name = "") : base(board, parent)
        {
            Name = name;
        }

        public override bool GetValue(VariableTable table)
        {
            return (bool)table[Name].Value;
        }
    }

    public class ConditionBoolBlock : BoolBlock
    {
        private CompareBlockControl _control;
        public override Control Control => _control;

        public Condition Condition
        {
            get { return _control.Condition; }
            set { _control.Condition = value; }
        }
        public ConditionBoolBlock(Board board, Node parent) : base(board, parent)
        {
            _control = new CompareBlockControl(this);
        }

        public override bool GetValue(VariableTable table)
            => Condition.Check(table);
    }
}
