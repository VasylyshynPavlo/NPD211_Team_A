namespace NPD211_Team_A
{
    public partial class Form1 : Form
    {
        private List<MoneyEntry> moneyEntryList = new List<MoneyEntry>();

        public class MoneyEntry
        {
            public string CategoryEntry { get; set; }
            public DateTime DateEntry { get; set; }
            public int SumEntry { get; set; }

            public MoneyEntry(string categoryEntry, DateTime dateEntry, int sumEntry) 
            {
                CategoryEntry = categoryEntry;
                DateEntry = dateEntry;
                SumEntry = sumEntry;
            }
        }

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
            Form4 form = new Form4();
            form.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//hotkeys
        {
            //file

            //edit
            if (e.KeyCode == Keys.A && !e.Alt && e.Control) //Add
            {
                Add();
            }
            //view
            if (e.KeyCode == Keys.F1 && !e.Alt && !e.Control) // day
            {
                //code
                form1_Open();
            }
            if (e.KeyCode == Keys.F2 && !e.Alt && !e.Control) //month
            {
                //code
                form1_Open();
            }
            if (e.KeyCode == Keys.F3 && !e.Alt && !e.Control) //year
            {
                //code
                form1_Open();
            }
            if (e.KeyCode == Keys.F4 && !e.Alt && !e.Control) //custom
            {
                //code
                Form4 form = new Form4();
                form.Show();
            }
        }


        private void form1_Open() //when we add list, change to form1_Open(List<T> list) AND delete this message
        {
            Form2 form = new Form2();
            form.Show();
        }
        private void Add()//For add to list
        {
            Form3 form = new Form3();
            form.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                //code
            }
            if (DialogResult == DialogResult.Cancel)
            {
                //code
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}