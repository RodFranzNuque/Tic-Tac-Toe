namespace TicTacToe_Rod
{
    public partial class TicTacToe : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            row1column1.Enabled = false;
            row1column2.Enabled = false;
            row1column3.Enabled = false;
            row2column1.Enabled = false;
            row2column2.Enabled = false;
            row2column3.Enabled = false;
            row3column1.Enabled = false;
            row3column2.Enabled = false;
            row3column3.Enabled = false;
        }

        void score()
        {
            if (row1column1.Text == "X" && row1column2.Text == "X" && row1column3.Text == "X")
            {
                MessageBox.Show("Player X wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row2column1.Text == "X" && row2column2.Text == "X" && row2column3.Text == "X")
            {
                MessageBox.Show("Player X wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row3column1.Text == "X" && row3column2.Text == "X" && row3column3.Text == "X")
            {
                MessageBox.Show("Player X wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column1.Text == "X" && row2column1.Text == "X" && row3column1.Text == "X")
            {
                MessageBox.Show("Player X wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column2.Text == "X" && row2column2.Text == "X" && row3column2.Text == "X")
            {
                MessageBox.Show("Player X wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column3.Text == "X" && row2column3.Text == "X" && row3column3.Text == "X")
            {
                MessageBox.Show("Player X wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column1.Text == "X" && row2column2.Text == "X" && row3column3.Text == "X")
            {
                MessageBox.Show("Player X wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column3.Text == "X" && row2column2.Text == "X" && row3column1.Text == "X")
            {
                MessageBox.Show("Player X wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //========================================================================================================
            if (row1column1.Text == "O" && row1column2.Text == "O" && row1column3.Text == "O")
            {
                MessageBox.Show("Player O wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row2column1.Text == "O" && row2column2.Text == "O" && row2column3.Text == "O")
            {
                MessageBox.Show("Player O wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row3column1.Text == "O" && row3column2.Text == "O" && row3column3.Text == "O")
            {
                MessageBox.Show("Player O wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column1.Text == "O" && row2column1.Text == "O" && row3column1.Text == "O")
            {
                MessageBox.Show("Player O wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column2.Text == "O" && row2column2.Text == "O" && row3column2.Text == "O")
            {
                MessageBox.Show("Player O wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column3.Text == "O" && row2column3.Text == "O" && row3column3.Text == "O")
            {
                MessageBox.Show("Player O wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column1.Text == "O" && row2column2.Text == "O" && row3column3.Text == "O")
            {
                MessageBox.Show("Player O wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (row1column3.Text == "O" && row2column2.Text == "O" && row3column1.Text == "O")
            {
                MessageBox.Show("Player O wins", "Tic-tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                row1column1.Enabled = true;
                row1column2.Enabled = true;
                row1column3.Enabled = true;
                row2column1.Enabled = true;
                row2column2.Enabled = true;
                row2column3.Enabled = true;
                row3column1.Enabled = true;
                row3column2.Enabled = true;
                row3column3.Enabled = true;

                row1column1.Text = "";
                row1column2.Text = "";
                row1column3.Text = "";
                row2column1.Text = "";
                row2column2.Text = "";
                row2column3.Text = "";
                row3column1.Text = "";
                row3column2.Text = "";
                row3column3.Text = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PlayerO_Click(object sender, EventArgs e)
        {

        }

        private void PlayerXscore_Click(object sender, EventArgs e)
        {

        }

        private void row1column1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row1column1.Text = "X";
                checker = true;
            }
            else
            {
                row1column1.Text = "O";
                checker = false;
            }
            score();
            row1column1.Enabled = false;
        }

        private void row1column2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row1column2.Text = "X";
                checker = true;
            }
            else
            {
                row1column2.Text = "O";
                checker = false;
            }
            score();
            row1column2.Enabled = false;
        }

        private void row1column3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row1column3.Text = "X";
                checker = true;
            }
            else
            {
                row1column3.Text = "O";
                checker = false;
            }
            score();
            row1column3.Enabled = false;
        }

        private void row2column1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row2column1.Text = "X";
                checker = true;
            }
            else
            {
                row2column1.Text = "O";
                checker = false;
            }
            score();
            row2column1.Enabled = false;
        }

        private void row2column2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row2column2.Text = "X";
                checker = true;
            }
            else
            {
                row2column2.Text = "O";
                checker = false;
            }
            score();
            row2column2.Enabled = false;
        }

        private void row2column3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row2column3.Text = "X";
                checker = true;
            }
            else
            {
                row2column3.Text = "O";
                checker = false;
            }
            score();
            row2column3.Enabled = false;
        }

        private void row3column1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row3column1.Text = "X";
                checker = true;
            }
            else
            {
                row3column1.Text = "O";
                checker = false;
            }
            score();
            row3column1.Enabled = false;
        }

        private void row3column2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row3column2.Text = "X";
                checker = true;
            }
            else
            {
                row3column2.Text = "O";
                checker = false;
            }
            score();
            row3column2.Enabled = false;
        }

        private void row3column3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                row3column3.Text = "X";
                checker = true;
            }
            else
            {
                row3column3.Text = "O";
                checker = false;
            }
            score();
            row3column3.Enabled = false;
        }

        private void AnotherRound_Click(object sender, EventArgs e)
        {
            try {
                row1column1.Enabled = true;
                row1column2.Enabled = true;
                row1column3.Enabled = true;
                row2column1.Enabled = true;
                row2column2.Enabled = true;
                row2column3.Enabled = true;
                row3column1.Enabled = true;
                row3column2.Enabled = true;
                row3column3.Enabled = true;

                row1column1.Text = "";
                row1column2.Text = "";
                row1column3.Text = "";
                row2column1.Text = "";
                row2column2.Text = "";
                row2column3.Text = "";
                row3column1.Text = "";
                row3column2.Text = "";
                row3column3.Text = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    } }