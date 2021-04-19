
namespace teamProject
{
    partial class DrugComp_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.compTitle = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.compSubTitle = new System.Windows.Forms.Label();
            this.compName = new System.Windows.Forms.Label();
            this.compName_txtBox = new VerticalTextBox();
            this.SuspendLayout();
            // 
            // compTitle
            // 
            this.compTitle.AutoSize = true;
            this.compTitle.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.compTitle.Location = new System.Drawing.Point(39, 40);
            this.compTitle.Name = "compTitle";
            this.compTitle.Size = new System.Drawing.Size(150, 25);
            this.compTitle.TabIndex = 0;
            this.compTitle.Text = "제약사 정보 조회";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(920, 380);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(812, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "데이터바인딩 필요";
            // 
            // compSubTitle
            // 
            this.compSubTitle.AutoSize = true;
            this.compSubTitle.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.compSubTitle.Location = new System.Drawing.Point(40, 484);
            this.compSubTitle.Name = "compSubTitle";
            this.compSubTitle.Size = new System.Drawing.Size(54, 20);
            this.compSubTitle.TabIndex = 3;
            this.compSubTitle.Text = "제약사";
            // 
            // compName
            // 
            this.compName.AutoSize = true;
            this.compName.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.compName.Location = new System.Drawing.Point(40, 531);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(69, 20);
            this.compName.TabIndex = 4;
            this.compName.Text = "회사이름";
            // 
            // compName_txtBox
            // 
            this.compName_txtBox.BackColor = System.Drawing.SystemColors.Window;
            this.compName_txtBox.BorderColor = System.Drawing.Color.Gray;
            this.compName_txtBox.Font = new System.Drawing.Font("굴림", 11F);
            this.compName_txtBox.LeftRightPadding = ((uint)(10u));
            this.compName_txtBox.Location = new System.Drawing.Point(133, 523);
            this.compName_txtBox.Name = "compName_txtBox";
            this.compName_txtBox.Size = new System.Drawing.Size(212, 37);
            this.compName_txtBox.TabIndex = 5;
            this.compName_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DrugComp_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.compName_txtBox);
            this.Controls.Add(this.compName);
            this.Controls.Add(this.compSubTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.compTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DrugComp_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DrugComp_info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label compTitle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label compSubTitle;
        private System.Windows.Forms.Label compName;
        private VerticalTextBox compName_txtBox;
    }
}