
using System.Windows.Forms;
using Linking.Core.Blocks;

namespace Linking.Controls.Blocks
{
    public partial class ConstBoolBlockControl : UserControl, IBoolBlockControl
    {
        private bool _value = true;
        public bool Value
        {
            get
            {
                System.Diagnostics.Debug.WriteLine(Handle);
                return _value;
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

            comboBox1.Items.Add("참");
            comboBox1.Items.Add("거짓");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(Handle);
            _value = ((ComboBox)sender).SelectedIndex == 0;
        }
    }
}
