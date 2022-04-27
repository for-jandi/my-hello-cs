namespace MyHelloCs
{
    partial class FormMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGreeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGreeting
            // 
            this.BtnGreeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGreeting.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGreeting.Location = new System.Drawing.Point(222, 92);
            this.BtnGreeting.Name = "BtnGreeting";
            this.BtnGreeting.Size = new System.Drawing.Size(310, 132);
            this.BtnGreeting.TabIndex = 0;
            this.BtnGreeting.Text = "환영 인사 버튼";
            this.BtnGreeting.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 768);
            this.Controls.Add(this.BtnGreeting);
            this.Name = "FormMain";
            this.Text = "Joohoney";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGreeting;
    }
}

