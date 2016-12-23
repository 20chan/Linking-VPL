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
        private Board _board;
        private BoardControl _control;
        public Form1()
        {
            //이것도 커밋해 보시지!!
            InitializeComponent();
            _board = new Board();
            _control = new BoardControl(_board);
            _control.Location = new Point(0, 0);
            _control.Size = new Size(hScrollBar1.Maximum * 30 + Width, vScrollBar1.Maximum * 30 + Height);
            this.Controls.Add(_control);

            EntryBlock entry = new EntryBlock(_board);
            entry.Location = new Point(00, 50);
            _control.AddBlocks(entry);
            _board.Entry = entry;
        }

        private void ScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _control.Location = new Point(-hScrollBar1.Value * 30, -vScrollBar1.Value * 30);
        }
    }
}
