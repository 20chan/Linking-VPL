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

            _control.Printed += _control_Printed;

            this.KeyDown += Form1_KeyDown;
            KeyPreview = true;

            EntryBlock entry = new EntryBlock(_board);
            entry.Location = new Point(00, 50);
            _control.AddBlocks(entry);
            _board.Entry = entry;
        }

        private void ScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _control.Location = new Point(-hScrollBar1.Value * 30, -vScrollBar1.Value * 30);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control) return;
            if (e.KeyCode == Keys.Left && hScrollBar1.Value != hScrollBar1.Minimum)
                hScrollBar1.Value -= 1;
            else if (e.KeyCode == Keys.Right && hScrollBar1.Value != hScrollBar1.Maximum)
                hScrollBar1.Value += 1;
            if (e.KeyCode == Keys.Up && vScrollBar1.Value != vScrollBar1.Minimum)
                vScrollBar1.Value -= 1;
            else if (e.KeyCode == Keys.Down && vScrollBar1.Value != vScrollBar1.Maximum)
                vScrollBar1.Value += 1;
            ScrollBar1_Scroll(null, null);
        }

        private void _control_Printed(string message)
        {
            if (message == null)
                textBox1.AppendText("에러\r\n");
            else
                textBox1.AppendText(message + "\r\n");
        }
    }
}
