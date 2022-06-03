using System.Media;
namespace Tic_tac_toe

{
    public partial class Form1 : Form
    {
        SoundPlayer Soundeffect = new SoundPlayer (@"C:\Users\HP\OneDrive\Desktop\C# Programs\2nd Program\Tic-tac-toe\Resources\Mouse Click Sound Effect.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Tic-Tac-Toe program made by M.Sevilla." +
                "This is played by X and O symbols.");

            Soundeffect.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In order for the player to win, it is a must to succeed in markering three cells in a straight line at any direction (by horizonally, vertically, and diagobally)." +
                " Have fun playing!");

            Soundeffect.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible=false;

            Soundeffect.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}