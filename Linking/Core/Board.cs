using System;
using System.Collections.Generic;
using Linking.Core.Blocks;
using Linking.Core.Var;

namespace Linking.Core
{
    public class Board : Node
    {
        /// <summary>
        /// 실행한 블럭의 개수
        /// </summary>
        public int Step { get; private set; }

        public Block Entry { get; set; }
        private Block _current;

        internal VariableTable _table = new VariableTable();
        
        public Board() : base(null)
        {
            
        }

        protected void Initialize()
        {
            _current = Entry;
            _table.Clear();
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
            _current.Execute(_table);
            _current = _current.Next;
        }

        public void PrintAllVariables()
        {
            _table.Print();
        }
    }
}
