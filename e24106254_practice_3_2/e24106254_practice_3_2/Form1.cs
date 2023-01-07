using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e24106254_practice_3_2
{
    public partial class Form1 : Form
    {
        private Game game;
        int selectedStackIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private bool isInt(string str)
        {
            try
            {
                Convert.ToInt32(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool testIsValid()
        {
            string[] allTexts = { stackInput1.Text, stackInput2.Text, stackInput3.Text, stackInput4.Text };
            Dictionary<int, int> numCount = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 }};

            foreach (string text in allTexts)
            {
                if (text.Length == 0)
                {
                    continue;
                }

                // white space in start or end
                if(text[0]==' '||text[text.Length-1]==' ')
                {
                    return false;
                }

                string[] words = text.Split(' ');

                // too long
                if (words.Length > 4)
                {
                    return false;
                }

                foreach (string word in words)
                {
                    if (!isInt(word))
                    {
                        return false;
                    }

                    int num = Convert.ToInt32(word);
                    if (num != 1 && num != 2 && num != 3)
                    {
                        return false;
                    }

                    numCount[Convert.ToInt32(word)]++;
                }
            }

            foreach(KeyValuePair<int,int>pair in numCount)
            {
                if (pair.Value!= 3)
                {
                    return false;
                }
            }

            return true;
        }

        private void updateStackText()
        {
            stackBox1.Text = game.getStackStr(0);
            stackBox2.Text = game.getStackStr(1);
            stackBox3.Text = game.getStackStr(2);
            stackBox4.Text = game.getStackStr(3);
        }

        private void startButton_click(object sender, EventArgs e)
        {
            if (!testIsValid())
            {
                testLabel.Text = "測資錯誤";
                return;
            }

            string[] inputs = { stackInput1.Text, stackInput2.Text, stackInput3.Text, stackInput4.Text };
            game = new Game(inputs);
            updateStackText();
            Button[] buttons = { selectButton1, selectButton2, selectButton3, selectButton4 };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "選取";
                if (!game.canTake(i))
                {
                    buttons[i].Enabled = false;
                }
                else
                {
                    buttons[i].Enabled = true;
                }
            }

            testLabel.Visible = false;
            stackInput1.Visible = false;
            stackInput2.Visible = false;
            stackInput3.Visible = false;
            stackInput4.Visible = false;
            stackInputLabel1.Visible = false;
            stackInputLabel2.Visible = false;
            stackInputLabel3.Visible = false;
            stackInputLabel4.Visible = false;
            startButton.Visible = false;

            stackBox1.Visible = true;
            stackBox2.Visible = true;
            stackBox3.Visible = true;
            stackBox4.Visible = true;
            stackBoxLabel1.Visible = true;
            stackBoxLabel2.Visible = true;
            stackBoxLabel3.Visible = true;
            stackBoxLabel4.Visible = true;
            selectButton1.Visible = true;
            selectButton2.Visible = true;
            selectButton3.Visible = true;
            selectButton4.Visible = true;
            goBackButton.Visible = true;
            stateLabel.Visible = true;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            testLabel.Text = "請輸入測資";
            testLabel.Visible = true;
            stackInput1.Visible = true;
            stackInput2.Visible = true;
            stackInput3.Visible = true;
            stackInput4.Visible = true;
            stackInputLabel1.Visible = true;
            stackInputLabel2.Visible = true;
            stackInputLabel3.Visible = true;
            stackInputLabel4.Visible = true;
            startButton.Visible = true;

            stackBox1.Visible = false;
            stackBox2.Visible = false;
            stackBox3.Visible = false;
            stackBox4.Visible = false;
            stackBoxLabel1.Visible = false;
            stackBoxLabel2.Visible = false;
            stackBoxLabel3.Visible = false;
            stackBoxLabel4.Visible = false;
            selectButton1.Visible = false;
            selectButton2.Visible = false;
            selectButton3.Visible = false;
            selectButton4.Visible = false;
            goBackButton.Visible = false;
            stateLabel.Visible = false;

            // reset after winning
            stateLabel.Text = "...";
            Button[] buttons = { selectButton1, selectButton2, selectButton3, selectButton4 };
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "選取";
                buttons[i].Enabled = true;
            }
        }


        private void chooseStack(int index)
        {
            stateLabel.Text = $"你選了堆疊{index+1}";
            selectedStackIndex=index;

            Button[] buttons = { selectButton1, selectButton2, selectButton3, selectButton4 };

            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "放置";
                if (!game.canPlace(i))
                {
                    buttons[i].Enabled = false;
                }
                else
                {
                    buttons[i].Enabled = true;
                }
            }
        }

        private void place(int index)
        {
            stateLabel.Text = "...";
            game.move(selectedStackIndex,index);
            updateStackText();

            Button[] buttons = { selectButton1, selectButton2, selectButton3, selectButton4 };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "選取";
                if (!game.canTake(i))
                {
                    buttons[i].Enabled = false;
                }
                else
                {
                    buttons[i].Enabled = true;
                }
            }

            selectedStackIndex = -1;

            if (game.hasWon())
            {
                stateLabel.Text = "你贏了";
                for(int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].Text = "贏";
                    buttons[i].Enabled = false;
                }
            }
        }

        private void selectButton1_Click(object sender, EventArgs e)
        {
            if (selectButton1.Text == "選取")
            {
                chooseStack(0);
            }
            else
            {
                place(0);
            }
        }

        private void selectButton2_Click(object sender, EventArgs e)
        {
            if (selectButton2.Text == "選取")
            {
                chooseStack(1);
            }
            else
            {
                place(1);
            }
        }

        private void selectButton3_Click(object sender, EventArgs e)
        {
            if (selectButton3.Text == "選取")
            {
                chooseStack(2);
            }
            else
            {
                place(2);
            }
        }

        private void selectButton4_Click(object sender, EventArgs e)
        {
            if (selectButton4.Text == "選取")
            {
                chooseStack(3);
            }
            else
            {
                place(3);
            }
        }

    }

}
