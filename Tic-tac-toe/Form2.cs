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
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
                    control.Click += new System.EventHandler(btnclick);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
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
                    Winnercheck();
                }
                else
                {
                    btn.Text = "O";
                    textBox1.Text = "Player X 's turn now";
                    Winnercheck();
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
                winlayout(btn1, btn2, btn3);
                win = true;
            }
            if (!btn4.Text.Equals("") && btn4.Text.Equals(btn5.Text) && btn4.Text.Equals(btn6.Text))
            {
                winlayout(btn4, btn5, btn6);
                win = true;
            }
            if (!btn7.Text.Equals("") && btn7.Text.Equals(btn8.Text) && btn7.Text.Equals(btn9.Text))
            {
                winlayout(btn7, btn8, btn9);
                win = true;
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
        // win layout function is added for easier view of the Player's winning line
        public void winlayout(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Thistle;
            b2.BackColor = Color.Thistle;
            b3.BackColor = Color.Thistle;

            b1.ForeColor = Color.DarkMagenta;
            b2.ForeColor = Color.DarkMagenta;
            b3.ForeColor = Color.DarkMagenta;

            textBox1.Text = b1.Text + " You Won! :>";
            MessageBox.Show(" You Won! Good job!");
        }

    }
}
