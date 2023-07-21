namespace MainForms
{
    partial class P03_MainForm
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsFormName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsNowdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timNowDate = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnProductControl = new System.Windows.Forms.Button();
            this.btnProductMoniter = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(334, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(939, 116);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsFormName,
            this.toolStripStatusLabel2,
            this.stsUserName,
            this.stsNowdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 709);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1273, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsFormName
            // 
            this.stsFormName.AutoSize = false;
            this.stsFormName.Name = "stsFormName";
            this.stsFormName.Size = new System.Drawing.Size(150, 17);
            this.stsFormName.Text = "FormName";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(758, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // stsUserName
            // 
            this.stsUserName.AutoSize = false;
            this.stsUserName.Name = "stsUserName";
            this.stsUserName.Size = new System.Drawing.Size(150, 17);
            this.stsUserName.Text = "UserName";
            // 
            // stsNowdate
            // 
            this.stsNowdate.AutoSize = false;
            this.stsNowdate.Name = "stsNowdate";
            this.stsNowdate.Size = new System.Drawing.Size(200, 17);
            this.stsNowdate.Text = "Datetime";
            // 
            // timNowDate
            // 
            this.timNowDate.Tick += new System.EventHandler(this.timNowDate_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.btnMaterial);
            this.flowLayoutPanel1.Controls.Add(this.btnProduct);
            this.flowLayoutPanel1.Controls.Add(this.btnProductControl);
            this.flowLayoutPanel1.Controls.Add(this.btnProductMoniter);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 709);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMaterial.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaterial.Location = new System.Drawing.Point(3, 198);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(326, 46);
            this.btnMaterial.TabIndex = 5;
            this.btnMaterial.Text = "       ⦁  원재료 관리";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.AliceBlue;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduct.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnProduct.Location = new System.Drawing.Point(3, 250);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(326, 46);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "       ⦁  생산현황";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnProductControl
            // 
            this.btnProductControl.BackColor = System.Drawing.Color.AliceBlue;
            this.btnProductControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductControl.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProductControl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductControl.Location = new System.Drawing.Point(3, 302);
            this.btnProductControl.Name = "btnProductControl";
            this.btnProductControl.Size = new System.Drawing.Size(326, 46);
            this.btnProductControl.TabIndex = 7;
            this.btnProductControl.Text = "       ⦁  생산실적관리";
            this.btnProductControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductControl.UseVisualStyleBackColor = false;
            // 
            // btnProductMoniter
            // 
            this.btnProductMoniter.BackColor = System.Drawing.Color.AliceBlue;
            this.btnProductMoniter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductMoniter.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProductMoniter.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductMoniter.Location = new System.Drawing.Point(3, 354);
            this.btnProductMoniter.Name = "btnProductMoniter";
            this.btnProductMoniter.Size = new System.Drawing.Size(326, 46);
            this.btnProductMoniter.TabIndex = 8;
            this.btnProductMoniter.Text = "       ⦁  생산모니터링";
            this.btnProductMoniter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductMoniter.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(3, 482);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(326, 46);
            this.button7.TabIndex = 10;
            this.button7.Text = "       ⦁  CCP 데이터";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button8.Location = new System.Drawing.Point(3, 534);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(326, 46);
            this.button8.TabIndex = 11;
            this.button8.Text = "       ⦁  CCP 리포트";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.AliceBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button9.Location = new System.Drawing.Point(3, 586);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(326, 46);
            this.button9.TabIndex = 12;
            this.button9.Text = "       ⦁  통계";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MainForms.Properties.Resources.Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(334, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 593);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.AutoSize = false;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.Image = global::MainForms.Properties.Resources.btn종료;
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.Text = "종료";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::MainForms.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Image = global::MainForms.Properties.Resources.pngegg;
            this.button1.Location = new System.Drawing.Point(3, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "●  생산관리";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button6.Image = global::MainForms.Properties.Resources.pngegg;
            this.button6.Location = new System.Drawing.Point(3, 406);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(326, 70);
            this.button6.TabIndex = 9;
            this.button6.Text = "●  CCP 관리";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // P03_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "P03_MainForm";
            this.Text = "P03_MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.P03_MainForms_FormClosing);
            this.Load += new System.EventHandler(this.P03_MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timNowDate;
        private System.Windows.Forms.ToolStripStatusLabel stsFormName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel stsUserName;
        private System.Windows.Forms.ToolStripStatusLabel stsNowdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnProductControl;
        private System.Windows.Forms.Button btnProductMoniter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
    }
}

