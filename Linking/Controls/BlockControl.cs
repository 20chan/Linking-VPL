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

namespace Linking.Controls
{
    public partial class BlockControl : UserControl
    {
        private Block _block;
        public BlockControl(Block block)
        {
            InitializeComponent();
            _block = block;
        }
    }
}
