namespace Linking.Controls.Blocks
{
    partial class ConditionBlockControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.추가AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상수부울BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조건문CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.작다ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.같다면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.작다면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.크다면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.작거나같다면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.크거나같다면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.논리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "만약";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이면";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(38, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 35);
            this.panel1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가AToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // 추가AToolStripMenuItem
            // 
            this.추가AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상수부울BToolStripMenuItem,
            this.조건문CToolStripMenuItem});
            this.추가AToolStripMenuItem.Name = "추가AToolStripMenuItem";
            this.추가AToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.추가AToolStripMenuItem.Text = "추가(&A)";
            // 
            // 상수부울BToolStripMenuItem
            // 
            this.상수부울BToolStripMenuItem.Name = "상수부울BToolStripMenuItem";
            this.상수부울BToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.상수부울BToolStripMenuItem.Text = "상수 부울(&B)";
            this.상수부울BToolStripMenuItem.Click += new System.EventHandler(this.상수부울BToolStripMenuItem_Click);
            // 
            // 조건문CToolStripMenuItem
            // 
            this.조건문CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.작다ToolStripMenuItem,
            this.논리ToolStripMenuItem});
            this.조건문CToolStripMenuItem.Name = "조건문CToolStripMenuItem";
            this.조건문CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.조건문CToolStripMenuItem.Text = "조건문(&C)";
            this.조건문CToolStripMenuItem.Click += new System.EventHandler(this.조건문CToolStripMenuItem_Click);
            // 
            // 작다ToolStripMenuItem
            // 
            this.작다ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.같다면ToolStripMenuItem,
            this.작다면ToolStripMenuItem,
            this.크다면ToolStripMenuItem,
            this.작거나같다면ToolStripMenuItem,
            this.크거나같다면ToolStripMenuItem});
            this.작다ToolStripMenuItem.Name = "작다ToolStripMenuItem";
            this.작다ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.작다ToolStripMenuItem.Text = "비교";
            // 
            // 같다면ToolStripMenuItem
            // 
            this.같다면ToolStripMenuItem.Name = "같다면ToolStripMenuItem";
            this.같다면ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.같다면ToolStripMenuItem.Text = "같다면";
            this.같다면ToolStripMenuItem.Click += new System.EventHandler(this.같다면ToolStripMenuItem_Click);
            // 
            // 작다면ToolStripMenuItem
            // 
            this.작다면ToolStripMenuItem.Name = "작다면ToolStripMenuItem";
            this.작다면ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.작다면ToolStripMenuItem.Text = "작다면";
            // 
            // 크다면ToolStripMenuItem
            // 
            this.크다면ToolStripMenuItem.Name = "크다면ToolStripMenuItem";
            this.크다면ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.크다면ToolStripMenuItem.Text = "크다면";
            // 
            // 작거나같다면ToolStripMenuItem
            // 
            this.작거나같다면ToolStripMenuItem.Name = "작거나같다면ToolStripMenuItem";
            this.작거나같다면ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.작거나같다면ToolStripMenuItem.Text = "작거나 같다면";
            // 
            // 크거나같다면ToolStripMenuItem
            // 
            this.크거나같다면ToolStripMenuItem.Name = "크거나같다면ToolStripMenuItem";
            this.크거나같다면ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.크거나같다면ToolStripMenuItem.Text = "크거나 같다면";
            // 
            // 논리ToolStripMenuItem
            // 
            this.논리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNDToolStripMenuItem,
            this.oRToolStripMenuItem,
            this.nOTToolStripMenuItem});
            this.논리ToolStripMenuItem.Name = "논리ToolStripMenuItem";
            this.논리ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.논리ToolStripMenuItem.Text = "논리";
            // 
            // aNDToolStripMenuItem
            // 
            this.aNDToolStripMenuItem.Name = "aNDToolStripMenuItem";
            this.aNDToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aNDToolStripMenuItem.Text = "AND";
            // 
            // oRToolStripMenuItem
            // 
            this.oRToolStripMenuItem.Name = "oRToolStripMenuItem";
            this.oRToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.oRToolStripMenuItem.Text = "OR";
            // 
            // nOTToolStripMenuItem
            // 
            this.nOTToolStripMenuItem.Name = "nOTToolStripMenuItem";
            this.nOTToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.nOTToolStripMenuItem.Text = "NOT";
            // 
            // ConditionBlockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConditionBlockControl";
            this.Size = new System.Drawing.Size(321, 41);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 추가AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상수부울BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조건문CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 작다ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 같다면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 작다면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 크다면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 작거나같다면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 크거나같다면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 논리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTToolStripMenuItem;
    }
}
