using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace e24106254_practice_6_2
{
    public partial class Form1 : Form
    {
        string defaultText = "Telephone";

        // to get path: audioPaths[buttonAudioIndexes[button text][0 or 1]]
        string[] audioPaths = { @".\audio\697.wav", @".\audio\770.wav", @".\audio\852.wav", @".\audio\941.wav", @".\audio\1209.wav", @".\audio\1336.wav", @".\audio\1477.wav" };
        Dictionary<string, int[]> buttonAudioIndexes =
        new Dictionary<string, int[]>()
        {
            {"1",new int[2] {0,4} },
            {"2",new int[2] {0,5} },
            {"3",new int[2] {0,6} },
            {"4",new int[2] {1,4} },
            {"5",new int[2] {1,5} },
            {"6",new int[2] {1,6} },
            {"7",new int[2] {2,4} },
            {"8",new int[2] {2,5} },
            {"9",new int[2] {2,6} },
            {"*",new int[2] {3,4} },
            {"0",new int[2] {3,5} },
            {"#",new int[2] {3,6} }
        };

        string backSymbol = "⬅️";
        string callSymbol = "📱";

        string[] phoneButtonTexts = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#", "❌", "📱", "⬅️" };
        Button[] phoneButtons;
        int dialButtonSize = 60;

        List<string> dialedNumbers = new List<string>();

        bool keyboardEventIsTriggered = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void recordCall(string number)
        {
            dialedNumbers.Add(number);

            dialedNumbersTextBox.Text = "";
            foreach (string text in dialedNumbers)
            {
                dialedNumbersTextBox.Text += (text + Environment.NewLine);
            }
        }

        private void handlePhoneButtonMouseDown(object sender, EventArgs e)
        {
            Button self = (Button)sender;

            switch (self.Text)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "*":
                case "0":
                case "#":
                    // play the sound and change text
                    if (telephoneLabel.Text == defaultText)
                    {
                        telephoneLabel.Text = "";
                    }
                    telephoneLabel.Text += self.Text;

                    // play corresponding sound
                    string path1 = audioPaths[buttonAudioIndexes[self.Text][0]];
                    string path2 = audioPaths[buttonAudioIndexes[self.Text][1]];
                    soundPlayer1.URL = path1;
                    soundPlayer2.URL = path2;

                    // should play at the same time
                    soundPlayer1.Ctlcontrols.play();
                    soundPlayer2.Ctlcontrols.play();

                    // NOTE You can enable this line to test
                    //Console.WriteLine($"playing {path1} and {path2}");
                    break;
                case "❌":
                    telephoneLabel.Text = "";
                    break;
                case "📱":
                    foreach (Button button in phoneButtons)
                    {
                        button.Enabled = false;
                    }

                    self.Enabled = true;
                    self.Text = "📵";
                    break;
                // hang up
                case "📵":
                    foreach (Button button in phoneButtons)
                    {
                        button.Enabled = true;
                    }
                    self.Text = "📱";
                    // record the call
                    recordCall(telephoneLabel.Text);
                    telephoneLabel.Text = defaultText;
                    break;
                case "⬅️":
                    if (telephoneLabel.Text == defaultText || telephoneLabel.Text == "")
                    {
                        break;
                    }
                    telephoneLabel.Text = telephoneLabel.Text.Remove(telephoneLabel.Text.Length - 1, 1);
                    break;
                default:
                    Console.WriteLine("Undefined behavior");
                    break;
            }
        }

        private void handlePhoneButtonMouseUp(object sender, EventArgs e)
        {
            soundPlayer1.Ctlcontrols.stop();
            soundPlayer2.Ctlcontrols.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(tabControl.Width + 100, tabControl.Height + 100);

            telephoneLabel.Text = "Telephone";
            phoneButtons = new Button[phoneButtonTexts.Length];

            for (int i = 0; i < phoneButtonTexts.Length; i++)
            {
                phoneButtons[i] = new Button();
                phoneButtons[i].Text = phoneButtonTexts[i];
                phoneButtons[i].Width = dialButtonSize;
                phoneButtons[i].Height = dialButtonSize;

                phoneButtons[i].MouseDown += handlePhoneButtonMouseDown;
                phoneButtons[i].MouseUp += handlePhoneButtonMouseUp;
                phoneButtons[i].Font = new Font("新細明體", 15f, FontStyle.Bold);

                // 2,5,8... needs to break
                // NOTE index of 2,5,8 are the last in a row
                if ((i + 1) % 3 == 0)
                    dialButtonPanel.SetFlowBreak(phoneButtons[i], true);

                dialButtonPanel.Controls.Add(phoneButtons[i]);

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string path = pathInput.Text;

            if (path == "")
            {
                MessageBox.Show("Empty String", "");
            }
            else if (!File.Exists(path))
            {
                MessageBox.Show("Directory Not Found", "");
            }
            else
            {
                FileInfo fileInfo = new FileInfo(path);
                StreamWriter sw = fileInfo.AppendText();
                foreach (string number in dialedNumbers)
                {
                    sw.WriteLine(number);
                }
                sw.Flush();
                sw.Close();

                MessageBox.Show($"Done{Environment.NewLine}{fileInfo.FullName}", "");
                // write to file
            }
        }

        private void tabControl_KeyDown(object sender, KeyEventArgs e)
        {
            // use index to decide which button to press
            int buttonIndex = -1;

            if (tabControl.SelectedTab == logTab || keyboardEventIsTriggered)
            {
                return;
            }

            else if (e.Modifiers == Keys.Shift && e.KeyValue == '8')
            {
                buttonIndex = Array.IndexOf(phoneButtonTexts, "*");
            }
            else if (e.Modifiers == Keys.Shift && e.KeyValue == '3')
            {
                buttonIndex = Array.IndexOf(phoneButtonTexts, "#");
            }
            else if (e.KeyCode == Keys.Back)
            {
                buttonIndex = Array.IndexOf(phoneButtonTexts, backSymbol);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonIndex = Array.IndexOf(phoneButtonTexts, callSymbol);
            }
            else if (e.KeyValue >= '0' && e.KeyValue <= '9')
            {
                string numStr = Convert.ToString(Convert.ToChar(e.KeyValue));
                buttonIndex = Array.IndexOf(phoneButtonTexts, numStr);
            }

            // mock the keydown event
            if (buttonIndex != -1)
            {
                handlePhoneButtonMouseDown(phoneButtons[buttonIndex], null);
                keyboardEventIsTriggered = true;
            }
        }

        private void tabControl_KeyUp(object sender, KeyEventArgs e)
        {
            handlePhoneButtonMouseUp(null, null);
            keyboardEventIsTriggered = false;
        }
    }
}
