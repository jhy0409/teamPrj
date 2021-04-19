
namespace teamProject
{
    partial class Form1
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
            this.btn_mainDrugComp = new System.Windows.Forms.Button();
            this.btn_mainDrugs = new System.Windows.Forms.Button();
            this.btn_main_order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mainDrugComp
            // 
            this.btn_mainDrugComp.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mainDrugComp.Location = new System.Drawing.Point(12, 12);
            this.btn_mainDrugComp.Name = "btn_mainDrugComp";
            this.btn_mainDrugComp.Size = new System.Drawing.Size(134, 36);
            this.btn_mainDrugComp.TabIndex = 0;
            this.btn_mainDrugComp.Text = "제약사 정보 조회";
            this.btn_mainDrugComp.UseVisualStyleBackColor = true;
            // 
            // btn_mainDrugs
            // 
            this.btn_mainDrugs.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mainDrugs.Location = new System.Drawing.Point(167, 12);
            this.btn_mainDrugs.Name = "btn_mainDrugs";
            this.btn_mainDrugs.Size = new System.Drawing.Size(86, 36);
            this.btn_mainDrugs.TabIndex = 1;
            this.btn_mainDrugs.Text = "약품정보";
            this.btn_mainDrugs.UseVisualStyleBackColor = true;
            this.btn_mainDrugs.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_main_order
            // 
            this.btn_main_order.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_main_order.Location = new System.Drawing.Point(280, 12);
            this.btn_main_order.Name = "btn_main_order";
            this.btn_main_order.Size = new System.Drawing.Size(86, 36);
            this.btn_main_order.TabIndex = 3;
            this.btn_main_order.Text = "주문관리";
            this.btn_main_order.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_main_order);
            this.Controls.Add(this.btn_mainDrugs);
            this.Controls.Add(this.btn_mainDrugComp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mainDrugComp;
        private System.Windows.Forms.Button btn_mainDrugs;
        private System.Windows.Forms.Button btn_main_order;
    }
}

