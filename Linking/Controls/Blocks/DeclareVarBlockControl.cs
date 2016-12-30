using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Blocks.Var;
using Linking.Core.Var;

namespace Linking.Controls.Blocks
{
    public partial class DeclareVarBlockControl : UserControl
    {
        public Variable Variable
        {
            get
            {
                if(comboBox1.SelectedIndex == -1)
                {
                    throw new ArgumentNullException("변수 타입을 정하지 않았습니다");
                }
                object value = comboBox1.SelectedIndex == 0 ? textBox2.Text :
                    (comboBox1.SelectedIndex == 1 ? (object)Convert.ToDouble(textBox2.Text) : Convert.ToBoolean(textBox2.Text));
                return new Variable(textBox1.Text, value);
            }
            set
            {
                textBox1.Text = value.Name;
                textBox2.Text = value.Value.ToString();

                if (value.Value is string)
                    comboBox1.SelectedIndex = 0;
                else if (value.Value is double)
                    comboBox1.SelectedIndex = 1;
                else if (value.Value is bool)
                    comboBox1.SelectedIndex = 2;
                else
                    throw new ArgumentException("Not string, double, bool");
            }
        }
        private DeclareVariableBlock _block;
        public DeclareVarBlockControl(DeclareVariableBlock block)
        {
            InitializeComponent();
            _block = block;
        }
    }
}
