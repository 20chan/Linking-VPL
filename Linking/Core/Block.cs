using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linking.Core
{
    public abstract class Block : Node
    {
        public Block(Node parent) : base(parent)
        {

        }

        public virtual void Execute()
        {

        }
    }
}
