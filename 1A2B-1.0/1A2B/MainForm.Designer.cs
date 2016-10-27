namespace _1A2B
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.butStart = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.butnRestart = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox6 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox5 = new System.Windows.Forms.PictureBox();
            this.picBox9 = new System.Windows.Forms.PictureBox();
            this.picBox7 = new System.Windows.Forms.PictureBox();
            this.picBox8 = new System.Windows.Forms.PictureBox();
            this.picBox0 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox0)).BeginInit();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Image = ((System.Drawing.Image)(resources.GetObject("butStart.Image")));
            this.butStart.Location = new System.Drawing.Point(344, 3);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(32, 32);
            this.butStart.TabIndex = 0;
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Visible = false;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butExit
            // 
            this.butExit.Image = ((System.Drawing.Image)(resources.GetObject("butExit.Image")));
            this.butExit.Location = new System.Drawing.Point(344, 155);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(32, 32);
            this.butExit.TabIndex = 1;
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // lstBox
            // 
            this.lstBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 19;
            this.lstBox.Location = new System.Drawing.Point(3, 7);
            this.lstBox.Name = "lstBox";
            this.lstBox.ScrollAlwaysVisible = true;
            this.lstBox.Size = new System.Drawing.Size(196, 213);
            this.lstBox.TabIndex = 3;
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox.Location = new System.Drawing.Point(248, 3);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(80, 29);
            this.txtBox.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(329, 206);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 14);
            this.label.TabIndex = 5;
            this.label.Text = "已用 0 秒";
            this.label.Visible = false;
            // 
            // butnRestart
            // 
            this.butnRestart.Image = ((System.Drawing.Image)(resources.GetObject("butnRestart.Image")));
            this.butnRestart.Location = new System.Drawing.Point(248, 155);
            this.butnRestart.Name = "butnRestart";
            this.butnRestart.Size = new System.Drawing.Size(32, 32);
            this.butnRestart.TabIndex = 6;
            this.butnRestart.UseVisualStyleBackColor = true;
            this.butnRestart.Click += new System.EventHandler(this.butnRestart_Click);
            // 
            // picBox2
            // 
            this.picBox2.Image = ((System.Drawing.Image)(resources.GetObject("picBox2.Image")));
            this.picBox2.Location = new System.Drawing.Point(296, 41);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(32, 32);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox2.TabIndex = 7;
            this.picBox2.TabStop = false;
            this.picBox2.Click += new System.EventHandler(this.picBox2_Click);
            // 
            // picBox1
            // 
            this.picBox1.Image = ((System.Drawing.Image)(resources.GetObject("picBox1.Image")));
            this.picBox1.Location = new System.Drawing.Point(248, 41);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(32, 32);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox1.TabIndex = 8;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // picBox3
            // 
            this.picBox3.BackColor = System.Drawing.SystemColors.Control;
            this.picBox3.Image = ((System.Drawing.Image)(resources.GetObject("picBox3.Image")));
            this.picBox3.Location = new System.Drawing.Point(344, 41);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(32, 32);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox3.TabIndex = 9;
            this.picBox3.TabStop = false;
            this.picBox3.Click += new System.EventHandler(this.picBox3_Click);
            // 
            // picBox6
            // 
            this.picBox6.Image = ((System.Drawing.Image)(resources.GetObject("picBox6.Image")));
            this.picBox6.Location = new System.Drawing.Point(344, 79);
            this.picBox6.Name = "picBox6";
            this.picBox6.Size = new System.Drawing.Size(32, 32);
            this.picBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox6.TabIndex = 12;
            this.picBox6.TabStop = false;
            this.picBox6.Click += new System.EventHandler(this.picBox6_Click);
            // 
            // picBox4
            // 
            this.picBox4.Image = ((System.Drawing.Image)(resources.GetObject("picBox4.Image")));
            this.picBox4.Location = new System.Drawing.Point(248, 79);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(32, 32);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox4.TabIndex = 11;
            this.picBox4.TabStop = false;
            this.picBox4.Click += new System.EventHandler(this.picBox4_Click);
            // 
            // picBox5
            // 
            this.picBox5.Image = ((System.Drawing.Image)(resources.GetObject("picBox5.Image")));
            this.picBox5.Location = new System.Drawing.Point(296, 79);
            this.picBox5.Name = "picBox5";
            this.picBox5.Size = new System.Drawing.Size(32, 32);
            this.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox5.TabIndex = 10;
            this.picBox5.TabStop = false;
            this.picBox5.Click += new System.EventHandler(this.picBox5_Click);
            // 
            // picBox9
            // 
            this.picBox9.Image = ((System.Drawing.Image)(resources.GetObject("picBox9.Image")));
            this.picBox9.Location = new System.Drawing.Point(344, 117);
            this.picBox9.Name = "picBox9";
            this.picBox9.Size = new System.Drawing.Size(32, 32);
            this.picBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox9.TabIndex = 15;
            this.picBox9.TabStop = false;
            this.picBox9.Click += new System.EventHandler(this.picBox9_Click);
            // 
            // picBox7
            // 
            this.picBox7.Image = ((System.Drawing.Image)(resources.GetObject("picBox7.Image")));
            this.picBox7.Location = new System.Drawing.Point(248, 117);
            this.picBox7.Name = "picBox7";
            this.picBox7.Size = new System.Drawing.Size(32, 32);
            this.picBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox7.TabIndex = 14;
            this.picBox7.TabStop = false;
            this.picBox7.Click += new System.EventHandler(this.picBox7_Click);
            // 
            // picBox8
            // 
            this.picBox8.Image = ((System.Drawing.Image)(resources.GetObject("picBox8.Image")));
            this.picBox8.Location = new System.Drawing.Point(296, 117);
            this.picBox8.Name = "picBox8";
            this.picBox8.Size = new System.Drawing.Size(32, 32);
            this.picBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox8.TabIndex = 13;
            this.picBox8.TabStop = false;
            this.picBox8.Click += new System.EventHandler(this.picBox8_Click);
            // 
            // picBox0
            // 
            this.picBox0.Image = ((System.Drawing.Image)(resources.GetObject("picBox0.Image")));
            this.picBox0.Location = new System.Drawing.Point(296, 155);
            this.picBox0.Name = "picBox0";
            this.picBox0.Size = new System.Drawing.Size(32, 32);
            this.picBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox0.TabIndex = 16;
            this.picBox0.TabStop = false;
            this.picBox0.Click += new System.EventHandler(this.picBox0_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 225);
            this.Controls.Add(this.picBox0);
            this.Controls.Add(this.picBox9);
            this.Controls.Add(this.picBox7);
            this.Controls.Add(this.picBox8);
            this.Controls.Add(this.picBox6);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.picBox5);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.butnRestart);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1A2B";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button butnRestart;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox6;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.PictureBox picBox5;
        private System.Windows.Forms.PictureBox picBox9;
        private System.Windows.Forms.PictureBox picBox7;
        private System.Windows.Forms.PictureBox picBox8;
        private System.Windows.Forms.PictureBox picBox0;
    }
}

