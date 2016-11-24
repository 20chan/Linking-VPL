using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linking.Controls
{
    public partial class InnerBlock : UserControl
    {
        public ValueType ValueType { get; private set; }
        public BlockControl Block { get; private set; }
        public InnerBlock(ValueType type)
        {
            InitializeComponent();
            ValueType = type;
        }

        public void SetBlock(BlockControl block)
        {
            if(Block != null)
            {
                // TODO: 크기 조정 이벤트 제거
            }
            //괜찮아 다 잘될거야!
            //난 널 믿어 미래의 나!
            Block = block;
            // TODO: 크기 조정 이벤트 추가
        }
    }
}
