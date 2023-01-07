
namespace e24106254_practice_4_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "翻牌小遊戲";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(903, 159);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(174, 77);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "開始遊戲";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_click);
            // 
            // continueButton
            // 
            this.continueButton.Enabled = false;
            this.continueButton.Location = new System.Drawing.Point(903, 320);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(174, 77);
            this.continueButton.TabIndex = 18;
            this.continueButton.Text = "繼續";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(903, 500);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(174, 77);
            this.leaveButton.TabIndex = 19;
            this.leaveButton.Text = "離開遊戲";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 1074);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}

