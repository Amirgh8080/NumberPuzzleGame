namespace NumberPuzzleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "";
            button5.Text = "4";
            button6.Text = "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button1.Text;
                button1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button2.Text;
                button2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button3.Text;
                button3.Text = "";
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
            CheckEndGame();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
            if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button4.Text;
                button4.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }

        }
        public void CheckEndGame()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4"
                && button5.Text == "5" && button6.Text == "")
            {
                MessageBox.Show("تبریک! شما برنده شدید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}