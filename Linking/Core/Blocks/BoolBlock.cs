using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;
using Linking.Core.Conds;

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
        public override Control Control
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Value { get; set; }
        public ConstBoolBlock(Board board, Node parent) : base(board, parent)
        {

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
        private TextBox _textBox = new TextBox();
        public override Control Control
        {
            get
            {
                return _textBox;
            }
        }

        public string Name
        {
            get { return _textBox.Text; }
            set { _textBox.Text = value; }
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
        public override Control Control
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Condition Condition { get; set; }
        public ConditionBoolBlock(Board board, Node parent, Condition cond) : base(board, parent)
        {
            this.Condition = cond;
        }

        public override bool GetValue(VariableTable table)
            => Condition.Check(Board);
    }
}
