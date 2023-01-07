
namespace e24106254_practice_3_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addOrDeleteBtn = new System.Windows.Forms.Button();
            this.showDangerousBtn = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.linkInput = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼管理員";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(85, 124);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(82, 24);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "搜尋列";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(211, 121);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(649, 36);
            this.searchInput.TabIndex = 2;
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultText.Location = new System.Drawing.Point(80, 337);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultText.Size = new System.Drawing.Size(923, 383);
            this.resultText.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(85, 300);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(106, 24);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "搜尋結果";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.searchBtn.Location = new System.Drawing.Point(916, 121);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(96, 38);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "搜尋";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addOrDeleteBtn
            // 
            this.addOrDeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addOrDeleteBtn.Location = new System.Drawing.Point(837, 258);
            this.addOrDeleteBtn.Name = "addOrDeleteBtn";
            this.addOrDeleteBtn.Size = new System.Drawing.Size(175, 41);
            this.addOrDeleteBtn.TabIndex = 6;
            this.addOrDeleteBtn.Text = "新增或刪除";
            this.addOrDeleteBtn.UseVisualStyleBackColor = false;
            this.addOrDeleteBtn.Click += new System.EventHandler(this.addOrDeleteBtn_Click);
            // 
            // showDangerousBtn
            // 
            this.showDangerousBtn.BackColor = System.Drawing.SystemColors.Control;
            this.showDangerousBtn.Location = new System.Drawing.Point(89, 189);
            this.showDangerousBtn.Name = "showDangerousBtn";
            this.showDangerousBtn.Size = new System.Drawing.Size(923, 43);
            this.showDangerousBtn.TabIndex = 7;
            this.showDangerousBtn.Text = "風險帳號";
            this.showDangerousBtn.UseVisualStyleBackColor = false;
            this.showDangerousBtn.Click += new System.EventHandler(this.showDangerousBtn_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(314, 423);
            this.stateLabel.MinimumSize = new System.Drawing.Size(500, 30);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(500, 30);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "我是狀態列";
            this.stateLabel.Visible = false;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(314, 498);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(58, 24);
            this.linkLabel.TabIndex = 9;
            this.linkLabel.Text = "連結";
            this.linkLabel.Visible = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(314, 549);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(82, 24);
            this.userLabel.TabIndex = 10;
            this.userLabel.Text = "使用者";
            this.userLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(314, 609);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(58, 24);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "密碼";
            this.passwordLabel.Visible = false;
            // 
            // linkInput
            // 
            this.linkInput.Location = new System.Drawing.Point(427, 498);
            this.linkInput.Name = "linkInput";
            this.linkInput.Size = new System.Drawing.Size(378, 36);
            this.linkInput.TabIndex = 12;
            this.linkInput.Visible = false;
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(427, 549);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(378, 36);
            this.userInput.TabIndex = 13;
            this.userInput.Visible = false;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(427, 597);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(378, 36);
            this.passwordInput.TabIndex = 14;
            this.passwordInput.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.Control;
            this.backBtn.Location = new System.Drawing.Point(837, 258);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(175, 41);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "回主畫面";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(709, 659);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 38);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "刪除";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addBtn.Location = new System.Drawing.Point(556, 659);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 38);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "新增";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Visible = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 817);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.linkInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.showDangerousBtn);
            this.Controls.Add(this.addOrDeleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addOrDeleteBtn;
        private System.Windows.Forms.Button showDangerousBtn;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox linkInput;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

