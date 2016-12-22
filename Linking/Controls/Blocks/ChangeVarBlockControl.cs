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
    public partial class ChangeVarBlockControl : UserControl
    {
        private static class Funcs
        {
            public static readonly Func<object, object, object> Equal = (l, r) => l;
            public static readonly Func<object, object, object> Plus = (l, r) => (dynamic)l + (dynamic)r;
        }

        public string VarName => ltextBox.Text;
        public Func<object, object, object> Delegate
        {
            get
            {
                switch(comboBox1.SelectedIndex)
                {
                    case 0:
                        return (l, r) => r;
                    case 1:
                        return (l, r) => (dynamic)l + (dynamic)r;
                    case 2:
                        return (l, r) => (dynamic)l - (dynamic)r;
                    case 3:
                        return (l, r) => (dynamic)l * (dynamic)r;
                    case 4:
                        return (l, r) => (dynamic)l / (dynamic)r;
                    case 5:
                        return (l, r) => (dynamic)l % (dynamic)r;
                    case 6:
                        return (l, r) => (dynamic)l | (dynamic)r;
                    case 7:
                        return (l, r) => (dynamic)l & (dynamic)r;
                    case 8:
                        return (l, r) => (dynamic)l ^ (dynamic)r;
                    default:
                        throw new ArgumentException("THIS SHOULD NOT BE HAPPENED");
                }
            }
            set
            {

            }
        }

        public Core.Conds.Condition.ValueType ValueType
        {
            get
            {
                switch(comboBox2.SelectedIndex)
                {
                    case 0:
                        return Core.Conds.Condition.ValueType.Str;
                    case 1:
                        return Core.Conds.Condition.ValueType.Num;
                    case 2:
                        return Core.Conds.Condition.ValueType.Bool;
                    case 3:
                        return Core.Conds.Condition.ValueType.Var;
                    default:
                        throw new ArgumentException("THIS SHOULD NOT BE HAPPENED");
                }
            }
        }
        public object Value
        {
            get
            {
                switch(ValueType)
                {
                    case Core.Conds.Condition.ValueType.Str:
                    case Core.Conds.Condition.ValueType.Var:
                        return textBox1.Text;
                    case Core.Conds.Condition.ValueType.Num:
                        return Convert.ToDouble(textBox1.Text);
                    case Core.Conds.Condition.ValueType.Bool:
                        return Convert.ToBoolean(textBox1.Text);
                    default:
                        throw new ArgumentException("THIS SHOULD NOT BE HAPPENED");
                }
            }
        }

        private ChangeVariableValueBlock _block;
        public ChangeVarBlockControl(ChangeVariableValueBlock block)
        {
            InitializeComponent();
            _block = block;
        }
    }
}
