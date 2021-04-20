
namespace teamProject
{
    partial class DrugCompInfo_Form
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
            this.components = new System.ComponentModel.Container();
            this.compTitle = new System.Windows.Forms.Label();
            this.compName = new System.Windows.Forms.Label();
            this.btn_DrugComp_Edit = new System.Windows.Forms.Button();
            this.btn_DrugComp_Del = new System.Windows.Forms.Button();
            this.compTel = new System.Windows.Forms.Label();
            this.btn_DrugComp_Add = new System.Windows.Forms.Button();
            this.compNa = new System.Windows.Forms.Label();
            this.btn_DrugComp_Search = new System.Windows.Forms.Button();
            this.compSubTitle = new System.Windows.Forms.GroupBox();
            this.drugComp_dtGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchName = new System.Windows.Forms.TextBox();
            this.compNa_txtBox = new VerticalTextBox();
            this.compName_txtBox = new VerticalTextBox();
            this.compTel_txtBox = new VerticalTextBox();
            this.compSubTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugComp_dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // compTitle
            // 
            this.compTitle.AutoSize = true;
            this.compTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.compTitle.Location = new System.Drawing.Point(39, 40);
            this.compTitle.Name = "compTitle";
            this.compTitle.Size = new System.Drawing.Size(150, 25);
            this.compTitle.TabIndex = 0;
            this.compTitle.Text = "제약사 정보 조회";
            // 
            // compName
            // 
            this.compName.AutoSize = true;
            this.compName.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.compName.Location = new System.Drawing.Point(30, 53);
            this.compName.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(69, 20);
            this.compName.TabIndex = 4;
            this.compName.Text = "회사이름";
            // 
            // btn_DrugComp_Edit
            // 
            this.btn_DrugComp_Edit.FlatAppearance.BorderSize = 0;
            this.btn_DrugComp_Edit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DrugComp_Edit.Location = new System.Drawing.Point(747, 95);
            this.btn_DrugComp_Edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DrugComp_Edit.Name = "btn_DrugComp_Edit";
            this.btn_DrugComp_Edit.Size = new System.Drawing.Size(70, 39);
            this.btn_DrugComp_Edit.TabIndex = 6;
            this.btn_DrugComp_Edit.Text = "수정";
            this.btn_DrugComp_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_DrugComp_Del
            // 
            this.btn_DrugComp_Del.FlatAppearance.BorderSize = 0;
            this.btn_DrugComp_Del.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DrugComp_Del.Location = new System.Drawing.Point(829, 95);
            this.btn_DrugComp_Del.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DrugComp_Del.Name = "btn_DrugComp_Del";
            this.btn_DrugComp_Del.Size = new System.Drawing.Size(70, 39);
            this.btn_DrugComp_Del.TabIndex = 7;
            this.btn_DrugComp_Del.Text = "삭제";
            this.btn_DrugComp_Del.UseVisualStyleBackColor = true;
            // 
            // compTel
            // 
            this.compTel.AutoSize = true;
            this.compTel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.compTel.Location = new System.Drawing.Point(30, 105);
            this.compTel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.compTel.Name = "compTel";
            this.compTel.Size = new System.Drawing.Size(119, 20);
            this.compTel.TabIndex = 8;
            this.compTel.Text = "거래처 전화번호";
            // 
            // btn_DrugComp_Add
            // 
            this.btn_DrugComp_Add.FlatAppearance.BorderSize = 0;
            this.btn_DrugComp_Add.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DrugComp_Add.Location = new System.Drawing.Point(665, 95);
            this.btn_DrugComp_Add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DrugComp_Add.Name = "btn_DrugComp_Add";
            this.btn_DrugComp_Add.Size = new System.Drawing.Size(70, 39);
            this.btn_DrugComp_Add.TabIndex = 10;
            this.btn_DrugComp_Add.Text = "추가";
            this.btn_DrugComp_Add.UseVisualStyleBackColor = true;
            // 
            // compNa
            // 
            this.compNa.AutoSize = true;
            this.compNa.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.compNa.Location = new System.Drawing.Point(533, 40);
            this.compNa.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.compNa.Name = "compNa";
            this.compNa.Size = new System.Drawing.Size(89, 20);
            this.compNa.TabIndex = 11;
            this.compNa.Text = "제약사 이름";
            // 
            // btn_DrugComp_Search
            // 
            this.btn_DrugComp_Search.FlatAppearance.BorderSize = 0;
            this.btn_DrugComp_Search.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DrugComp_Search.Location = new System.Drawing.Point(873, 31);
            this.btn_DrugComp_Search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DrugComp_Search.Name = "btn_DrugComp_Search";
            this.btn_DrugComp_Search.Size = new System.Drawing.Size(91, 39);
            this.btn_DrugComp_Search.TabIndex = 13;
            this.btn_DrugComp_Search.Text = "검색";
            this.btn_DrugComp_Search.UseVisualStyleBackColor = true;
            this.btn_DrugComp_Search.Click += new System.EventHandler(this.btn_DrugComp_Search_Click);
            // 
            // compSubTitle
            // 
            this.compSubTitle.Controls.Add(this.compName);
            this.compSubTitle.Controls.Add(this.compTel);
            this.compSubTitle.Controls.Add(this.btn_DrugComp_Del);
            this.compSubTitle.Controls.Add(this.btn_DrugComp_Add);
            this.compSubTitle.Controls.Add(this.btn_DrugComp_Edit);
            this.compSubTitle.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.compSubTitle.Location = new System.Drawing.Point(44, 518);
            this.compSubTitle.Name = "compSubTitle";
            this.compSubTitle.Size = new System.Drawing.Size(920, 155);
            this.compSubTitle.TabIndex = 14;
            this.compSubTitle.TabStop = false;
            this.compSubTitle.Text = "제약사";
            // 
            // drugComp_dtGridView
            // 
            this.drugComp_dtGridView.AutoGenerateColumns = false;
            this.drugComp_dtGridView.BackgroundColor = System.Drawing.Color.White;
            this.drugComp_dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugComp_dtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.drugComp_dtGridView.DataSource = this.entpBindingSource;
            this.drugComp_dtGridView.Location = new System.Drawing.Point(44, 83);
            this.drugComp_dtGridView.Name = "drugComp_dtGridView";
            this.drugComp_dtGridView.RowTemplate.Height = 30;
            this.drugComp_dtGridView.Size = new System.Drawing.Size(920, 407);
            this.drugComp_dtGridView.TabIndex = 15;
            this.drugComp_dtGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drugComp_dtGridView_CellClick);
            this.drugComp_dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drugComp_dtGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "entpName";
            this.dataGridViewTextBoxColumn1.HeaderText = "entpName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "entpTel";
            this.dataGridViewTextBoxColumn2.HeaderText = "entpTel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "entpAddr";
            this.dataGridViewTextBoxColumn3.HeaderText = "entpAddr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "entpEmail";
            this.dataGridViewTextBoxColumn4.HeaderText = "entpEmail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // entpBindingSource
            // 
            this.entpBindingSource.DataSource = typeof(teamProject.Entp);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(649, 39);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(189, 21);
            this.searchName.TabIndex = 16;
            // 
            // compNa_txtBox
            // 
            this.compNa_txtBox.BackColor = System.Drawing.SystemColors.Window;
            this.compNa_txtBox.BorderColor = System.Drawing.Color.Gray;
            this.compNa_txtBox.Font = new System.Drawing.Font("굴림", 11F);
            this.compNa_txtBox.LeftRightPadding = ((uint)(10u));
            this.compNa_txtBox.Location = new System.Drawing.Point(633, 31);
            this.compNa_txtBox.Name = "compNa_txtBox";
            this.compNa_txtBox.Size = new System.Drawing.Size(233, 39);
            this.compNa_txtBox.TabIndex = 12;
            this.compNa_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // compName_txtBox
            // 
            this.compName_txtBox.BackColor = System.Drawing.SystemColors.Window;
            this.compName_txtBox.BorderColor = System.Drawing.Color.Gray;
            this.compName_txtBox.Font = new System.Drawing.Font("굴림", 11F);
            this.compName_txtBox.LeftRightPadding = ((uint)(10u));
            this.compName_txtBox.Location = new System.Drawing.Point(160, 44);
            this.compName_txtBox.Name = "compName_txtBox";
            this.compName_txtBox.Size = new System.Drawing.Size(200, 39);
            this.compName_txtBox.TabIndex = 5;
            this.compName_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // compTel_txtBox
            // 
            this.compTel_txtBox.BackColor = System.Drawing.SystemColors.Window;
            this.compTel_txtBox.BorderColor = System.Drawing.Color.Gray;
            this.compTel_txtBox.Font = new System.Drawing.Font("굴림", 11F);
            this.compTel_txtBox.LeftRightPadding = ((uint)(10u));
            this.compTel_txtBox.Location = new System.Drawing.Point(160, 95);
            this.compTel_txtBox.Name = "compTel_txtBox";
            this.compTel_txtBox.Size = new System.Drawing.Size(200, 39);
            this.compTel_txtBox.TabIndex = 9;
            this.compTel_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DrugCompInfo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.btn_DrugComp_Search);
            this.Controls.Add(this.compNa);
            this.Controls.Add(this.compTitle);
            this.Controls.Add(this.compSubTitle);
            this.Controls.Add(this.drugComp_dtGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DrugCompInfo_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DrugComp_info";
            this.Load += new System.EventHandler(this.DrugCompInfo_Form_Load);
            this.compSubTitle.ResumeLayout(false);
            this.compSubTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugComp_dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label compTitle;
        private System.Windows.Forms.Label compName;
        private VerticalTextBox compName_txtBox;
        private System.Windows.Forms.Button btn_DrugComp_Edit;
        private System.Windows.Forms.Button btn_DrugComp_Del;
        private System.Windows.Forms.Label compTel;
        private VerticalTextBox compTel_txtBox;
        private System.Windows.Forms.Button btn_DrugComp_Add;
        private VerticalTextBox compNa_txtBox;
        private System.Windows.Forms.Label compNa;
        private System.Windows.Forms.Button btn_DrugComp_Search;
        private System.Windows.Forms.GroupBox compSubTitle;
        private System.Windows.Forms.DataGridView drugComp_dtGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn entpNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entpTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entpAddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entpEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource entpBindingSource;
    }
}