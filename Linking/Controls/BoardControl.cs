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

        public BoardControl(Board board)
        {
            InitializeComponent();
            _blocks = new List<Block>();
            Board = board;
            _pen = new Pen(Color.Red, 8f);
            _pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            _pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
        }

        private Pen _pen;
        protected override void OnPaint(PaintEventArgs e)
        {
            foreach(var b in _blocks)
            {
                foreach(var lb in b.LinkedBlocks)
                {
                    if(lb != null)
                        e.Graphics.DrawLine(_pen, 
                            b.Location.X + b.OuterControl.Width, 
                            b.Location.Y + b.OuterControl.Height / 2, 
                            lb.Location.X,
                            lb.Location.Y + lb.OuterControl.Height / 2);
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

            /* 이거 드래그로 컨트롤 움직이는거 구현해야겠찌..
            bc.MouseDown += (b, d) => { };
            bc.MouseMove += (b, d) => { };
            */

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
            
        }

        private void 값VToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            Board.Run();
        }

        private void 출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxBlock block = new MessageBoxBlock(Board, Board);
            block.Location = _lastRightClicked;
            AddBlock(block);
        }
    }
}
