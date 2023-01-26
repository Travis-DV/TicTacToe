using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[,] board = { { -1, -1, -1 }, { -1, -1, -1 }, { -1, -1, -1 } };
        // player = 0 "ai" = 1
        private int currentteam = 0;
        private bool playingwai = false;

        private void ticclicked(int[] location)
        {
            //MessageBox.Show("tic change");
            if (board[location[0], location[1]] == -1)
            {
                //MessageBox.Show("if board == ");
                board[location[0], location[1]] = currentteam;
                currentteam = teamchanger();
                picchange(location);
                winchecker();
            }
            if (currentteam == 1 && playingwai)
            {
                while (true)
                {
                    int[] i = randmaker();
                    if (board[i[0], i[1]] == -1)
                    {
                        board[i[0], i[1]] = 1;
                        picchange(i);
                        winchecker();
                        break;
                    }
                }
                currentteam = teamchanger();
            }
        }

        private void picchange(int[] location)
        {
            //MessageBox.Show("In pic change");
            PictureBox[,] pics = { { tlPIC, tcPIC, trPIC }, { mlPIC, mcPIC, mrPIC }, { blPIC, bcPIC, brPIC } };
            if (board[location[0], location[1]] == 0)
            {
                pics[location[0], location[1]].Image = Properties.Resources.opic;
                //MessageBox.Show("In pic change O");
            }
            else if (board[location[0], location[1]] == 1)
            {
                pics[location[0], location[1]].Image = Properties.Resources.xpic;
                //MessageBox.Show("In pic change X");
            }
            else if (board[location[0], location[1]] == -1)
            {
                pics[location[0], location[1]].Image = Properties.Resources.dpic;
            }
            pics[location[0], location[1]].Refresh();
        }

        private int teamchanger()
        {
            if (currentteam == 0) return 1;
            else if (currentteam == 1) return 0;
            return -1;
        }

        private void winchecker()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != -1)
                {
                    string[] teamnames = { "O", "X" };
                    MessageBox.Show($"The winner was {teamnames[board[i, 0]]}");
                    newgame();
                }
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != -1)
                {
                    string[] teamnames = { "O", "X" };
                    MessageBox.Show($"The winner was {teamnames[board[0, i]]}");
                    newgame();
                }
                bool[] diagcheck = diagnalcheck();
                if (diagcheck[0])
                {
                    string teamw = "error";
                    if (!diagcheck[1])
                    {
                        teamw = "O";
                    }
                    else if (diagcheck[1])
                    {
                        teamw = "X";
                    }
                    MessageBox.Show($"The winner was {teamw}");
                    newgame();
                }
            }
        }

        private bool[] diagnalcheck()
        {
            //team 0 = false team 1 = true
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != -1)
            {
                if (board[0, 0] == 0)
                {
                    bool[] diagcheck = { true, false };
                    return diagcheck;
                }
                else if (board[0, 0] == 1)
                {
                    bool[] diagcheck = { true, true };
                    return diagcheck;
                }

            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != -1)
            {
                if (board[0, 2] == 0)
                {
                    bool[] diagcheck = { true, false };
                    return diagcheck;
                }
                else if (board[0, 2] == 1)
                {
                    bool[] diagcheck = { true, true };
                    return diagcheck;
                }
            }
            bool[] fail = { false, false };
            return fail;
        }

        private void newgame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int[] location = { i, j };
                    board[i, j] = -1;
                    picchange(location);
                }
            }
        }

        private int getsupperrand(int limit)
        {
            int[] temp = { 0, 0, 0 };
            Random rand = new Random();
            temp[0] = rand.Next();
            rand = new Random(temp[0]);
            temp[1] = rand.Next();
            rand = new Random(temp[1]);
            temp[2] = rand.Next();
            rand = new Random(temp[2]);
            return rand.Next(limit);
        }

        private int[] randmaker()
        {
            int[] temp = { 0, 0 };
            temp[0] = getsupperrand(3);
            temp[1] = getsupperrand(3);
            return temp;
        }

        private void tlPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 0, 0 };
            ticclicked(location);
        }

        private void tcPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 0, 1 };
            ticclicked(location);
        }

        private void trPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 0, 2 };
            ticclicked(location);
        }

        private void mlPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 1, 0 };
            ticclicked(location);
        }

        private void mcPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 1, 1 };
            ticclicked(location);
        }

        private void mrPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 1, 2 };
            ticclicked(location);
        }

        private void blPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 2, 0 };
            ticclicked(location);
        }

        private void bcPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 2, 1 };
            ticclicked(location);
        }

        private void brPIC_Click(object sender, EventArgs e)
        {
            int[] location = { 2, 2 };
            ticclicked(location);
        }

        private void newgameBUT_Click(object sender, EventArgs e)
        {
            newgame();
        }

        private void aiBUT_Click(object sender, EventArgs e)
        {
            if (playingwai == false)
            {
                playingwai = true;
                aiBUT.Text = "Play with hs?";
            }
            else if (playingwai == true)
            {
                playingwai = false;
                aiBUT.Text = "Play with ai?";
            }
        }
    }
}