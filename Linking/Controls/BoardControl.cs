using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core;
using Linking.Core.Blocks;
using Linking.Core.Blocks.Var;
using Linking.Controls.Blocks;

namespace Linking.Controls
{
    public partial class BoardControl : UserControl
    {
        public Board Board { get; private set; }
        private List<Block> _blocks;

        private bool _isLinking;
        private BlockControl _linking;
        private int _linkIndex;

        public event Action<string> Printed;

        public BoardControl(Board board)
        {
            InitializeComponent();
            _blocks = new List<Block>();
            Board = board;
            _pen = new Pen(Color.Red, 8f);
            _pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            _pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            DoubleBuffered = true;
        }

        private Pen _pen;
        protected override void OnPaint(PaintEventArgs e)
        {
            foreach(var b in _blocks)
            {
                for(int i = 0; i < b.LinkedBlocks.Length; i++)
                {
                    var lb = b.LinkedBlocks[i];
                    if (i == 0)
                        _pen.Color = Color.Red;
                    else if (i == 1)
                        _pen.Color = Color.Blue;
                    else if (i == 1)
                        _pen.Color = Color.Green;
                    else
                        _pen.Color = Color.Pink;
                    if(lb != null)
                        e.Graphics.DrawLine(_pen, 
                            b.OuterControl.Location.X + b.OuterControl.Width, 
                            b.OuterControl.Location.Y + b.OuterControl.Height / 2, 
                            lb.OuterControl.Location.X,
                            lb.OuterControl.Location.Y + lb.OuterControl.Height / 2);
                }
            }
            base.OnPaint(e);
        }

        public void AddBlock(Block block)
        {
            block.Parent = this.Board;
            
            _blocks.Add(block);

            block.OuterControl = new BlockControl(block);
            block.OuterControl.Location = block.Location;
            block.OuterControl.TriedToLinkIn += Bc_TriedToLinkIn;
            block.OuterControl.TriedToLinkOut += Bc_TriedToLinkOut;
            block.LocationChanged += (a, b) => block.OuterControl.Location = block.Location;
            block.OuterControl.NeedInvalidate += () => Invalidate();

            if (block is PrintBlock)
                ((PrintBlock)block).Printed += (s) => Printed?.Invoke(s);
            this.Controls.Add(block.OuterControl);
        }
        
        public void AddBlocks(params Block[] blocks)
        {
            foreach (var b in blocks)
                AddBlock(b);
        }

        private void Bc_TriedToLinkIn(object sender, EventArgs e)
        {
            if(!_isLinking)
            {
                _isLinking = false;
                return;
            }

            _isLinking = false;
            Block.Connect(_linking.Block, (sender as BlockControl).Block, _linkIndex);

            Invalidate();
        }

        private void Bc_TriedToLinkOut(object sender, EventArgs e)
        {
            if (_isLinking)
            {
                _isLinking = false;
                return;
            }

            _isLinking = true;
            _linking = sender as BlockControl;
            _linkIndex = (e as LinkOutEventArgs).Index;
        }

        Point _lastRightClicked;
        private void BoardControl_MouseDown(object sender, MouseEventArgs e)
        {
            _lastRightClicked = new Point(e.X, e.Y);
        }

        private void 선언DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeclareVariableBlock block = new DeclareVariableBlock(Board, Board);
            block.Location = _lastRightClicked;
            AddBlock(block);
        }

        private void 값VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeVariableValueBlock block = new ChangeVariableValueBlock(Board, Board);
            block.Location = _lastRightClicked;
            AddBlock(block);
        }

        private void 같다면TToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 다르다면FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConditionBlock block = new ConditionBlock(Board, Board);
            block.Control.Location = _lastRightClicked;
            AddBlock(block);
        }

        private void 조건문CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConditionBlock block = new ConditionBlock(Board, Board);
            block.Location = _lastRightClicked;
            AddBlock(block);

            this.contextMenuStrip1.Close();
        }

        private void 실행RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Board.Run();
            }
            catch (ArgumentNullException ex)
            {
                Printed?.Invoke(ex.Message);
            }
        }

        private void 출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintBlock block = new PrintBlock(Board, Board);
            block.Location = _lastRightClicked;
            AddBlock(block);
        }
    }
}
