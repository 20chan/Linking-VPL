using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linking.Core.Blocks
{
    public class MessageBoxBlock : Block
    {
        private Controls.Blocks.MessageBoxBlockControl _control;
        public override Control Control => _control;

        public MessageBoxBlock(Board board, Node parent = null) : base(board, parent)
        {
            _control = new Controls.Blocks.MessageBoxBlockControl(this);
        }

        public override void Execute(Core.Var.VariableTable table)
        {
            base.Execute(table);
            Next = LinkedBlocks[0];

            var result = _control.GetValue(table);
            if (result == null)
                MessageBox.Show("변수가 존재하지 않습니다", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(result, "출력");
        }
    }
}
