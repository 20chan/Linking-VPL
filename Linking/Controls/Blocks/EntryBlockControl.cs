using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Blocks;

namespace Linking.Controls.Blocks
{
    public partial class EntryBlockControl : UserControl
    {
        private EntryBlock _block;
        public EntryBlockControl(EntryBlock block)
        {
            InitializeComponent();
            _block = block;

        }
    }
}
