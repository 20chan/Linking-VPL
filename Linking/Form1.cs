using System;
using System.Drawing;
using System.Windows.Forms;
using Linking.Controls;
using Linking.Core;
using Linking.Core.Blocks;

namespace Linking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //이것도 커밋해 보시지!!
            InitializeComponent();
            Board board = new Board();
            BoardControl boardCtrl = new BoardControl(board);
            boardCtrl.Dock = DockStyle.Fill;
            this.Controls.Add(boardCtrl);

            EntryBlock entry = new EntryBlock(board);
            entry.Location = new Point(00, 50);
            boardCtrl.AddBlocks(entry);
            board.Entry = entry;
        }
    }
}
