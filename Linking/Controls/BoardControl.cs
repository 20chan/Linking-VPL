using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core;

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
        }

        public void AddBlock(Block block)
        {
            block.Parent = this.Board;

            BlockControl bc = new BlockControl(block);
            _blocks.Add(block);
            bc.Location = block.Location;
            bc.TriedToLinkIn += Bc_TriedToLinkIn;
            bc.TriedToLinkOut += Bc_TriedToLinkOut;
            block.LocationChanged += (a, b) => bc.Location = block.Location;

            /* 이거 드래그로 컨트롤 움직이는거 구현해야겠찌..
            bc.MouseDown += (b, d) => { };
            bc.MouseMove += (b, d) => { };
            */

            this.Controls.Add(bc);
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
    }
}
