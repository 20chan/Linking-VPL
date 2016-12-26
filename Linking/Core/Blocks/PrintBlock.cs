using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linking.Core.Blocks
{
    public class PrintBlock : Block
    {
        private Controls.Blocks.MessageBoxBlockControl _control;
        public override Control Control => _control;

        public event Action<string> Printed;

        public PrintBlock(Board board, Node parent = null) : base(board, parent)
        {
            _control = new Controls.Blocks.MessageBoxBlockControl(this);
        }

        public override void Execute(Core.Var.VariableTable table)
        {
            base.Execute(table);
            Next = LinkedBlocks[0];

            Printed?.Invoke(_control.GetValue(table));
        }
    }
}
