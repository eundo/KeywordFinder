
namespace KeywordFinder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnKeywordSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEvernoteApiKey = new System.Windows.Forms.DataGridView();
            this.colToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontent = new System.Windows.Forms.TextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.dgvFindResult = new System.Windows.Forms.DataGridView();
            this.colTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvernoteApiKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "키워드 입력";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(87, 16);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(512, 21);
            this.txtKeyword.TabIndex = 1;
            // 
            // btnKeywordSearch
            // 
            this.btnKeywordSearch.Location = new System.Drawing.Point(605, 15);
            this.btnKeywordSearch.Name = "btnKeywordSearch";
            this.btnKeywordSearch.Size = new System.Drawing.Size(89, 22);
            this.btnKeywordSearch.TabIndex = 2;
            this.btnKeywordSearch.Text = "검색";
            this.btnKeywordSearch.UseVisualStyleBackColor = true;
            this.btnKeywordSearch.Click += new System.EventHandler(this.btnKeywordSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEvernoteApiKey);
            this.groupBox1.Location = new System.Drawing.Point(700, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EverNote API Key";
            // 
            // dgvEvernoteApiKey
            // 
            this.dgvEvernoteApiKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvernoteApiKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvernoteApiKey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colToken});
            this.dgvEvernoteApiKey.Location = new System.Drawing.Point(16, 20);
            this.dgvEvernoteApiKey.Name = "dgvEvernoteApiKey";
            this.dgvEvernoteApiKey.RowTemplate.Height = 23;
            this.dgvEvernoteApiKey.Size = new System.Drawing.Size(394, 218);
            this.dgvEvernoteApiKey.TabIndex = 0;
            // 
            // colToken
            // 
            this.colToken.HeaderText = "DevelopToken";
            this.colToken.Name = "colToken";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(774, 276);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(269, 21);
            this.txttitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "노트 제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "노트 내용";
            // 
            // txtcontent
            // 
            this.txtcontent.Location = new System.Drawing.Point(774, 303);
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(269, 21);
            this.txtcontent.TabIndex = 5;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(1050, 276);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(73, 48);
            this.btnAddNote.TabIndex = 6;
            this.btnAddNote.Text = "등록";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // dgvFindResult
            // 
            this.dgvFindResult.AllowUserToAddRows = false;
            this.dgvFindResult.AllowUserToDeleteRows = false;
            this.dgvFindResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTarget,
            this.colTitle,
            this.colcontent});
            this.dgvFindResult.Location = new System.Drawing.Point(14, 43);
            this.dgvFindResult.Name = "dgvFindResult";
            this.dgvFindResult.ReadOnly = true;
            this.dgvFindResult.RowTemplate.Height = 23;
            this.dgvFindResult.Size = new System.Drawing.Size(680, 281);
            this.dgvFindResult.TabIndex = 7;
            // 
            // colTarget
            // 
            this.colTarget.HeaderText = "위치";
            this.colTarget.Name = "colTarget";
            this.colTarget.ReadOnly = true;
            this.colTarget.Width = 80;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "제목";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 250;
            // 
            // colcontent
            // 
            this.colcontent.HeaderText = "내용";
            this.colcontent.Name = "colcontent";
            this.colcontent.ReadOnly = true;
            this.colcontent.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 335);
            this.Controls.Add(this.dgvFindResult);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKeywordSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "API Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvernoteApiKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnKeywordSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEvernoteApiKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToken;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontent;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.DataGridView dgvFindResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcontent;
    }
}

