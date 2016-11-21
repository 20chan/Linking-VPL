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

        public BoardControl(Board board)
        {
            InitializeComponent();

            Board = board;
        }
    }
}
