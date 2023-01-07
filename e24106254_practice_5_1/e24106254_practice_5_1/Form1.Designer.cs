
namespace e24106254_practice_5_1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.wordInput = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.guessLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel.Location = new System.Drawing.Point(483, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(222, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "猜英文單字";
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.AutoSize = true;
            this.timesLeftLabel.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.timesLeftLabel.Location = new System.Drawing.Point(483, 117);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(242, 40);
            this.timesLeftLabel.TabIndex = 1;
            this.timesLeftLabel.Text = "6次猜錯機會";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(498, 305);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(202, 24);
            this.wordLabel.TabIndex = 2;
            this.wordLabel.Text = "請輸入要猜的單字";
            // 
            // wordInput
            // 
            this.wordInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.wordInput.Location = new System.Drawing.Point(490, 349);
            this.wordInput.Name = "wordInput";
            this.wordInput.Size = new System.Drawing.Size(212, 36);
            this.wordInput.TabIndex = 3;
            this.wordInput.TextChanged += new System.EventHandler(this.wordInput_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(514, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(162, 77);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("新細明體", 15F);
            this.guessLabel.Location = new System.Drawing.Point(524, 571);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(152, 40);
            this.guessLabel.TabIndex = 5;
            this.guessLabel.Text = "_ _ _ _ _";
            this.guessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guessLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(1188, 91);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(75, 24);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "時間:0";
            this.timeLabel.Visible = false;
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Location = new System.Drawing.Point(1188, 215);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(147, 24);
            this.wrongLabel.TabIndex = 7;
            this.wrongLabel.Text = "猜錯次數:0次";
            this.wrongLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 895);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.wordInput);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.titleLabel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.TextBox wordInput;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label wrongLabel;
    }
}

