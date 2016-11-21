using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linking.Core.Blocks
{
    public abstract class ValueBlock : Block
    {
        public ValueBlock(Board board, Node parent = null) : base(board, parent)
        {

        }
    }
}
