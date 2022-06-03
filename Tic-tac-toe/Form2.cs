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
    }
}
