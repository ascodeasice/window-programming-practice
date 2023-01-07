
namespace e24106254_practice_6_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.beatTimer = new System.Windows.Forms.Timer(this.components);
            this.BPMBar = new System.Windows.Forms.TrackBar();
            this.minBPM = new System.Windows.Forms.Label();
            this.maxBPM = new System.Windows.Forms.Label();
            this.curBPM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.beatPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteButton2 = new System.Windows.Forms.RadioButton();
            this.noteButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emphasisBox = new System.Windows.Forms.ComboBox();
            this.beatLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BPMBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // beatTimer
            // 
            this.beatTimer.Interval = 1000;
            this.beatTimer.Tick += new System.EventHandler(this.beatTimer_Tick);
            // 
            // BPMBar
            // 
            this.BPMBar.Location = new System.Drawing.Point(394, 131);
            this.BPMBar.Name = "BPMBar";
            this.BPMBar.Size = new System.Drawing.Size(453, 90);
            this.BPMBar.TabIndex = 0;
            this.BPMBar.ValueChanged += new System.EventHandler(this.BPMBar_ValueChanged);
            // 
            // minBPM
            // 
            this.minBPM.AutoSize = true;
            this.minBPM.Location = new System.Drawing.Point(271, 140);
            this.minBPM.Name = "minBPM";
            this.minBPM.Size = new System.Drawing.Size(64, 24);
            this.minBPM.TabIndex = 7;
            this.minBPM.Text = "label1";
            // 
            // maxBPM
            // 
            this.maxBPM.AutoSize = true;
            this.maxBPM.Location = new System.Drawing.Point(908, 131);
            this.maxBPM.Name = "maxBPM";
            this.maxBPM.Size = new System.Drawing.Size(64, 24);
            this.maxBPM.TabIndex = 8;
            this.maxBPM.Text = "label1";
            // 
            // curBPM
            // 
            this.curBPM.AutoSize = true;
            this.curBPM.Font = new System.Drawing.Font("新細明體", 15F);
            this.curBPM.Location = new System.Drawing.Point(561, 45);
            this.curBPM.Name = "curBPM";
            this.curBPM.Size = new System.Drawing.Size(109, 40);
            this.curBPM.TabIndex = 9;
            this.curBPM.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.beatPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.emphasisBox);
            this.panel1.Controls.Add(this.beatLabel);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.curBPM);
            this.panel1.Controls.Add(this.maxBPM);
            this.panel1.Controls.Add(this.minBPM);
            this.panel1.Controls.Add(this.BPMBar);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 894);
            this.panel1.TabIndex = 1;
            // 
            // beatPanel
            // 
            this.beatPanel.Location = new System.Drawing.Point(275, 212);
            this.beatPanel.Name = "beatPanel";
            this.beatPanel.Size = new System.Drawing.Size(697, 72);
            this.beatPanel.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.noteButton2);
            this.panel2.Controls.Add(this.noteButton1);
            this.panel2.Location = new System.Drawing.Point(379, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 49);
            this.panel2.TabIndex = 16;
            // 
            // noteButton2
            // 
            this.noteButton2.AutoSize = true;
            this.noteButton2.Location = new System.Drawing.Point(415, 4);
            this.noteButton2.Name = "noteButton2";
            this.noteButton2.Size = new System.Drawing.Size(27, 26);
            this.noteButton2.TabIndex = 1;
            this.noteButton2.UseVisualStyleBackColor = true;
            this.noteButton2.CheckedChanged += new System.EventHandler(this.noteButton2_CheckedChanged);
            // 
            // noteButton1
            // 
            this.noteButton1.AutoSize = true;
            this.noteButton1.Location = new System.Drawing.Point(80, 4);
            this.noteButton1.Name = "noteButton1";
            this.noteButton1.Size = new System.Drawing.Size(27, 26);
            this.noteButton1.TabIndex = 0;
            this.noteButton1.UseVisualStyleBackColor = true;
            this.noteButton1.CheckedChanged += new System.EventHandler(this.noteButton1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(714, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // emphasisBox
            // 
            this.emphasisBox.FormattingEnabled = true;
            this.emphasisBox.Items.AddRange(new object[] {
            "4",
            "8"});
            this.emphasisBox.Location = new System.Drawing.Point(647, 703);
            this.emphasisBox.Name = "emphasisBox";
            this.emphasisBox.Size = new System.Drawing.Size(121, 32);
            this.emphasisBox.TabIndex = 13;
            this.emphasisBox.SelectedIndexChanged += new System.EventHandler(this.emphasisBox_SelectedIndexChanged);
            // 
            // beatLabel
            // 
            this.beatLabel.AutoSize = true;
            this.beatLabel.Location = new System.Drawing.Point(438, 703);
            this.beatLabel.Name = "beatLabel";
            this.beatLabel.Size = new System.Drawing.Size(145, 24);
            this.beatLabel.TabIndex = 11;
            this.beatLabel.Text = "Beat Emphasis";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(568, 778);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(126, 48);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 936);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BPMBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer beatTimer;
        private System.Windows.Forms.TrackBar BPMBar;
        private System.Windows.Forms.Label minBPM;
        private System.Windows.Forms.Label maxBPM;
        private System.Windows.Forms.Label curBPM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox emphasisBox;
        private System.Windows.Forms.Label beatLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton noteButton2;
        private System.Windows.Forms.RadioButton noteButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel beatPanel;
    }
}

