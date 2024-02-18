namespace NPD211_Team_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void dayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form1_Open();
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1_Open();
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1_Open();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1_Open();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//hotkeys
        {
            //file

            //edit

            //view
            if (e.KeyCode == Keys.F1 && !e.Alt)
            {
                //code
                form1_Open();
            }
            if (e.KeyCode == Keys.F2 && !e.Alt)
            {
                //code
                form1_Open();
            }
            if (e.KeyCode == Keys.F3 && !e.Alt)
            {
                //code
                form1_Open();
            }
            if (e.KeyCode == Keys.F4 && !e.Alt)
            {
                //code
                Form4 form4 = new Form4();
                form4.Show();
            }
        }
        private void form1_Open() //when we add list, change to form1_Open(List<T> list) AND delete this message
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}