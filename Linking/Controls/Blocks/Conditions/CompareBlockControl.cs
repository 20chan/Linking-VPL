using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linking.Core.Conds;

namespace Linking.Controls.Blocks.Conditions
{
    public partial class CompareBlockControl : UserControl
    {
        public Condition Condition
        {
            get
            {
                var result = new Condition();
                var current = GetCurrentVarVal();

                if(current.HasFlag(VarVal.LVal))
                {
                    result.LType = Condition.ValueType.Val;
                    result.L = lcomboBox.SelectedIndex == 0 ? ltextBox.Text : 
                        (lcomboBox.SelectedIndex == 1 ? (object)Convert.ToDouble(ltextBox.Text) : Convert.ToBoolean(ltextBox.Text));
                }
                else
                {
                    result.LType = Condition.ValueType.Var;
                    result.L = ltextBox.Text;
                }

                if (current.HasFlag(VarVal.RVal))
                {
                    result.RType = Condition.ValueType.Val;
                    result.R = rcomboBox.SelectedIndex == 0 ? rtextBox.Text :
                        (rcomboBox.SelectedIndex == 1 ? (object)Convert.ToDouble(ltextBox.Text) : Convert.ToBoolean(ltextBox.Text));
                }
                else
                {
                    result.RType = Condition.ValueType.Var;
                    result.R = rtextBox.Text;
                }

                switch(comboBox1.SelectedIndex)
                {
                    case 0: //==
                        result.Compare = Condition.CompareType.Equal;
                        break;
                    case 1: //<
                        result.Compare = Condition.CompareType.Smaller;
                        break;
                    case 2: //>
                        result.Compare = Condition.CompareType.Bigger;
                        break;
                    case 3: //<=
                        result.Compare = Condition.CompareType.SmallerEqual;
                        break;
                    case 4: //>=
                        result.Compare = Condition.CompareType.BiggerEqual;
                        break;
                    case 5: //!=
                        result.Compare = Condition.CompareType.NotEqual;
                        break;
                }

                return result;
            }
        }

        Core.Blocks.ConditionBoolBlock _block;
        public CompareBlockControl(Core.Blocks.ConditionBoolBlock block)
        {
            InitializeComponent();
            _block = block;
            lcomboBox.SelectedIndex = rcomboBox.SelectedIndex = comboBox1.SelectedIndex = 0;
        }

        private void lcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            if (c.Tag.ToString() == "l")
                ltextBox.ReadOnly = c.SelectedIndex == 3;
            else if (c.Tag.ToString() == "r")
                rtextBox.ReadOnly = c.SelectedIndex == 3;
            else
                throw new ArgumentException("THIS SHOULD NOT HAPPENED...");
        }
        
        [Flags]
        private enum VarVal
        {
            LVar = 1,
            LVal = 2,
            RVar = 4,
            RVal = 8
        }

        private VarVal GetCurrentVarVal()
        {
            VarVal result = 0;
            if (lcomboBox.SelectedIndex == 3)
                result |= VarVal.LVar;
            else
                result |= VarVal.LVal;

            if (rcomboBox.SelectedIndex == 3)
                result |= VarVal.RVar;
            else
                result |= VarVal.RVal;
            return result;
        }
    }
}
