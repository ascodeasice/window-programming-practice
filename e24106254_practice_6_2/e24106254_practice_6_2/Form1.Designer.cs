
namespace e24106254_practice_6_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.telephoneTab = new System.Windows.Forms.TabPage();
            this.soundPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.soundPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.dialButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.logTab = new System.Windows.Forms.TabPage();
            this.dialedNumbersTextBox = new System.Windows.Forms.TextBox();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.telephoneTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPlayer1)).BeginInit();
            this.logTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.telephoneTab);
            this.tabControl.Controls.Add(this.logTab);
            this.tabControl.Location = new System.Drawing.Point(50, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1293, 1047);
            this.tabControl.TabIndex = 0;
            this.tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
            this.tabControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyUp);
            // 
            // telephoneTab
            // 
            this.telephoneTab.Controls.Add(this.soundPlayer2);
            this.telephoneTab.Controls.Add(this.soundPlayer1);
            this.telephoneTab.Controls.Add(this.dialButtonPanel);
            this.telephoneTab.Controls.Add(this.telephoneLabel);
            this.telephoneTab.Location = new System.Drawing.Point(8, 39);
            this.telephoneTab.Name = "telephoneTab";
            this.telephoneTab.Padding = new System.Windows.Forms.Padding(3);
            this.telephoneTab.Size = new System.Drawing.Size(1277, 1000);
            this.telephoneTab.TabIndex = 0;
            this.telephoneTab.Text = "Telephone";
            this.telephoneTab.UseVisualStyleBackColor = true;
            // 
            // soundPlayer2
            // 
            this.soundPlayer2.Enabled = true;
            this.soundPlayer2.Location = new System.Drawing.Point(724, 122);
            this.soundPlayer2.Name = "soundPlayer2";
            this.soundPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("soundPlayer2.OcxState")));
            this.soundPlayer2.Size = new System.Drawing.Size(138, 55);
            this.soundPlayer2.TabIndex = 3;
            this.soundPlayer2.Visible = false;
            // 
            // soundPlayer1
            // 
            this.soundPlayer1.Enabled = true;
            this.soundPlayer1.Location = new System.Drawing.Point(508, 122);
            this.soundPlayer1.Name = "soundPlayer1";
            this.soundPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("soundPlayer1.OcxState")));
            this.soundPlayer1.Size = new System.Drawing.Size(138, 55);
            this.soundPlayer1.TabIndex = 2;
            this.soundPlayer1.Visible = false;
            // 
            // dialButtonPanel
            // 
            this.dialButtonPanel.Location = new System.Drawing.Point(307, 232);
            this.dialButtonPanel.Name = "dialButtonPanel";
            this.dialButtonPanel.Size = new System.Drawing.Size(671, 745);
            this.dialButtonPanel.TabIndex = 1;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("新細明體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.telephoneLabel.Location = new System.Drawing.Point(42, 39);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(242, 53);
            this.telephoneLabel.TabIndex = 0;
            this.telephoneLabel.Text = "Telephone";
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.dialedNumbersTextBox);
            this.logTab.Controls.Add(this.pathInput);
            this.logTab.Controls.Add(this.SaveLabel);
            this.logTab.Controls.Add(this.saveButton);
            this.logTab.Location = new System.Drawing.Point(8, 39);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(3);
            this.logTab.Size = new System.Drawing.Size(1277, 1000);
            this.logTab.TabIndex = 1;
            this.logTab.Text = "Log";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // dialedNumbersTextBox
            // 
            this.dialedNumbersTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dialedNumbersTextBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.dialedNumbersTextBox.Location = new System.Drawing.Point(189, 225);
            this.dialedNumbersTextBox.Multiline = true;
            this.dialedNumbersTextBox.Name = "dialedNumbersTextBox";
            this.dialedNumbersTextBox.ReadOnly = true;
            this.dialedNumbersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dialedNumbersTextBox.Size = new System.Drawing.Size(815, 579);
            this.dialedNumbersTextBox.TabIndex = 3;
            // 
            // pathInput
            // 
            this.pathInput.Location = new System.Drawing.Point(300, 97);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(548, 36);
            this.pathInput.TabIndex = 2;
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.SaveLabel.Location = new System.Drawing.Point(185, 100);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(73, 32);
            this.SaveLabel.TabIndex = 1;
            this.SaveLabel.Text = "Save";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.saveButton.Location = new System.Drawing.Point(894, 97);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 47);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 1159);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Telephone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.telephoneTab.ResumeLayout(false);
            this.telephoneTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPlayer1)).EndInit();
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage telephoneTab;
        private System.Windows.Forms.FlowLayoutPanel dialButtonPanel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.TextBox dialedNumbersTextBox;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Button saveButton;
        private AxWMPLib.AxWindowsMediaPlayer soundPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer soundPlayer2;
    }
}

