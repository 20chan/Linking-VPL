using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;

namespace Linking.Core.Blocks
{
    public abstract class IntegerBlock : ValueBlock
    {
        public IntegerBlock(Board board, Node parent = null) : base(board, parent)
        {

        }

        public abstract int GetValue(VariableTable table);
    }

    public class ConstIntegerBlock : IntegerBlock
    {
        public override Control Control
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Value { get; set; }
        public ConstIntegerBlock(Board board, Node parent, int value = 0) : base(board, parent)
        {
            Value = value;
        }

        public override int GetValue(VariableTable table)
            => Value;

        public override void Execute(VariableTable table)
        {
            base.Execute(table);
            throw new NotSupportedException("IntBlock cannot be Execute");
        }
    }

    public class VarIntegerBlock : IntegerBlock
    {
        public override Control Control
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name { get; set; }

        public VarIntegerBlock(Board board, Node parent, string name = "") : base(board, parent)
        {
            Name = name;
        }

        public override int GetValue(VariableTable table)
        {
            return (int)table[Name].Value;
        }
    }
}
