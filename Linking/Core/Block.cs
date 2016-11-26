namespace Linking.Core
{
    public abstract class Block : Node
    {
        public abstract System.Windows.Forms.Control Control { get; }
        public virtual System.Drawing.Size Size
            => Control.Size;

        public bool IsExecuting { get; set; }

        public Board Board { get; }
        public bool IsBreakPoint { get; set; } = false;

        protected Block[] _linked;
        public virtual Block[] LinkedBlocks
        {
            get
            {
                if (_linked == null)
                {
                    _linked = new Block[1];
                }
                return _linked;
            }
            protected set
            {
                _linked = (Block[])value.Clone();
            }
        }

        /// <summary>
        /// 다음에 실행될 블럭, 프로그램이 실행중이 아니면 null
        /// </summary>
        public Block Next { get; protected set; }

        public Block(Board board, Node parent) : base(parent)
        {
            Board = board;
            Initialize();
        }

        public void Initialize()
        {
            Next = null;
        }

        public static void Connect(Block from, Block to, int index = 0)
        {
            from.ConnectTo(to, index);
            to.ConnectFrom(from);
        }

        /// <summary>
        /// this -> block
        /// </summary>
        /// <param name="block"></param>
        protected virtual void ConnectTo(Block block, int index)
        {
            _linked[index] = block;
        }

        /// <summary>
        /// block -> this
        /// </summary>
        /// <param name="block"></param>
        protected virtual void ConnectFrom(Block block)
        {

        }

        public virtual void Execute(Var.VariableTable table)
        {
            IsExecuting = true;
        }
    }
}
