using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e24106254_practice_4_2
{
    public partial class Form1 : Form
    {
        // maybe I should've used a class
        Button[] cards = new Button[16];
        int[] cardNums = new int[16];
        bool[] correctCards = new bool[16];
        int chosenNum = -1;
        int chosenNum2 = -1;
        int curScore = 100;
        string playerName = "";

        public Form1()
        {
            InitializeComponent();

            int width = 60;
            int height = 80;

            for (int i = 0; i < 16; i++)
            {
                cards[i] = new Button();
                cards[i].Name = $"button_{i}";
                //(starting point X, starting point Y, width, heigth)
                cards[i].SetBounds(20 + (width + 10) * (i % 4), 60 + height * (i / 4), width, height); 
                cards[i].BackgroundImageLayout = ImageLayout.Stretch;
                cards[i].BackgroundImage = imageList1.Images[8];
                cards[i].Visible = false;
                cards[i].Click += clickCard;
                gamePage.Controls.Add(cards[i]);
            }
        }

        private static Bitmap ConvertToGrayscale(Bitmap source)
        {
            var bm = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    var luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    bm.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            return bm;
        }

        private void updateScore(int val)
        {
            curScore = val;
            scoreLabel.Text = $"分數:{Convert.ToString(val)}";
        }

        private void recordPlay()
        {
            recordText.Text += $"{playerName} 得分為 : {curScore}" + Environment.NewLine + Environment.NewLine;
        }

        private void clickCard(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            int index = Convert.ToInt32(self.Name.Split('_')[1]);

            cards[index].BackgroundImage = imageList1.Images[cardNums[index]];

            // first flip
            if (chosenNum == -1)
            {
                chosenNum = index;
                cards[chosenNum].Enabled = false;
            }
            // disable cards if same cards are clicked
            else if (cardNums[index] == cardNums[chosenNum])
            {
                updateScore(curScore + 10);
                chosenNum2 = index;

                cards[index].Enabled = false;
                cards[index].BackgroundImage = ConvertToGrayscale(new Bitmap(cards[index].BackgroundImage));

                cards[chosenNum].BackgroundImage = ConvertToGrayscale(new Bitmap(cards[chosenNum].BackgroundImage));
                cards[chosenNum].Enabled = false;

                correctCards[chosenNum] = true;
                correctCards[chosenNum2] = true;

                chosenNum = -1;
                chosenNum2 = -1;

                foreach (bool correct in correctCards)
                {
                    if (!correct)
                    {
                        return;
                    }
                }

                // win
                recordPlay();
                DialogResult result=MessageBox.Show($"分數:{curScore}", "遊戲結束", MessageBoxButtons.RetryCancel,MessageBoxIcon.Asterisk);
                if (result == DialogResult.Retry)
                {
                    restartButton_Click(null,null);
                }
            }
            else
            {
                // wrong card
                updateScore(curScore - 5);
                chosenNum2 = index;

                foreach (Button card in cards)
                {
                    card.Enabled = false;
                }
                continueButton.Enabled = true;
            }
        }

        private void shuffle(ref int[] arr)
        {
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private void startButton_click(object sender, EventArgs e)
        {
            // SECTION validation

            if (nameInput.Text == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (nameInput.Text.Length<3||nameInput.Text.Length>10)
            {
                MessageBox.Show("名稱不合格式(>=3&&<=10)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            playerName = nameInput.Text;
            nameInput.ReadOnly = true;
            for (int i = 0; i < 16; i++)
            {
                cardNums[i] = i >= 8 ? i - 8 : i;
                cards[i].Visible = true;
            }

            shuffle(ref cardNums);

            startButton.Enabled = false;
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要離開遊戲嗎?", "離開遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void continueButton_click(object sender, EventArgs e)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (correctCards[i])
                {
                    continue;
                }
                cards[i].Enabled = true;
            }

            cards[chosenNum].BackgroundImage = imageList1.Images[8];
            cards[chosenNum2].BackgroundImage = imageList1.Images[8];

            // reset state
            continueButton.Enabled = false;
            chosenNum = -1;
            chosenNum2 = -1;

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            nameInput.Text = "";
            nameInput.ReadOnly = false;

            updateScore(100);
            playerName = "";
            chosenNum = -1;
            chosenNum2 = -1;

            shuffle(ref cardNums);
            foreach (Button card in cards)
            {
                card.BackgroundImage = imageList1.Images[8];
                card.Visible = false;
                card.Enabled = true;
            }

            for(int i = 0; i < 16; i++)
            {
                correctCards[i] = false;
            }

            startButton.Enabled = true;
        }
    }
}
