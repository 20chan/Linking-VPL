using System;
using System.Collections.Generic;
using Linking.Core.Blocks;

namespace Linking.Core
{
    public class Board : Node
    {
        /// <summary>
        /// 실행한 블럭의 개수
        /// </summary>
        public int Step { get; private set; }

        private Block _current;
        private List<Block> _palettes = new List<Block>();
        
        public Board() : base(null)
        {
            
        }

        protected void Initialize()
        {
            _current = _palettes.Find(b => b is EntryBlock);
        }

        public void Run()
        {
            Initialize();
            while (_current != null)
            {
                if (_current.IsBreakPoint)
                    break;
                RunStep();
            }
        }

        public void RunStep()
        {
            _current.Execute();
            _current = _current.Next;
        }
    }
}
