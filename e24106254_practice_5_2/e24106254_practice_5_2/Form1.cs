using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e24106254_practice_5_2
{
    public partial class Form1 : Form
    {
        const int rowNum = 7;
        const int colNum = 6;
        Button[,] board = new Button[rowNum, colNum];
        int time = 10;
        Color playerColor1 = Color.LightBlue;
        Color playerColor2 = Color.LightPink;
        string phase = "prepare1";

        /*  pieceArr: [piece1,piece2...]
            pieceIndex:[[-1,0,-1,1,-1...],...]
            to get piece, get pieceArr[pieceIndex[row][col]]
         */
        int[,] pieceIndex = new int[rowNum, colNum];
        Piece[] pieceArr = { new Warrior("1"), new Mage("1"), new Ranger("1"), new Warrior("2"), new Mage("2"), new Ranger("2") };
        int curPieceIndex = -1;
        Button curChosenButton = null;

        // battle phase variable
        int curActionCharacterIndex = 0;
        string curAction = "";
        int player1AliveCount = 3;
        int player2AliveCount = 3;

        public Form1()
        {
            InitializeComponent();

            // initialize pieces on board
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    pieceIndex[i, j] = -1;
                }
            }
        }

        private void endPrepare1()
        {
            phase = "prepare2";
            time = 10;
            timeLabel.Text = Convert.ToString(time);
            setEnableLeftBoard(false);
            setEnableRightBoard(true);
            characterButton_2_3.Enabled = true;
            characterButton_2_4.Enabled = true;
            characterButton_2_5.Enabled = true;
        }

        private void endPrepare2()
        {
            setEnableLeftBoard(true);

            characterButton_1_0.Visible = false;
            characterButton_1_1.Visible = false;
            characterButton_1_2.Visible = false;
            characterButton_2_3.Visible = false;
            characterButton_2_4.Visible = false;
            characterButton_2_5.Visible = false;

            pieceStateLabel1.Visible = true;
            pieceStateLabel2.Visible = true;
            attack_button1.Visible = true;
            move_button1.Visible = true;
            skill_button1.Visible = true;
            wait_button1.Visible = true;
            end_button1.Visible = true;
            attack_button2.Visible = true;
            move_button2.Visible = true;
            skill_button2.Visible = true;
            wait_button2.Visible = true;
            end_button2.Visible = true;

            prepareTimer.Enabled = false;
            timeLabel.Text = "";

            phase = "P1 Turn";
            phaseLabel.Text = "P1 Turn";

            pieceLabel1.Text = pieceArr[curActionCharacterIndex].character;
            pieceLabel2.Text = "";
            pieceStateLabel1.Text = pieceArr[curActionCharacterIndex].getStateStr();
            pieceStateLabel2.Text = "";

            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    board[i, j].Enabled = true;
                }
            }
        }

        private void placePiece(int row, int col, int placePieceIndex, Color color)
        {
            pieceIndex[row, col] = placePieceIndex;
            pieceArr[placePieceIndex].row = row;
            pieceArr[placePieceIndex].col = col;

            board[row, col].BackColor = color;
            board[row, col].Text = pieceArr[placePieceIndex].character;

            curChosenButton.Text = $"{pieceArr[placePieceIndex].character}:0顆";
            curChosenButton.Enabled = false;

            curPieceIndex = -1;
        }

        private void removePiece(int row, int col)
        {
            pieceArr[pieceIndex[row, col]].row = -1;
            pieceArr[pieceIndex[row, col]].col = -1;
            pieceIndex[row, col] = -1;

            board[row, col].BackColor = SystemColors.ControlLight;
            board[row, col].Text = "";
        }

        private void endGame()
        {
            if (player1AliveCount == 0)
            {
                MessageBox.Show("P2 贏了", "", MessageBoxButtons.OK);
            }
            else if (player2AliveCount == 0)
            {
                MessageBox.Show("P1 贏了", "", MessageBoxButtons.OK);
            }
            Application.Exit();
        }

        private void handleAction(int row, int col)
        {
            // works if pass by reference
            Piece curPiece = pieceArr[curActionCharacterIndex];
            int otherIndex = pieceIndex[row, col];

            switch (curAction)
            {
                case "attack":
                    if (otherIndex == -1)
                    {
                        MessageBox.Show("沒有敵人", "", MessageBoxButtons.OK);
                        break;
                    }
                    // wrong direction or out of range
                    if (curPiece.outOfAttackRange(row, col))
                    {
                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                        break;
                    }
                    if (curPiece.team == pieceArr[otherIndex].team)
                    {
                        MessageBox.Show("不能攻擊隊友", "", MessageBoxButtons.OK);
                        break;
                    }

                    curPiece.attack(ref pieceArr[otherIndex]);
                    if (phase == "P1 Turn")
                    {
                        updateCharacterLabel(pieceArr[otherIndex], pieceLabel2, pieceStateLabel2);
                    }
                    else if (phase == "P2 Turn")
                    {
                        updateCharacterLabel(pieceArr[otherIndex], pieceLabel1, pieceStateLabel1);
                    }

                    if (pieceArr[otherIndex].isDead())
                    {
                        removePiece(pieceArr[otherIndex].row, pieceArr[otherIndex].col);
                        if (phase == "P1 Turn")
                        {
                            player2AliveCount--;
                        }
                        else if (phase == "P2 Turn")
                        {
                            player1AliveCount--;
                        }

                        if (player1AliveCount == 0 || player2AliveCount == 0)
                        {
                            endGame();
                        }
                    }
                    endCharacterAction();
                    break;
                case "skill":
                    if (otherIndex == -1)
                    {
                        MessageBox.Show("沒有敵人", "", MessageBoxButtons.OK);
                        break;
                    }
                    if (curPiece.mp < 10)
                    {
                        MessageBox.Show("魔力不足", "", MessageBoxButtons.OK);
                        break;
                    }
                    if (curPiece.outOfSkillRange(row, col))
                    {
                        MessageBox.Show("超出技能範圍", "", MessageBoxButtons.OK);
                        break;
                    }
                    if (curPiece.team == pieceArr[otherIndex].team)
                    {
                        MessageBox.Show("不能攻擊隊友", "", MessageBoxButtons.OK);
                        break;
                    }

                    curPiece.skill(ref pieceArr[otherIndex]);
                    if (phase == "P1 Turn")
                    {
                        updateCharacterLabel(pieceArr[otherIndex], pieceLabel2, pieceStateLabel2);
                    }
                    else if (phase == "P2 Turn")
                    {
                        updateCharacterLabel(pieceArr[otherIndex], pieceLabel1, pieceStateLabel1);
                    }


                    if (pieceArr[otherIndex].isDead())
                    {
                        removePiece(pieceArr[otherIndex].row, pieceArr[otherIndex].col);
                        if (phase == "P1 Turn")
                        {
                            player2AliveCount--;
                        }
                        else if (phase == "P2 Turn")
                        {
                            player1AliveCount--;
                        }


                        if (player1AliveCount == 0 || player2AliveCount == 0)
                        {
                            endGame();
                        }
                    }
                    endCharacterAction();
                    break;
                case "move":
                    if (otherIndex != -1)
                    {
                        MessageBox.Show("已有棋子", "", MessageBoxButtons.OK);
                        break;
                    }
                    if (curPiece.outOfMoveRange(row, col))
                    {
                        MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                        break;
                    }
                    removePiece(curPiece.row, curPiece.col);
                    placePiece(row, col, curActionCharacterIndex, curActionCharacterIndex <= 2 ? playerColor1 : playerColor2);

                    endCharacterAction();
                    break;
                default:
                    break;
            }
        }

        private void handleClickBoard(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            int row = Convert.ToInt32(self.Name.Split('_')[1]);
            int col = Convert.ToInt32(self.Name.Split('_')[2]);

            // warrior is placed and no piece is chosen
            if (curPieceIndex == -1
                && ((phase == "prepare1" && pieceArr[0].isPlaced())
                || (phase == "prepare2" && pieceArr[3].isPlaced())))
            {
                return;
            }

            if (phase == "prepare1")
            {
                // warrior by default
                curChosenButton = curPieceIndex == -1 ? characterButton_1_0 : curChosenButton;
                curPieceIndex = curPieceIndex == -1 ? 0 : curPieceIndex;

                placePiece(row, col, curPieceIndex, playerColor1);
                board[row, col].Enabled = false;
                board[row, col].BackColor = playerColor1;
                board[row, col].Text = pieceArr[pieceIndex[row, col]].character;
                // all placed
                if (!characterButton_1_0.Enabled && !characterButton_1_1.Enabled && !characterButton_1_2.Enabled)
                {
                    endPrepare1();
                }
            }
            else if (phase == "prepare2")
            {
                // warrior by default
                curChosenButton = curPieceIndex == -1 ? characterButton_2_3 : curChosenButton;
                curPieceIndex = curPieceIndex == -1 ? 3 : curPieceIndex;

                placePiece(row, col, curPieceIndex, playerColor2);
                board[row, col].Enabled = false;
                board[row, col].BackColor = playerColor2;
                board[row, col].Text = pieceArr[pieceIndex[row, col]].character;
                // all placed
                if (!characterButton_2_3.Enabled && !characterButton_2_4.Enabled && !characterButton_2_5.Enabled)
                {
                    endPrepare2();
                }
            }
            else if (phase == "P1 Turn")
            {
                handleAction(row, col);
            }
            else if (phase == "P2 Turn")
            {
                handleAction(row, col);
            }
        }

        private void setEnableLeftBoard(bool val)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j < board.GetLength(1) / 2)
                    {
                        board[i, j].Enabled = val;
                    }
                }
            }
        }

        private void setEnableRightBoard(bool val)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j >= board.GetLength(1) / 2)
                    {
                        board[i, j].Enabled = val;
                    }
                }
            }

        }

        private void waitButton_Click(object sender, EventArgs e)
        {
            endCharacterAction();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLabel.Visible = true;
            phaseLabel.Visible = true;
            playerLabel1.Visible = true;
            playerLabel2.Visible = true;
            pieceLabel1.Visible = true;
            pieceLabel2.Visible = true;
            characterButton_1_2.Visible = true;
            characterButton_2_5.Visible = true;
            characterButton_1_1.Visible = true;
            characterButton_2_4.Visible = true;
            characterButton_1_0.Visible = true;
            characterButton_2_3.Visible = true;
            prepareTimer.Enabled = true;

            startButton.Visible = false;

            // SECTION add board
            int buttonSize = 50;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Button button = new Button();
                    button.Name = $"button_{i}_{j}";
                    button.SetBounds(150 + buttonSize * (j % 7), 100 + (buttonSize * i), buttonSize, buttonSize);
                    button.Click += handleClickBoard;
                    board[i, j] = button;
                    Controls.Add(button);
                }
            }

            setEnableRightBoard(false);
        }

        private void prepareTimer_Tick(object sender, EventArgs e)
        {
            time--;
            timeLabel.Text = Convert.ToString(time);

            // when time's up, if there is piece not placed, place them automatically
            if (time == 0)
            {
                if (phase == "prepare1")
                {
                    int placeIndex = 0;
                    // place on 1st col
                    int colNum = 0;

                    for (int i = 0; i < rowNum; i++)
                    {
                        // loop until the piece isn't placed
                        while (placeIndex <= 2 && pieceArr[placeIndex].isPlaced())
                        {
                            placeIndex++;
                        }

                        if (placeIndex > 2)
                        {
                            break;
                        }

                        switch (placeIndex)
                        {
                            case 0:
                                curChosenButton = characterButton_1_0;
                                break;
                            case 1:
                                curChosenButton = characterButton_1_1;
                                break;
                            case 2:
                                curChosenButton = characterButton_1_2;
                                break;
                            default:
                                curChosenButton = null;
                                break;
                        }

                        if (pieceIndex[i, colNum] == -1)
                        {
                            placePiece(i, colNum, placeIndex, playerColor1);
                            placeIndex++;
                        }
                    }
                    endPrepare1();
                }
                else if (phase == "prepare2")
                {
                    int placeIndex = 3;
                    // place on 6th col
                    int colNum = 5;

                    for (int i = 0; i < rowNum; i++)
                    {
                        // loop until the piece isn't placed
                        while (placeIndex <= 5 && pieceArr[placeIndex].isPlaced())
                        {
                            placeIndex++;
                        }

                        if (placeIndex > 5)
                        {
                            break;
                        }

                        switch (placeIndex)
                        {
                            case 3:
                                curChosenButton = characterButton_2_3;
                                break;
                            case 4:
                                curChosenButton = characterButton_2_4;
                                break;
                            case 5:
                                curChosenButton = characterButton_2_5;
                                break;
                            default:
                                curChosenButton = null;
                                break;
                        }

                        if (pieceIndex[i, colNum] == -1)
                        {
                            placePiece(i, colNum, placeIndex, playerColor2);
                            placeIndex++;
                        }
                    }
                    endPrepare2();
                }
            }
        }

        private void handleCharacterButtonClick(object sender, EventArgs e)
        {
            Button self = (Button)sender;

            // player 1 or 2
            string team = self.Name.Split('_')[1];
            curPieceIndex = Convert.ToInt32(self.Name.Split('_')[2]);
            curChosenButton = self;

            if (team == "1")
            {
                pieceLabel1.Text = pieceArr[curPieceIndex].character;
            }
            else if (team == "2")
            {
                pieceLabel2.Text = pieceArr[curPieceIndex].character;
            }
        }

        private void updateCharacterLabel(Piece piece, Label pieceLabel, Label stateLabel)
        {
            pieceLabel.Text = piece.character;
            stateLabel.Text = piece.getStateStr();
        }

        private void handleClickActionButton(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            string action = self.Name.Split('_')[0];

            curAction = action;
            if (curAction == "wait")
            {
                endCharacterAction();
            }
            else if (curAction == "end")
            {
                if (phase == "P1 Turn")
                {
                    end_button1.Enabled = false;

                    attack_button2.Enabled = true;
                    move_button2.Enabled = true;
                    skill_button2.Enabled = true;
                    wait_button2.Enabled = true;

                    phase = "P2 Turn";
                    phaseLabel.Text = phase;
                }
                else if (phase == "P2 Turn")
                {
                    end_button2.Enabled = false;

                    attack_button1.Enabled = true;
                    move_button1.Enabled = true;
                    skill_button1.Enabled = true;
                    wait_button1.Enabled = true;

                    phase = "P1 Turn";
                    phaseLabel.Text = phase;
                }
            }
        }

        // handle when a warrior/mage/ranger finish action
        private void endCharacterAction()
        {
            // end of turn
            if (curActionCharacterIndex == 2)
            {
                attack_button1.Enabled = false;
                skill_button1.Enabled = false;
                move_button1.Enabled = false;
                wait_button1.Enabled = false;
                end_button1.Enabled = true;
            }
            else if (curActionCharacterIndex == 5)
            {

                attack_button2.Enabled = false;
                skill_button2.Enabled = false;
                move_button2.Enabled = false;
                wait_button2.Enabled = false;
                end_button2.Enabled = true;
            }

            curActionCharacterIndex = curActionCharacterIndex == 5 ? 0 : curActionCharacterIndex + 1;
            if (pieceArr[curActionCharacterIndex].isDead())
            {
                // skip dead characters
                endCharacterAction();
            }
            else if (curActionCharacterIndex <= 2)
            {
                // update label
                updateCharacterLabel(pieceArr[curActionCharacterIndex], pieceLabel1, pieceStateLabel1);
            }
            else
            {
                updateCharacterLabel(pieceArr[curActionCharacterIndex], pieceLabel2, pieceStateLabel2);
            }

            curAction = "";
        }
    }
}
