using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            ConditionBlock entry = new ConditionBlock(board);
            BlockControl b = new BlockControl(entry);
            b.Location = new Point(50, 50);
            this.Controls.Add(b);
        }
    }
}
