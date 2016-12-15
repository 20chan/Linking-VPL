
using System.Windows.Forms;
using Linking.Core.Blocks;

namespace Linking.Controls.Blocks
{
    public partial class ConstBoolBlockControl : UserControl, IBoolBlockControl
    {
        public bool Value
        {
            get
            {
                return this.comboBox1.SelectedIndex == 0;
            }
            set
            {
                this.comboBox1.SelectedIndex = value ? 0 : 1;
            }
        }
        private ConstBoolBlock _block;
        public ConstBoolBlockControl(ConstBoolBlock block)
        {
            InitializeComponent();
            _block = block;
        }
    }
}
