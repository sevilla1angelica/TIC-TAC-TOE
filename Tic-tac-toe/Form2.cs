using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // click event is raised when the button control is clicked
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.Click += new System.EventHandler(btnclick);
                }
            }
        }

        // add functionality to the 1-9 buttons
        int XorO = 0;
        public void btnclick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                if (XorO % 2 == 0)
                {
                    btn.Text = "X";
                    textBox1.Text = "Player O 's  turn now";
                }
                else
                {
                    btn.Text = "O";
                    textBox1.Text = "Player X 's turn now";
                }

                XorO++;
            }
        }
        bool win = false;
        public void Winnercheck()
        {
            //horizontal winning check
            if (!btn1.Text.Equals("") && btn1.Text.Equals(btn2.Text) && btn1.Text.Equals(btn3.Text))
            {
                win = true;
            }
            if (!btn4.Text.Equals("") && btn4.Text.Equals(btn5.Text) && btn4.Text.Equals(btn6.Text))
            {
                win = true;
            }
            if (!btn7.Text.Equals("") && btn7.Text.Equals(btn8.Text) && btn7.Text.Equals(btn9.Text))
            {
                win = true;
            }

            //vertical winning check
            if (!btn1.Text.Equals("") && btn1.Text.Equals(btn4.Text) && btn1.Text.Equals(btn7.Text))
            {
                win = true;
            }
            if (!btn2.Text.Equals("") && btn2.Text.Equals(btn5.Text) && btn2.Text.Equals(btn8.Text))
            {
                win = true;
            }
            if (!btn3.Text.Equals("") && btn3.Text.Equals(btn6.Text) && btn3.Text.Equals(btn9.Text))
            {
                win = true;
            }

            //diagonal winning check
            if (!btn1.Text.Equals("") && btn1.Text.Equals(btn5.Text) && btn1.Text.Equals(btn9.Text))
            {
                win = true;
            }
            if (!btn3.Text.Equals("") && btn3.Text.Equals(btn5.Text) && btn3.Text.Equals(btn7.Text))
            {
                win = true;
            }
            //button text length function would tell the winning check as a draw.
            if (AllBtnLength() == 9 && win == false)
            {
                textBox1.Text = " No one won :< ";
                MessageBox.Show(" Aww, it's a draw >,< ");
            }

        }
        // get all button text length function -> return int
        public int AllBtnLength()
        {
            int allTextButtonsLength = 0;
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    allTextButtonsLength += c.Text.Length;
                }
            }
            return allTextButtonsLength;
        }

    }
}
