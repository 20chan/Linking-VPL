namespace Linking.Controls
{
    partial class BoardControl
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.추가AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.변수VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선언DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.값VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조건문CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.같다면TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다르다면FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가AToolStripMenuItem,
            this.실행RToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // 추가AToolStripMenuItem
            // 
            this.추가AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.변수VToolStripMenuItem,
            this.조건문CToolStripMenuItem});
            this.추가AToolStripMenuItem.Name = "추가AToolStripMenuItem";
            this.추가AToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.추가AToolStripMenuItem.Text = "추가(&A)";
            // 
            // 변수VToolStripMenuItem
            // 
            this.변수VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선언DToolStripMenuItem,
            this.값VToolStripMenuItem});
            this.변수VToolStripMenuItem.Name = "변수VToolStripMenuItem";
            this.변수VToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.변수VToolStripMenuItem.Text = "변수(&V)";
            // 
            // 선언DToolStripMenuItem
            // 
            this.선언DToolStripMenuItem.Name = "선언DToolStripMenuItem";
            this.선언DToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.선언DToolStripMenuItem.Text = "선언(&D)";
            this.선언DToolStripMenuItem.Click += new System.EventHandler(this.선언DToolStripMenuItem_Click);
            // 
            // 값VToolStripMenuItem
            // 
            this.값VToolStripMenuItem.Name = "값VToolStripMenuItem";
            this.값VToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.값VToolStripMenuItem.Text = "값(&V)";
            this.값VToolStripMenuItem.Click += new System.EventHandler(this.값VToolStripMenuItem_Click);
            // 
            // 조건문CToolStripMenuItem
            // 
            this.조건문CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.같다면TToolStripMenuItem,
            this.다르다면FToolStripMenuItem});
            this.조건문CToolStripMenuItem.Name = "조건문CToolStripMenuItem";
            this.조건문CToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.조건문CToolStripMenuItem.Text = "조건문(&C)";
            this.조건문CToolStripMenuItem.Click += new System.EventHandler(this.조건문CToolStripMenuItem_Click);
            // 
            // 같다면TToolStripMenuItem
            // 
            this.같다면TToolStripMenuItem.Name = "같다면TToolStripMenuItem";
            this.같다면TToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.같다면TToolStripMenuItem.Text = "같다면(&T)";
            this.같다면TToolStripMenuItem.Click += new System.EventHandler(this.같다면TToolStripMenuItem_Click);
            // 
            // 다르다면FToolStripMenuItem
            // 
            this.다르다면FToolStripMenuItem.Name = "다르다면FToolStripMenuItem";
            this.다르다면FToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.다르다면FToolStripMenuItem.Text = "다르다면(&F)";
            this.다르다면FToolStripMenuItem.Click += new System.EventHandler(this.다르다면FToolStripMenuItem_Click);
            // 
            // 실행RToolStripMenuItem
            // 
            this.실행RToolStripMenuItem.Name = "실행RToolStripMenuItem";
            this.실행RToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.실행RToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.실행RToolStripMenuItem.Text = "실행(&R)";
            this.실행RToolStripMenuItem.Click += new System.EventHandler(this.실행RToolStripMenuItem_Click);
            // 
            // BoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "BoardControl";
            this.Size = new System.Drawing.Size(658, 416);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BoardControl_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 추가AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 변수VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조건문CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선언DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 값VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 같다면TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다르다면FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행RToolStripMenuItem;
    }
}
