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
                Condition result;
                VarVal current = GetCurrentVarVal();
                switch(comboBox1.SelectedIndex)
                {
                    case 0: // ==
                        if (current.HasFlag(VarVal.LVal))
                        {
                            if (current.HasFlag(VarVal.RVal))
                                result = Condition.ValEqualValCondition(_block.Board);
                            else
                                result = Condition.VarEqualVarCondition(_block.Board);

                            switch(lcomboBox.SelectedIndex)
                            {
                                case 0:
                                case 3:
                                    result.L = ltextBox.Text;
                                    break;
                                case 1:
                                    result.L = Convert.ToDouble(ltextBox.Text);
                                    break;
                                case 2:
                                    result.L = Convert.ToBoolean(ltextBox.Text);
                                    break;
                            }
                            switch(rcomboBox.SelectedIndex)
                            {

                            }
                        }
                        else
                        {
                            if (current.HasFlag(VarVal.RVal))
                                result = Condition.ValEqualValCondition(_block.Board);
                            else
                                result = Condition.VarEqualVarCondition(_block.Board);
                        }
                        break;
                    case 1: // <
                        break;
                    case 2: // >
                        break;
                    case 3: // <=
                        break;
                    case 4: // >=
                        break;
                    case 5: // !=
                        break;
                }
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
