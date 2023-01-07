
namespace e24106254_practice_3_2
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
            this.stackInputLabel1 = new System.Windows.Forms.Label();
            this.stackInputLabel2 = new System.Windows.Forms.Label();
            this.stackInputLabel3 = new System.Windows.Forms.Label();
            this.stackInputLabel4 = new System.Windows.Forms.Label();
            this.stackInput1 = new System.Windows.Forms.TextBox();
            this.stackInput2 = new System.Windows.Forms.TextBox();
            this.stackInput3 = new System.Windows.Forms.TextBox();
            this.stackInput4 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.stackBoxLabel1 = new System.Windows.Forms.Label();
            this.stackBoxLabel2 = new System.Windows.Forms.Label();
            this.stackBoxLabel3 = new System.Windows.Forms.Label();
            this.stackBoxLabel4 = new System.Windows.Forms.Label();
            this.selectButton1 = new System.Windows.Forms.Button();
            this.selectButton2 = new System.Windows.Forms.Button();
            this.selectButton3 = new System.Windows.Forms.Button();
            this.selectButton4 = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stackBox1 = new System.Windows.Forms.Label();
            this.stackBox2 = new System.Windows.Forms.Label();
            this.stackBox3 = new System.Windows.Forms.Label();
            this.stackBox4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stackInputLabel1
            // 
            this.stackInputLabel1.AutoSize = true;
            this.stackInputLabel1.Location = new System.Drawing.Point(87, 113);
            this.stackInputLabel1.Name = "stackInputLabel1";
            this.stackInputLabel1.Size = new System.Drawing.Size(69, 24);
            this.stackInputLabel1.TabIndex = 1;
            this.stackInputLabel1.Text = "堆疊1";
            // 
            // stackInputLabel2
            // 
            this.stackInputLabel2.AutoSize = true;
            this.stackInputLabel2.Location = new System.Drawing.Point(87, 210);
            this.stackInputLabel2.Name = "stackInputLabel2";
            this.stackInputLabel2.Size = new System.Drawing.Size(69, 24);
            this.stackInputLabel2.TabIndex = 2;
            this.stackInputLabel2.Text = "堆疊2";
            // 
            // stackInputLabel3
            // 
            this.stackInputLabel3.AutoSize = true;
            this.stackInputLabel3.Location = new System.Drawing.Point(87, 293);
            this.stackInputLabel3.Name = "stackInputLabel3";
            this.stackInputLabel3.Size = new System.Drawing.Size(69, 24);
            this.stackInputLabel3.TabIndex = 3;
            this.stackInputLabel3.Text = "堆疊3";
            // 
            // stackInputLabel4
            // 
            this.stackInputLabel4.AutoSize = true;
            this.stackInputLabel4.Location = new System.Drawing.Point(87, 376);
            this.stackInputLabel4.Name = "stackInputLabel4";
            this.stackInputLabel4.Size = new System.Drawing.Size(69, 24);
            this.stackInputLabel4.TabIndex = 4;
            this.stackInputLabel4.Text = "堆疊4";
            // 
            // stackInput1
            // 
            this.stackInput1.Location = new System.Drawing.Point(261, 110);
            this.stackInput1.Name = "stackInput1";
            this.stackInput1.Size = new System.Drawing.Size(278, 36);
            this.stackInput1.TabIndex = 5;
            this.stackInput1.Text = "1 1 2";
            // 
            // stackInput2
            // 
            this.stackInput2.Location = new System.Drawing.Point(261, 207);
            this.stackInput2.Name = "stackInput2";
            this.stackInput2.Size = new System.Drawing.Size(278, 36);
            this.stackInput2.TabIndex = 6;
            this.stackInput2.Text = "2 2";
            // 
            // stackInput3
            // 
            this.stackInput3.Location = new System.Drawing.Point(261, 290);
            this.stackInput3.Name = "stackInput3";
            this.stackInput3.Size = new System.Drawing.Size(278, 36);
            this.stackInput3.TabIndex = 7;
            // 
            // stackInput4
            // 
            this.stackInput4.Location = new System.Drawing.Point(261, 373);
            this.stackInput4.Name = "stackInput4";
            this.stackInput4.Size = new System.Drawing.Size(278, 36);
            this.stackInput4.TabIndex = 8;
            this.stackInput4.Text = "3 3 3 1";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startButton.Location = new System.Drawing.Point(333, 470);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(153, 42);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "開始遊戲";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.testLabel.Location = new System.Drawing.Point(72, 40);
            this.testLabel.MinimumSize = new System.Drawing.Size(500, 20);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(500, 26);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "請輸入測資";
            // 
            // stackBoxLabel1
            // 
            this.stackBoxLabel1.AutoSize = true;
            this.stackBoxLabel1.Location = new System.Drawing.Point(91, 70);
            this.stackBoxLabel1.Name = "stackBoxLabel1";
            this.stackBoxLabel1.Size = new System.Drawing.Size(69, 24);
            this.stackBoxLabel1.TabIndex = 10;
            this.stackBoxLabel1.Text = "堆疊1";
            this.stackBoxLabel1.Visible = false;
            // 
            // stackBoxLabel2
            // 
            this.stackBoxLabel2.AutoSize = true;
            this.stackBoxLabel2.Location = new System.Drawing.Point(248, 70);
            this.stackBoxLabel2.Name = "stackBoxLabel2";
            this.stackBoxLabel2.Size = new System.Drawing.Size(69, 24);
            this.stackBoxLabel2.TabIndex = 11;
            this.stackBoxLabel2.Text = "堆疊2";
            this.stackBoxLabel2.Visible = false;
            // 
            // stackBoxLabel3
            // 
            this.stackBoxLabel3.AutoSize = true;
            this.stackBoxLabel3.Location = new System.Drawing.Point(404, 70);
            this.stackBoxLabel3.Name = "stackBoxLabel3";
            this.stackBoxLabel3.Size = new System.Drawing.Size(69, 24);
            this.stackBoxLabel3.TabIndex = 12;
            this.stackBoxLabel3.Text = "堆疊3";
            this.stackBoxLabel3.Visible = false;
            // 
            // stackBoxLabel4
            // 
            this.stackBoxLabel4.AutoSize = true;
            this.stackBoxLabel4.Location = new System.Drawing.Point(565, 70);
            this.stackBoxLabel4.Name = "stackBoxLabel4";
            this.stackBoxLabel4.Size = new System.Drawing.Size(69, 24);
            this.stackBoxLabel4.TabIndex = 13;
            this.stackBoxLabel4.Text = "堆疊4";
            this.stackBoxLabel4.Visible = false;
            // 
            // selectButton1
            // 
            this.selectButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectButton1.Location = new System.Drawing.Point(82, 488);
            this.selectButton1.Name = "selectButton1";
            this.selectButton1.Size = new System.Drawing.Size(90, 41);
            this.selectButton1.TabIndex = 18;
            this.selectButton1.Text = "選取";
            this.selectButton1.UseVisualStyleBackColor = false;
            this.selectButton1.Visible = false;
            this.selectButton1.Click += new System.EventHandler(this.selectButton1_Click);
            // 
            // selectButton2
            // 
            this.selectButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectButton2.Location = new System.Drawing.Point(252, 488);
            this.selectButton2.Name = "selectButton2";
            this.selectButton2.Size = new System.Drawing.Size(90, 41);
            this.selectButton2.TabIndex = 19;
            this.selectButton2.Text = "選取";
            this.selectButton2.UseVisualStyleBackColor = false;
            this.selectButton2.Visible = false;
            this.selectButton2.Click += new System.EventHandler(this.selectButton2_Click);
            // 
            // selectButton3
            // 
            this.selectButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectButton3.Location = new System.Drawing.Point(396, 488);
            this.selectButton3.Name = "selectButton3";
            this.selectButton3.Size = new System.Drawing.Size(90, 41);
            this.selectButton3.TabIndex = 20;
            this.selectButton3.Text = "選取";
            this.selectButton3.UseVisualStyleBackColor = false;
            this.selectButton3.Visible = false;
            this.selectButton3.Click += new System.EventHandler(this.selectButton3_Click);
            // 
            // selectButton4
            // 
            this.selectButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectButton4.Location = new System.Drawing.Point(544, 488);
            this.selectButton4.Name = "selectButton4";
            this.selectButton4.Size = new System.Drawing.Size(90, 41);
            this.selectButton4.TabIndex = 21;
            this.selectButton4.Text = "選取";
            this.selectButton4.UseVisualStyleBackColor = false;
            this.selectButton4.Visible = false;
            this.selectButton4.Click += new System.EventHandler(this.selectButton4_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.goBackButton.Location = new System.Drawing.Point(481, 584);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(153, 42);
            this.goBackButton.TabIndex = 22;
            this.goBackButton.Text = "回主畫面";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Visible = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stateLabel.Location = new System.Drawing.Point(91, 593);
            this.stateLabel.MinimumSize = new System.Drawing.Size(300, 30);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(300, 30);
            this.stateLabel.TabIndex = 23;
            this.stateLabel.Text = "...";
            this.stateLabel.Visible = false;
            // 
            // stackBox1
            // 
            this.stackBox1.AutoSize = true;
            this.stackBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stackBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stackBox1.Location = new System.Drawing.Point(82, 113);
            this.stackBox1.MinimumSize = new System.Drawing.Size(90, 351);
            this.stackBox1.Name = "stackBox1";
            this.stackBox1.Size = new System.Drawing.Size(90, 351);
            this.stackBox1.TabIndex = 24;
            this.stackBox1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stackBox1.Visible = false;
            // 
            // stackBox2
            // 
            this.stackBox2.AutoSize = true;
            this.stackBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stackBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stackBox2.Location = new System.Drawing.Point(252, 116);
            this.stackBox2.MinimumSize = new System.Drawing.Size(90, 351);
            this.stackBox2.Name = "stackBox2";
            this.stackBox2.Size = new System.Drawing.Size(90, 351);
            this.stackBox2.TabIndex = 25;
            this.stackBox2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stackBox2.Visible = false;
            // 
            // stackBox3
            // 
            this.stackBox3.AutoSize = true;
            this.stackBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stackBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stackBox3.Location = new System.Drawing.Point(408, 113);
            this.stackBox3.MinimumSize = new System.Drawing.Size(90, 351);
            this.stackBox3.Name = "stackBox3";
            this.stackBox3.Size = new System.Drawing.Size(90, 351);
            this.stackBox3.TabIndex = 26;
            this.stackBox3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stackBox3.Visible = false;
            // 
            // stackBox4
            // 
            this.stackBox4.AutoSize = true;
            this.stackBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stackBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stackBox4.Location = new System.Drawing.Point(544, 113);
            this.stackBox4.MinimumSize = new System.Drawing.Size(90, 351);
            this.stackBox4.Name = "stackBox4";
            this.stackBox4.Size = new System.Drawing.Size(90, 351);
            this.stackBox4.TabIndex = 27;
            this.stackBox4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stackBox4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 702);
            this.Controls.Add(this.stackBox4);
            this.Controls.Add(this.stackBox3);
            this.Controls.Add(this.stackBox2);
            this.Controls.Add(this.stackBox1);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.selectButton4);
            this.Controls.Add(this.selectButton3);
            this.Controls.Add(this.selectButton2);
            this.Controls.Add(this.selectButton1);
            this.Controls.Add(this.stackBoxLabel4);
            this.Controls.Add(this.stackBoxLabel3);
            this.Controls.Add(this.stackBoxLabel2);
            this.Controls.Add(this.stackBoxLabel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stackInput4);
            this.Controls.Add(this.stackInput3);
            this.Controls.Add(this.stackInput2);
            this.Controls.Add(this.stackInput1);
            this.Controls.Add(this.stackInputLabel4);
            this.Controls.Add(this.stackInputLabel3);
            this.Controls.Add(this.stackInputLabel2);
            this.Controls.Add(this.stackInputLabel1);
            this.Controls.Add(this.testLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stackInputLabel1;
        private System.Windows.Forms.Label stackInputLabel2;
        private System.Windows.Forms.Label stackInputLabel3;
        private System.Windows.Forms.Label stackInputLabel4;
        private System.Windows.Forms.TextBox stackInput1;
        private System.Windows.Forms.TextBox stackInput2;
        private System.Windows.Forms.TextBox stackInput3;
        private System.Windows.Forms.TextBox stackInput4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label stackBoxLabel1;
        private System.Windows.Forms.Label stackBoxLabel2;
        private System.Windows.Forms.Label stackBoxLabel3;
        private System.Windows.Forms.Label stackBoxLabel4;
        private System.Windows.Forms.Button selectButton1;
        private System.Windows.Forms.Button selectButton2;
        private System.Windows.Forms.Button selectButton3;
        private System.Windows.Forms.Button selectButton4;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label stackBox1;
        private System.Windows.Forms.Label stackBox2;
        private System.Windows.Forms.Label stackBox3;
        private System.Windows.Forms.Label stackBox4;
    }
}

