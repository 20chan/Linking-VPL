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

        public Size MinSize { get; set; }

        public InnerBlock(ValueType type, Size minSize)
        {
            InitializeComponent();
            ValueType = type;
            MinSize = minSize;
        }

        /// <summary>
        /// 바깥쪽의 블럭컨트롤에서 SizeChanged이벤트를 받아서 꼭 전체 사이즈 변경을 구현해야한다.
        /// </summary>
        /// <param name="block"></param>
        public void SetBlock(BlockControl block)
        {
            Block = block;
            if (MinSize.Width < block.Block.Size.Width || MinSize.Height < block.Block.Size.Height)
                this.Size = block.Block.Size;
            else
                this.Size = MinSize;
        }
    }
}
