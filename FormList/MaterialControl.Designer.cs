namespace FormList
{
    partial class MaterialControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ck_1000 = new System.Windows.Forms.CheckBox();
            this.ck_500 = new System.Windows.Forms.CheckBox();
            this.ck_250 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRgi2 = new System.Windows.Forms.Button();
            this.TimeInWH = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ck_1000);
            this.groupBox1.Controls.Add(this.ck_500);
            this.groupBox1.Controls.Add(this.ck_250);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnRgi2);
            this.groupBox1.Controls.Add(this.TimeInWH);
            this.groupBox1.Controls.Add(this.label1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.dataGridView1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 573);
            this.dataGridView1.TabIndex = 23;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "입고날짜";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "원자재명";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "원자재 분류";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "총 갯수";
            this.Column5.MinimumWidth = 7;
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "창고 번호";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "비고";
            this.Column6.MinimumWidth = 7;
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(501, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "상품 코드 :";
            // 
            // ck_1000
            // 
            this.ck_1000.AutoSize = true;
            this.ck_1000.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ck_1000.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ck_1000.Location = new System.Drawing.Point(790, 43);
            this.ck_1000.Margin = new System.Windows.Forms.Padding(2);
            this.ck_1000.Name = "ck_1000";
            this.ck_1000.Size = new System.Drawing.Size(105, 25);
            this.ck_1000.TabIndex = 37;
            this.ck_1000.Text = "1,000ml";
            this.ck_1000.UseVisualStyleBackColor = true;
            // 
            // ck_500
            // 
            this.ck_500.AutoSize = true;
            this.ck_500.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ck_500.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ck_500.Location = new System.Drawing.Point(699, 43);
            this.ck_500.Margin = new System.Windows.Forms.Padding(2);
            this.ck_500.Name = "ck_500";
            this.ck_500.Size = new System.Drawing.Size(87, 25);
            this.ck_500.TabIndex = 36;
            this.ck_500.Text = "500ml";
            this.ck_500.UseVisualStyleBackColor = true;
            // 
            // ck_250
            // 
            this.ck_250.AutoSize = true;
            this.ck_250.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ck_250.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ck_250.Location = new System.Drawing.Point(608, 43);
            this.ck_250.Margin = new System.Windows.Forms.Padding(2);
            this.ck_250.Name = "ck_250";
            this.ck_250.Size = new System.Drawing.Size(87, 25);
            this.ck_250.TabIndex = 35;
            this.ck_250.Text = "250ml";
            this.ck_250.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(37, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "원재료 관리";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(1000, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 80);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRgi2
            // 
            this.btnRgi2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRgi2.Location = new System.Drawing.Point(1081, 17);
            this.btnRgi2.Margin = new System.Windows.Forms.Padding(2);
            this.btnRgi2.Name = "btnRgi2";
            this.btnRgi2.Size = new System.Drawing.Size(81, 80);
            this.btnRgi2.TabIndex = 32;
            this.btnRgi2.Text = "등록";
            this.btnRgi2.UseVisualStyleBackColor = true;
            this.btnRgi2.Click += new System.EventHandler(this.btnRgi2_Click);
            // 
            // TimeInWH
            // 
            this.TimeInWH.Location = new System.Drawing.Point(314, 45);
            this.TimeInWH.Margin = new System.Windows.Forms.Padding(2);
            this.TimeInWH.Name = "TimeInWH";
            this.TimeInWH.Size = new System.Drawing.Size(156, 21);
            this.TimeInWH.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(208, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "입고 날짜";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(919, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 80);
            this.button1.TabIndex = 39;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MaterialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1165, 693);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MaterialControl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ck_1000;
        private System.Windows.Forms.CheckBox ck_500;
        private System.Windows.Forms.CheckBox ck_250;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRgi2;
        private System.Windows.Forms.DateTimePicker TimeInWH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
