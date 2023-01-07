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
using System.Threading;

namespace e24106254_practice_6_1
{
    public partial class Form1 : Form
    {
        Button[] beatButtons;
        const int buttonSize = 30;
        Color defaultColor = SystemColors.Control;
        Color lightColor = Color.LightGreen;
        string dingPath = @"ding.wav";
        string dongPath = @"dong.wav";
        string dooPath = @"doo.wav";

        SoundPlayer dingPlayer = new SoundPlayer();
        SoundPlayer dongPlayer = new SoundPlayer();
        SoundPlayer dooPlayer = new SoundPlayer();

        bool firstNotePlayed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            minBPM.Text = "60";
            maxBPM.Text = "180";
            BPMBar.Minimum = 60;
            BPMBar.Maximum = 180;
            BPMBar.Value = 120;
            noteButton1.Checked = true;
            emphasisBox.SelectedIndex = 0;

            dingPlayer.SoundLocation = dingPath;
            dongPlayer.SoundLocation = dongPath;
            dooPlayer.SoundLocation = dooPath;
        }

        private int getBeatInterval()
        {
            if (noteButton2.Checked)
            {
                return 60 * 1000 / BPMBar.Value / 2;// double the BPM
            }

            else
            {
                return 60 * 1000 / BPMBar.Value;
            }
        }

        private void BPMBar_ValueChanged(object sender, EventArgs e)
        {
            curBPM.Text = Convert.ToString(BPMBar.Value) + "BPM";
            beatTimer.Interval = getBeatInterval();
        }

        private void noteButton1_CheckedChanged(object sender, EventArgs e)
        {
            beatTimer.Interval = getBeatInterval();
        }

        private void noteButton2_CheckedChanged(object sender, EventArgs e)
        {
            beatTimer.Interval = getBeatInterval();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Start")
            {
                beatTimer.Enabled = true;
                beatTimer.Interval = 60 * 1000 / BPMBar.Value;

                if (noteButton2.Checked)
                {
                    beatTimer.Interval /= 2;// double the BPM
                }

                foreach (Button button in beatButtons)
                {
                    button.BackColor = defaultColor;
                }

                beatButtons[0].BackColor = lightColor;
                dingPlayer.Play();
                startButton.Text = "Stop";
            }
            else if (startButton.Text == "Stop")
            {

                foreach (Button button in beatButtons)
                {
                    button.BackColor = defaultColor;
                }
                startButton.Text = "Start";
            }
        }

        private void emphasisBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int width = beatPanel.Width;
            int buttonNum = 0;
            if (emphasisBox.SelectedItem.ToString() == "4")
            {
                buttonNum = 4;
            }
            else if (emphasisBox.SelectedItem.ToString() == "8")
            {
                buttonNum = 8;
            }

            beatButtons = new Button[buttonNum];
            beatPanel.Controls.Clear();
            for (int i = 0; i < buttonNum; i++)
            {
                beatButtons[i] = new Button();
                beatButtons[i].Name = $"beatButton{i}";
                beatButtons[i].SetBounds(((width-buttonSize) * i / (buttonNum-1)), 0, buttonSize, buttonSize);
                beatPanel.Controls.Add(beatButtons[i]);
            }

            if (beatTimer.Enabled)
            {
                beatButtons[0].BackColor = lightColor;
            }
        }

        private void beatTimer_Tick(object sender, EventArgs e)
        {
            int n = beatButtons.Length;
            for (int i = 0; i < n; i++)
            {
                if (beatButtons[i].BackColor != defaultColor)
                {
                    if (noteButton2.Checked)
                    {
                        // last note
                        if (i + 1 >= n && !firstNotePlayed)
                        {
                            dingPlayer.Play();
                            firstNotePlayed = true;
                            break;
                        }
                        else if(firstNotePlayed)
                        {
                            dooPlayer.Play();
                            beatButtons[i].BackColor = defaultColor;
                            beatButtons[i + 1 >= n ? 0 : i + 1].BackColor = lightColor;
                            firstNotePlayed = false;
                            break;
                        }
                        else
                        {
                            dongPlayer.Play();
                            firstNotePlayed = true;
                            break;
                        }
                    }
                    else if (noteButton1.Checked)
                    {
                        beatButtons[i].BackColor = defaultColor;
                        beatButtons[i + 1 >= n ? 0 : i + 1].BackColor = lightColor;
                        // last note
                        if (i + 1 >= n)
                        {
                            dingPlayer.Play();
                        }
                        else
                        {
                            dongPlayer.Play();
                        }
                        break;
                    }
                }
            }
        }
    }
}
