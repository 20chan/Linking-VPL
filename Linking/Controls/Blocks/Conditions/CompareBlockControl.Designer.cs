namespace Linking.Controls.Blocks.Conditions
{
    partial class CompareBlockControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lcomboBox = new System.Windows.Forms.ComboBox();
            this.ltextBox = new System.Windows.Forms.TextBox();
            this.rtextBox = new System.Windows.Forms.TextBox();
            this.rcomboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lcomboBox
            // 
            this.lcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lcomboBox.FormattingEnabled = true;
            this.lcomboBox.Items.AddRange(new object[] {
            "문자열",
            "상수",
            "부울",
            "변수"});
            this.lcomboBox.Location = new System.Drawing.Point(3, 3);
            this.lcomboBox.Name = "lcomboBox";
            this.lcomboBox.Size = new System.Drawing.Size(152, 20);
            this.lcomboBox.TabIndex = 0;
            this.lcomboBox.Tag = "l";
            // 
            // ltextBox
            // 
            this.ltextBox.Location = new System.Drawing.Point(3, 29);
            this.ltextBox.Name = "ltextBox";
            this.ltextBox.Size = new System.Drawing.Size(152, 21);
            this.ltextBox.TabIndex = 1;
            // 
            // rtextBox
            // 
            this.rtextBox.Location = new System.Drawing.Point(234, 29);
            this.rtextBox.Name = "rtextBox";
            this.rtextBox.Size = new System.Drawing.Size(152, 21);
            this.rtextBox.TabIndex = 3;
            // 
            // rcomboBox
            // 
            this.rcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rcomboBox.FormattingEnabled = true;
            this.rcomboBox.Items.AddRange(new object[] {
            "문자열",
            "상수",
            "부울",
            "변수"});
            this.rcomboBox.Location = new System.Drawing.Point(234, 3);
            this.rcomboBox.Name = "rcomboBox";
            this.rcomboBox.Size = new System.Drawing.Size(152, 20);
            this.rcomboBox.TabIndex = 2;
            this.rcomboBox.Tag = "r";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "==",
            "<",
            ">",
            "<=",
            ">=",
            "!="});
            this.comboBox1.Location = new System.Drawing.Point(161, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // CompareBlockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rtextBox);
            this.Controls.Add(this.rcomboBox);
            this.Controls.Add(this.ltextBox);
            this.Controls.Add(this.lcomboBox);
            this.Name = "CompareBlockControl";
            this.Size = new System.Drawing.Size(393, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lcomboBox;
        private System.Windows.Forms.TextBox ltextBox;
        private System.Windows.Forms.TextBox rtextBox;
        private System.Windows.Forms.ComboBox rcomboBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
