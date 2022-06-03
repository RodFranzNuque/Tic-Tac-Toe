namespace TicTacToe_Rod
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Rules_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player X and O play in turns. The first player to have 3 marks on a row in any way (horizontal, Vertical, Diagonal) wins. " +
                "If all the squares are filled and there are no 3 marks in a row, the game ends in a draw");
        }
    }
}