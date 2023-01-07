
namespace e24106254_practice_5_2
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
            this.startButton = new System.Windows.Forms.Button();
            this.prepareTimer = new System.Windows.Forms.Timer(this.components);
            this.playerLabel1 = new System.Windows.Forms.Label();
            this.playerLabel2 = new System.Windows.Forms.Label();
            this.phaseLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.characterButton_1_0 = new System.Windows.Forms.Button();
            this.characterButton_2_3 = new System.Windows.Forms.Button();
            this.characterButton_1_2 = new System.Windows.Forms.Button();
            this.characterButton_1_1 = new System.Windows.Forms.Button();
            this.characterButton_2_4 = new System.Windows.Forms.Button();
            this.characterButton_2_5 = new System.Windows.Forms.Button();
            this.pieceLabel1 = new System.Windows.Forms.Label();
            this.pieceLabel2 = new System.Windows.Forms.Label();
            this.pieceStateLabel1 = new System.Windows.Forms.Label();
            this.pieceStateLabel2 = new System.Windows.Forms.Label();
            this.attack_button1 = new System.Windows.Forms.Button();
            this.move_button1 = new System.Windows.Forms.Button();
            this.skill_button1 = new System.Windows.Forms.Button();
            this.wait_button1 = new System.Windows.Forms.Button();
            this.wait_button2 = new System.Windows.Forms.Button();
            this.skill_button2 = new System.Windows.Forms.Button();
            this.move_button2 = new System.Windows.Forms.Button();
            this.attack_button2 = new System.Windows.Forms.Button();
            this.end_button1 = new System.Windows.Forms.Button();
            this.end_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(555, 352);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(160, 84);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "開始遊戲";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // prepareTimer
            // 
            this.prepareTimer.Interval = 1000;
            this.prepareTimer.Tick += new System.EventHandler(this.prepareTimer_Tick);
            // 
            // playerLabel1
            // 
            this.playerLabel1.AutoSize = true;
            this.playerLabel1.Font = new System.Drawing.Font("新細明體", 20F);
            this.playerLabel1.Location = new System.Drawing.Point(139, 158);
            this.playerLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel1.Name = "playerLabel1";
            this.playerLabel1.Size = new System.Drawing.Size(76, 54);
            this.playerLabel1.TabIndex = 1;
            this.playerLabel1.Text = "P1";
            this.playerLabel1.Visible = false;
            // 
            // playerLabel2
            // 
            this.playerLabel2.AutoSize = true;
            this.playerLabel2.Font = new System.Drawing.Font("新細明體", 20F);
            this.playerLabel2.Location = new System.Drawing.Point(1066, 158);
            this.playerLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel2.Name = "playerLabel2";
            this.playerLabel2.Size = new System.Drawing.Size(76, 54);
            this.playerLabel2.TabIndex = 2;
            this.playerLabel2.Text = "P2";
            this.playerLabel2.Visible = false;
            // 
            // phaseLabel
            // 
            this.phaseLabel.AutoSize = true;
            this.phaseLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.phaseLabel.Location = new System.Drawing.Point(509, 26);
            this.phaseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phaseLabel.Name = "phaseLabel";
            this.phaseLabel.Size = new System.Drawing.Size(239, 54);
            this.phaseLabel.TabIndex = 3;
            this.phaseLabel.Text = "準備階段";
            this.phaseLabel.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.timeLabel.Location = new System.Drawing.Point(594, 96);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(73, 54);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "10";
            this.timeLabel.Visible = false;
            // 
            // characterButton_1_0
            // 
            this.characterButton_1_0.Location = new System.Drawing.Point(109, 341);
            this.characterButton_1_0.Name = "characterButton_1_0";
            this.characterButton_1_0.Size = new System.Drawing.Size(136, 80);
            this.characterButton_1_0.TabIndex = 5;
            this.characterButton_1_0.Text = "戰士:1顆";
            this.characterButton_1_0.UseVisualStyleBackColor = true;
            this.characterButton_1_0.Visible = false;
            this.characterButton_1_0.Click += new System.EventHandler(this.handleCharacterButtonClick);
            // 
            // characterButton_2_3
            // 
            this.characterButton_2_3.Enabled = false;
            this.characterButton_2_3.Location = new System.Drawing.Point(1038, 341);
            this.characterButton_2_3.Name = "characterButton_2_3";
            this.characterButton_2_3.Size = new System.Drawing.Size(142, 80);
            this.characterButton_2_3.TabIndex = 7;
            this.characterButton_2_3.Text = "戰士:1顆";
            this.characterButton_2_3.UseVisualStyleBackColor = true;
            this.characterButton_2_3.Visible = false;
            this.characterButton_2_3.Click += new System.EventHandler(this.handleCharacterButtonClick);
            // 
            // characterButton_1_2
            // 
            this.characterButton_1_2.Location = new System.Drawing.Point(109, 561);
            this.characterButton_1_2.Name = "characterButton_1_2";
            this.characterButton_1_2.Size = new System.Drawing.Size(136, 79);
            this.characterButton_1_2.TabIndex = 9;
            this.characterButton_1_2.Text = "遊俠:1顆";
            this.characterButton_1_2.UseVisualStyleBackColor = true;
            this.characterButton_1_2.Visible = false;
            this.characterButton_1_2.Click += new System.EventHandler(this.handleCharacterButtonClick);
            // 
            // characterButton_1_1
            // 
            this.characterButton_1_1.Location = new System.Drawing.Point(109, 451);
            this.characterButton_1_1.Name = "characterButton_1_1";
            this.characterButton_1_1.Size = new System.Drawing.Size(136, 74);
            this.characterButton_1_1.TabIndex = 10;
            this.characterButton_1_1.Text = "法師:1顆";
            this.characterButton_1_1.UseVisualStyleBackColor = true;
            this.characterButton_1_1.Visible = false;
            this.characterButton_1_1.Click += new System.EventHandler(this.handleCharacterButtonClick);
            // 
            // characterButton_2_4
            // 
            this.characterButton_2_4.Enabled = false;
            this.characterButton_2_4.Location = new System.Drawing.Point(1038, 451);
            this.characterButton_2_4.Name = "characterButton_2_4";
            this.characterButton_2_4.Size = new System.Drawing.Size(142, 74);
            this.characterButton_2_4.TabIndex = 11;
            this.characterButton_2_4.Text = "法師:1顆";
            this.characterButton_2_4.UseVisualStyleBackColor = true;
            this.characterButton_2_4.Visible = false;
            this.characterButton_2_4.Click += new System.EventHandler(this.handleCharacterButtonClick);
            // 
            // characterButton_2_5
            // 
            this.characterButton_2_5.Enabled = false;
            this.characterButton_2_5.Location = new System.Drawing.Point(1038, 561);
            this.characterButton_2_5.Name = "characterButton_2_5";
            this.characterButton_2_5.Size = new System.Drawing.Size(142, 79);
            this.characterButton_2_5.TabIndex = 12;
            this.characterButton_2_5.Text = "遊俠:1顆";
            this.characterButton_2_5.UseVisualStyleBackColor = true;
            this.characterButton_2_5.Visible = false;
            this.characterButton_2_5.Click += new System.EventHandler(this.handleCharacterButtonClick);
            // 
            // pieceLabel1
            // 
            this.pieceLabel1.AutoSize = true;
            this.pieceLabel1.Font = new System.Drawing.Font("新細明體", 15F);
            this.pieceLabel1.Location = new System.Drawing.Point(122, 247);
            this.pieceLabel1.Name = "pieceLabel1";
            this.pieceLabel1.Size = new System.Drawing.Size(97, 40);
            this.pieceLabel1.TabIndex = 13;
            this.pieceLabel1.Text = "戰士";
            this.pieceLabel1.Visible = false;
            // 
            // pieceLabel2
            // 
            this.pieceLabel2.AutoSize = true;
            this.pieceLabel2.Font = new System.Drawing.Font("新細明體", 15F);
            this.pieceLabel2.Location = new System.Drawing.Point(1059, 247);
            this.pieceLabel2.Name = "pieceLabel2";
            this.pieceLabel2.Size = new System.Drawing.Size(97, 40);
            this.pieceLabel2.TabIndex = 14;
            this.pieceLabel2.Text = "戰士";
            this.pieceLabel2.Visible = false;
            // 
            // pieceStateLabel1
            // 
            this.pieceStateLabel1.AutoSize = true;
            this.pieceStateLabel1.Location = new System.Drawing.Point(105, 314);
            this.pieceStateLabel1.Name = "pieceStateLabel1";
            this.pieceStateLabel1.Size = new System.Drawing.Size(126, 24);
            this.pieceStateLabel1.TabIndex = 15;
            this.pieceStateLabel1.Text = "placeholder  ";
            this.pieceStateLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pieceStateLabel1.Visible = false;
            // 
            // pieceStateLabel2
            // 
            this.pieceStateLabel2.AutoSize = true;
            this.pieceStateLabel2.Location = new System.Drawing.Point(1034, 314);
            this.pieceStateLabel2.Name = "pieceStateLabel2";
            this.pieceStateLabel2.Size = new System.Drawing.Size(114, 24);
            this.pieceStateLabel2.TabIndex = 16;
            this.pieceStateLabel2.Text = "placeholder";
            this.pieceStateLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pieceStateLabel2.Visible = false;
            // 
            // attack_button1
            // 
            this.attack_button1.Location = new System.Drawing.Point(81, 507);
            this.attack_button1.Name = "attack_button1";
            this.attack_button1.Size = new System.Drawing.Size(91, 48);
            this.attack_button1.TabIndex = 17;
            this.attack_button1.Text = "攻擊";
            this.attack_button1.UseVisualStyleBackColor = true;
            this.attack_button1.Visible = false;
            this.attack_button1.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // move_button1
            // 
            this.move_button1.Location = new System.Drawing.Point(197, 507);
            this.move_button1.Name = "move_button1";
            this.move_button1.Size = new System.Drawing.Size(91, 48);
            this.move_button1.TabIndex = 18;
            this.move_button1.Text = "移動";
            this.move_button1.UseVisualStyleBackColor = true;
            this.move_button1.Visible = false;
            this.move_button1.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // skill_button1
            // 
            this.skill_button1.Location = new System.Drawing.Point(81, 576);
            this.skill_button1.Name = "skill_button1";
            this.skill_button1.Size = new System.Drawing.Size(91, 48);
            this.skill_button1.TabIndex = 19;
            this.skill_button1.Text = "技能";
            this.skill_button1.UseVisualStyleBackColor = true;
            this.skill_button1.Visible = false;
            this.skill_button1.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // wait_button1
            // 
            this.wait_button1.Location = new System.Drawing.Point(197, 576);
            this.wait_button1.Name = "wait_button1";
            this.wait_button1.Size = new System.Drawing.Size(91, 48);
            this.wait_button1.TabIndex = 20;
            this.wait_button1.Text = "待機";
            this.wait_button1.UseVisualStyleBackColor = true;
            this.wait_button1.Visible = false;
            this.wait_button1.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // wait_button2
            // 
            this.wait_button2.Enabled = false;
            this.wait_button2.Location = new System.Drawing.Point(1131, 576);
            this.wait_button2.Name = "wait_button2";
            this.wait_button2.Size = new System.Drawing.Size(91, 48);
            this.wait_button2.TabIndex = 24;
            this.wait_button2.Text = "待機";
            this.wait_button2.UseVisualStyleBackColor = true;
            this.wait_button2.Visible = false;
            this.wait_button2.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // skill_button2
            // 
            this.skill_button2.Enabled = false;
            this.skill_button2.Location = new System.Drawing.Point(1015, 576);
            this.skill_button2.Name = "skill_button2";
            this.skill_button2.Size = new System.Drawing.Size(91, 48);
            this.skill_button2.TabIndex = 23;
            this.skill_button2.Text = "技能";
            this.skill_button2.UseVisualStyleBackColor = true;
            this.skill_button2.Visible = false;
            this.skill_button2.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // move_button2
            // 
            this.move_button2.Enabled = false;
            this.move_button2.Location = new System.Drawing.Point(1131, 507);
            this.move_button2.Name = "move_button2";
            this.move_button2.Size = new System.Drawing.Size(91, 48);
            this.move_button2.TabIndex = 22;
            this.move_button2.Text = "移動";
            this.move_button2.UseVisualStyleBackColor = true;
            this.move_button2.Visible = false;
            this.move_button2.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // attack_button2
            // 
            this.attack_button2.Enabled = false;
            this.attack_button2.Location = new System.Drawing.Point(1015, 507);
            this.attack_button2.Name = "attack_button2";
            this.attack_button2.Size = new System.Drawing.Size(91, 48);
            this.attack_button2.TabIndex = 21;
            this.attack_button2.Text = "攻擊";
            this.attack_button2.UseVisualStyleBackColor = true;
            this.attack_button2.Visible = false;
            this.attack_button2.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // end_button1
            // 
            this.end_button1.Enabled = false;
            this.end_button1.Location = new System.Drawing.Point(81, 647);
            this.end_button1.Name = "end_button1";
            this.end_button1.Size = new System.Drawing.Size(207, 57);
            this.end_button1.TabIndex = 25;
            this.end_button1.Text = "結束";
            this.end_button1.UseVisualStyleBackColor = true;
            this.end_button1.Visible = false;
            this.end_button1.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // end_button2
            // 
            this.end_button2.Enabled = false;
            this.end_button2.Location = new System.Drawing.Point(1015, 647);
            this.end_button2.Name = "end_button2";
            this.end_button2.Size = new System.Drawing.Size(207, 57);
            this.end_button2.TabIndex = 26;
            this.end_button2.Text = "結束";
            this.end_button2.UseVisualStyleBackColor = true;
            this.end_button2.Visible = false;
            this.end_button2.Click += new System.EventHandler(this.handleClickActionButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 1329);
            this.Controls.Add(this.end_button2);
            this.Controls.Add(this.end_button1);
            this.Controls.Add(this.wait_button2);
            this.Controls.Add(this.skill_button2);
            this.Controls.Add(this.move_button2);
            this.Controls.Add(this.attack_button2);
            this.Controls.Add(this.wait_button1);
            this.Controls.Add(this.skill_button1);
            this.Controls.Add(this.move_button1);
            this.Controls.Add(this.attack_button1);
            this.Controls.Add(this.pieceStateLabel2);
            this.Controls.Add(this.pieceStateLabel1);
            this.Controls.Add(this.pieceLabel2);
            this.Controls.Add(this.pieceLabel1);
            this.Controls.Add(this.characterButton_2_5);
            this.Controls.Add(this.characterButton_2_4);
            this.Controls.Add(this.characterButton_2_3);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.phaseLabel);
            this.Controls.Add(this.playerLabel2);
            this.Controls.Add(this.playerLabel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.characterButton_1_1);
            this.Controls.Add(this.characterButton_1_2);
            this.Controls.Add(this.characterButton_1_0);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MinimumSize = new System.Drawing.Size(1354, 860);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer prepareTimer;
        private System.Windows.Forms.Label playerLabel1;
        private System.Windows.Forms.Label playerLabel2;
        private System.Windows.Forms.Label phaseLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button characterButton_1_0;
        private System.Windows.Forms.Button characterButton_2_3;
        private System.Windows.Forms.Button characterButton_1_2;
        private System.Windows.Forms.Button characterButton_1_1;
        private System.Windows.Forms.Button characterButton_2_4;
        private System.Windows.Forms.Button characterButton_2_5;
        private System.Windows.Forms.Label pieceLabel1;
        private System.Windows.Forms.Label pieceLabel2;
        private System.Windows.Forms.Label pieceStateLabel1;
        private System.Windows.Forms.Label pieceStateLabel2;
        private System.Windows.Forms.Button attack_button1;
        private System.Windows.Forms.Button move_button1;
        private System.Windows.Forms.Button skill_button1;
        private System.Windows.Forms.Button wait_button1;
        private System.Windows.Forms.Button wait_button2;
        private System.Windows.Forms.Button skill_button2;
        private System.Windows.Forms.Button move_button2;
        private System.Windows.Forms.Button attack_button2;
        private System.Windows.Forms.Button end_button1;
        private System.Windows.Forms.Button end_button2;
    }
}

