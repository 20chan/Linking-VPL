using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linking.Core
{
    public class Board : Node
    {
        private Block _current;

        private List<Block> _palettes = new List<Block>();

        public Board() : base(null)
        {

        }

        protected void Initialize()
        {
            //_current = (Entry Block);
            throw new NotImplementedException();
        }

        public void Run()
        {
            Initialize();
            while (_current != null)
                RunStep();
        }

        public void RunStep()
        {
            _current.Execute();
            _current = _current.Next;
        }
    }
}
