using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e24106254_practice_5_1
{
    public partial class Form1 : Form
    {
        Button[] buttons = new Button[26];
        string word = "";
        bool started = false;
        int second = 0;
        int wrongCount = 0;

        public Form1()
        {
            InitializeComponent();
            int width = 40;
            int height = 40;
            int colNum = 10;


            for (int i = 0; i < 26; i++)
            {
                buttons[i] = new Button();
                buttons[i].Name = $"button_{i}";
                buttons[i].SetBounds(20 + (width + 10) * (i % colNum), 20 + height * (i / colNum), width, height); //(starting point X, starting point Y, width, heigth)
                buttons[i].Visible = false;
                buttons[i].Text = Convert.ToString(Convert.ToChar('A' + i));
                Controls.Add(buttons[i]);
            }
        }

        private void handleClick(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            word = "";
            foreach (Button button in buttons)
            {
                button.BackColor = Color.LightGray;
            }
            started = false;
            second = 0;
            wrongCount = 0;

            titleLabel.Visible = true;
            timesLeftLabel.Visible = true;
            wordLabel.Visible = true;
            wordInput.Visible = true;
            startButton.Visible = true;

            guessLabel.Visible = false;
            foreach (Button button in buttons)
            {
                button.Visible = false;
            }
            timeLabel.Text = $"時間:0";
            timer1.Enabled = false;
            wrongLabel.Visible = false;
            timeLabel.Visible = false;
            wordInput.Text = "";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // invalid
            if (wordInput.Text == "")
            {
                return;
            }

            titleLabel.Visible = false;
            timesLeftLabel.Visible = false;
            wordLabel.Visible = false;
            wordInput.Visible = false;
            startButton.Visible = false;

            guessLabel.Visible = true;
            foreach (Button button in buttons)
            {
                button.Visible = true;
            }

            guessLabel.Text = "";
            for (int i = 0; i < wordInput.Text.Length; i++)
            {
                guessLabel.Text += "_ ";
            }

            word = wordInput.Text;
            started = true;
            timer1.Enabled = true;
            timeLabel.Visible = true;
            wrongLabel.Visible = true;
        }

        private void wordInput_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            for (int i = 0; i < box.Text.Length; i++)
            {
                if (box.Text[i] < 'A' || box.Text[i] > 'Z')
                {
                    box.Text = box.Text.Substring(0, i) + box.Text.Substring(i + 1);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!started || e.KeyValue < 'A' || e.KeyValue > 'Z')
            {
                return;
            }

            bool correct = false;
            int code = e.KeyValue;
            // NOTE lowercase by default
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == code)
                {
                    // replace _ at i
                    guessLabel.Text = guessLabel.Text.Remove(2 * i, 2).Insert(2 * i, Convert.ToString(word[i]) + " ");
                    int num = word[i] - 'A';
                    buttons[num].BackColor = Color.LightGreen;
                    correct = true;
                }
            }

            if (!correct)
            {
                int num = code - 'A';
                buttons[num].Visible = false;

                wrongCount++;
                wrongLabel.Text = $"猜錯次數:{wrongCount}次";
                if (wrongCount == 6)
                {
                    guessLabel.Text = word;
                    MessageBox.Show("You Lose!", "", MessageBoxButtons.OK);
                    reset();
                }
            }
            else if (guessLabel.Text.IndexOf('_') == -1)
            {
                // win
                MessageBox.Show($"花費時間:{second}{Environment.NewLine}猜錯{wrongCount}次", "You win", MessageBoxButtons.OK);
                reset();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            timeLabel.Text = $"時間:{second}";
        }
    }
}
