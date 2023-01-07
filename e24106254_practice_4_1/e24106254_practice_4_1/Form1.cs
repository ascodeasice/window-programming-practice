using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e24106254_practice_4_1
{
    public partial class Form1 : Form
    {
        Button[] cards =new Button[16];
        int[] cardNums = new int [16];
        bool[] correctCards = new bool[16];
        int chosenNum = -1;
        int chosenNum2 = -1;

        public Form1()
        {
            InitializeComponent();

            int width = 80;
            int height = 100;

            for (int i = 0; i < 16; i++)
            {
                cards[i] = new Button();
                cards[i].Name = $"button_{i}";
                cards[i].SetBounds(20 + (width + 10) * (i % 4), 40 + height * (i / 4), width, height); //(starting point X, starting point Y, width, heigth)
                Controls.Add(cards[i]);
                cards[i].BackgroundImageLayout = ImageLayout.Stretch;
                cards[i].BackgroundImage = imageList1.Images[8];
                cards[i].Visible = false;
                cards[i].Click += handleClick;
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

        private void handleClick(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            int index=Convert.ToInt32(self.Name.Split('_')[1]);

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
                chosenNum2 = index;

                cards[index].Enabled = false;
                cards[index].BackgroundImage = ConvertToGrayscale(new Bitmap(cards[index].BackgroundImage));
                
                cards[chosenNum].BackgroundImage = ConvertToGrayscale(new Bitmap(cards[chosenNum].BackgroundImage));
                cards[chosenNum].Enabled = false;
                
                correctCards[chosenNum] = true;
                correctCards[chosenNum2] = true;

                chosenNum = -1;
                chosenNum2 = -1;

                foreach(bool correct in correctCards)
                {
                    if (!correct)
                    {
                        return;
                    }
                }

                // win
                MessageBox.Show("你贏了", "", MessageBoxButtons.OK);
            }
            else
            {
                chosenNum2 = index;

                // not the same
                foreach(Button card in cards)
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
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private void startButton_click(object sender, EventArgs e)
        {
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
            Application.Exit();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < cards.Length; i++)
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
    }
}
