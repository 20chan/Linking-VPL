namespace Linking.Core
{
    public abstract class Block : Node
    {
        public abstract System.Windows.Forms.Control Control { get; }
        protected abstract System.Windows.Forms.Control CreateControlInstance();

        public Board Board { get; }

        protected NodeCollection[] _linked;
        public virtual NodeCollection[] LinkedBlocks
        {
            get
            {
                if (_linked == null)
                {
                    _linked = new NodeCollection[1];
                    _linked[0] = CreateNodesInstance();
                }
                return _linked;
            }
            protected set
            {

            }
        }

        /// <summary>
        /// 다음에 실행될 블럭, 프로그램이 실행중이 아니면 null
        /// </summary>
        public Block Next { get; private set; }

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
            _linked[index].Add(block);
        }

        /// <summary>
        /// block -> this
        /// </summary>
        /// <param name="block"></param>
        protected virtual void ConnectFrom(Block block)
        {

        }

        public virtual void Execute()
        {

        }
    }
}
