using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ConnectFour
{
    public partial class Form1 : Form
    {
        private List<int> col1List = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> col2List = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> col3List = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> col4List = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> col5List = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> col6List = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> col7List = new List<int> { 0, 0, 0, 0, 0, 0 };

        private List<List<int>> allList;
        private List<List<Button>> allButtons;

        private List<Button> buttonsCol1;
        private List<Button> buttonsCol2;
        private List<Button> buttonsCol3;
        private List<Button> buttonsCol4;
        private List<Button> buttonsCol5;
        private List<Button> buttonsCol6;
        private List<Button> buttonsCol7;

        private int player;
        private Color playerColor;

        private int button;
        public int buttNum;

        public Form1()
        {
            InitializeComponent();
            buttonsCol1 = new List<Button> { button1, button2, button3, button4, button5, button6 };
            buttonsCol2 = new List<Button> { button12, button11, button10, button9, button8, button7 };
            buttonsCol3 = new List<Button> { button18, button17, button16, button15, button14, button13 };
            buttonsCol4 = new List<Button> { button24, button23, button22, button21, button20, button19 };
            buttonsCol5 = new List<Button> { button30, button29, button28, button27, button26, button25 };
            buttonsCol6 = new List<Button> { button36, button35, button34, button33, button32, button31 };
            buttonsCol7 = new List<Button> { button42, button41, button40, button39, button38, button37 };

            allButtons = new List<List<Button>> { buttonsCol1, buttonsCol2, buttonsCol3, buttonsCol4, buttonsCol5, buttonsCol6, buttonsCol7 };
            allList = new List<List<int>> { col1List, col2List, col3List, col4List, col5List, col6List, col7List };
        }

        public void startButton_Click(object sender, EventArgs e)
        {
            col1.Enabled = true;
            col2.Enabled = true;
            col3.Enabled = true;
            col4.Enabled = true;
            col5.Enabled = true;
            col6.Enabled = true;
            col7.Enabled = true;

            player = 1;
            playerLabel.Text = "Player 1";
            playerColor = Color.Red;

        }

        private void col1_Click(object sender, EventArgs e)
        {
            button = ColumnFiller(buttonsCol1, col1List, playerColor, 1);
            playerSwap();
        }

        private void col2_Click(object sender, EventArgs e)
        {
            button = ColumnFiller(buttonsCol2, col2List, playerColor, 2);
            playerSwap();
        }

        private void col3_Click(object sender, EventArgs e)
        {
            button = ColumnFiller(buttonsCol3, col3List, playerColor, 3);
            playerSwap();
        }

        private void col4_Click(object sender, EventArgs e)
        {
            button = ColumnFiller(buttonsCol4, col4List, playerColor, 4);
            playerSwap();
        }

        private void col5_Click(object sender, EventArgs e)
        {
            button = ColumnFiller(buttonsCol5, col5List, playerColor, 5);
            playerSwap();
        }

        private void col6_Click(object sender, EventArgs e)
        {   
            button = ColumnFiller(buttonsCol6, col6List, playerColor, 6);
            playerSwap();
        }

        private void col7_Click(object sender, EventArgs e)
        {
            button = ColumnFiller(buttonsCol7, col7List, playerColor, 7);
            playerSwap();
        }

        public int ColumnFiller(List<Button> buttons, List<int> colList, Color fillColor, int colNum)
        {
            for (int i = 5; i > -1; i--)
            {
                if (colList[i] == 0)
                {
                    buttons[i].BackColor = fillColor;
                    colList[i] = 1;
                    break;

                    
                }

                int buttNum = (colNum * 7) + i;
                

            }

            return buttNum;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allList.Count; i++)
            {
                for (int j = 0; j < allList[i].Count; j++)
                {
                    allList[i][j] = 0;
                    allButtons[i][j].BackColor = Color.Transparent;
                }
            }

            player = 1;
            playerLabel.Text = "Player 1";
            playerColor = Color.Red;

        }

        private void playerSwap()
        {
            if (player == 1)
            {
                player = 2;
                playerLabel.Text = "Player 2";
                playerColor = Color.Yellow;
            }
            else
            {
                player = 1;
                playerLabel.Text = "Player 1";
                playerColor = Color.Red;
            }


        }

        private void winCheck(int button)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; i++)
                {
                    
                }
            }
        }
    }
}