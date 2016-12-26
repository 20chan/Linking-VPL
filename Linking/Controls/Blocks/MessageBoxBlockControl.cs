using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Blocks;
using Linking.Core.Var;

namespace Linking.Controls.Blocks
{
    public partial class MessageBoxBlockControl : UserControl
    {
        private PrintBlock _block;
        public MessageBoxBlockControl(PrintBlock block)
        {
            InitializeComponent();
            _block = block;
        }

        public string GetValue(VariableTable table)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return textBox1.Text;
            }
            else
            {
                return table.Contains(textBox1.Text) ? table[textBox1.Text].Value.ToString() : null;
            }
        }
    }
}
