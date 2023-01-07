
namespace e24106254_practice_4_2
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
            this.leaveButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gamePage = new System.Windows.Forms.TabPage();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.recordText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.gamePage.SuspendLayout();
            this.historyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(1120, 622);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(174, 77);
            this.leaveButton.TabIndex = 23;
            this.leaveButton.Text = "離開遊戲";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Enabled = false;
            this.continueButton.Location = new System.Drawing.Point(1120, 224);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(174, 77);
            this.continueButton.TabIndex = 22;
            this.continueButton.Text = "繼續";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1120, 93);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(174, 77);
            this.startButton.TabIndex = 21;
            this.startButton.Text = "開始遊戲";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "翻牌小遊戲";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.jpg");
            this.imageList1.Images.SetKeyName(1, "02.jpg");
            this.imageList1.Images.SetKeyName(2, "03.jpg");
            this.imageList1.Images.SetKeyName(3, "04.jpg");
            this.imageList1.Images.SetKeyName(4, "05.jpg");
            this.imageList1.Images.SetKeyName(5, "06.jpg");
            this.imageList1.Images.SetKeyName(6, "07.jpg");
            this.imageList1.Images.SetKeyName(7, "08.jpg");
            this.imageList1.Images.SetKeyName(8, "card.jpg");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gamePage);
            this.tabControl1.Controls.Add(this.historyPage);
            this.tabControl1.Location = new System.Drawing.Point(18, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1403, 1025);
            this.tabControl1.TabIndex = 24;
            // 
            // gamePage
            // 
            this.gamePage.Controls.Add(this.nameInput);
            this.gamePage.Controls.Add(this.label2);
            this.gamePage.Controls.Add(this.scoreLabel);
            this.gamePage.Controls.Add(this.restartButton);
            this.gamePage.Controls.Add(this.startButton);
            this.gamePage.Controls.Add(this.leaveButton);
            this.gamePage.Controls.Add(this.continueButton);
            this.gamePage.Location = new System.Drawing.Point(8, 39);
            this.gamePage.Name = "gamePage";
            this.gamePage.Padding = new System.Windows.Forms.Padding(3);
            this.gamePage.Size = new System.Drawing.Size(1387, 978);
            this.gamePage.TabIndex = 0;
            this.gamePage.Text = "遊玩區";
            this.gamePage.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("新細明體", 9F);
            this.nameInput.Location = new System.Drawing.Point(355, 26);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(312, 36);
            this.nameInput.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(242, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "名稱:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.scoreLabel.Location = new System.Drawing.Point(30, 29);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(132, 32);
            this.scoreLabel.TabIndex = 25;
            this.scoreLabel.Text = "分數:100";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(1120, 368);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(174, 77);
            this.restartButton.TabIndex = 24;
            this.restartButton.Text = "重新開始";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // historyPage
            // 
            this.historyPage.Controls.Add(this.recordText);
            this.historyPage.Location = new System.Drawing.Point(8, 39);
            this.historyPage.Name = "historyPage";
            this.historyPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyPage.Size = new System.Drawing.Size(1387, 978);
            this.historyPage.TabIndex = 1;
            this.historyPage.Text = "歷史紀錄區";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // recordText
            // 
            this.recordText.Location = new System.Drawing.Point(60, 38);
            this.recordText.Multiline = true;
            this.recordText.Name = "recordText";
            this.recordText.ReadOnly = true;
            this.recordText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recordText.Size = new System.Drawing.Size(1228, 755);
            this.recordText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 948);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.gamePage.ResumeLayout(false);
            this.gamePage.PerformLayout();
            this.historyPage.ResumeLayout(false);
            this.historyPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.TabPage gamePage;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox recordText;
    }
}

