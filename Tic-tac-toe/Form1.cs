namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Tic-Tac-Toe program made by M.Sevilla." +
                "This is played by X and O symbols.");
        }
    }
}