using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Var;

namespace Linking.Core.Blocks
{
    public class CodeBlock : Block
    {
        public override Control Control
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Code { get; set; }

        public CodeBlock(Board board, Node parent = null) : base(board, parent)
        {

        }

        public override void Execute(VariableTable table)
        {
            base.Execute(table);

            // TODO: 실제 C#코드 실행
        }
    }
}
