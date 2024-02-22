using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NPD211_Team_A
{
    public partial class Form1 : Form
    {
        string nowOpenedFile = "";
        bool autosave = false;

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
            form2_Open();
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2_Open();
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2_Open();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//hotkeys
        {
            //file
            if (e.KeyCode == Keys.S && !e.Alt && e.Control && e.Shift) //Add
            {
                SaveAs();
            }
            if (e.KeyCode == Keys.S && !e.Alt && e.Control && !e.Shift) //Add
            {
                Save();
            }
            if (e.KeyCode == Keys.O && !e.Alt && e.Control && !e.Shift) //Add
            {
                Load();
            }
            //edit
            if (e.KeyCode == Keys.A && !e.Alt && e.Control && !e.Shift) //Add
            {
                Add();
            }
            //view
            if (e.KeyCode == Keys.F1 && !e.Alt && !e.Control && !e.Shift) // day
            {
                //code
                form2_Open();
            }
            if (e.KeyCode == Keys.F2 && !e.Alt && !e.Control && !e.Shift) //month
            {
                //code
                form2_Open();
            }
            if (e.KeyCode == Keys.F3 && !e.Alt && !e.Control && !e.Shift) //year
            {
                //code
                form2_Open();
            }
            if (e.KeyCode == Keys.F4 && !e.Alt && !e.Control && !e.Shift) //custom
            {
                //code
                Form4 form = new Form4();
                form.Show();
            }
        }
        private void form2_Open() //when we add list, change to form1_Open(List<T> list) AND delete this message
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
        private void Save()
        {
            if (nowOpenedFile != "")
            {
                if (moneyEntryList.Count != 0)
                {
                    string value = "BEGIN\n";
                    foreach (var item in moneyEntryList)
                    {
                        value += item.CategoryEntry + "\n";
                        value += item.DateEntry.ToShortDateString() + "\n";
                        value += item.SumEntry + "\n";
                    }
                    value += "END";
                    System.IO.File.WriteAllText(nowOpenedFile, value);
                }
            }
            else
            {
                MessageBox.Show($"No file is opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void SaveAs()
        {
            if (moneyEntryList.Count != 0)
            {
                SaveFileDialog dialog = new()
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    Filter = "Text Files|*.txt",
                    FilterIndex = 1,
                    FileName = "All " + DateTime.Now.Hour.ToString() + "h " + DateTime.Now.Minute.ToString() + "mi " + DateTime.Now.Day.ToString() + "d" + DateTime.Now.Month.ToString() + "m" + DateTime.Now.Year.ToString() + "y"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    if (dialog.FileName == "")
                    {
                        dialog.FileName = "All_" + DateTime.Now.ToShortTimeString() + "_" + DateTime.Now.ToShortDateString();
                    }
                    string value = "BEGIN\n";
                    foreach (var item in moneyEntryList)
                    {
                        value += item.CategoryEntry + "\n";
                        value += item.DateEntry.ToShortDateString() + "\n";
                        value += item.SumEntry + "\n";
                    }
                    value += "END";
                    System.IO.File.WriteAllText(dialog.FileName, value);
                    nowOpenedFile = dialog.FileName;
                    pathLable.Text = nowOpenedFile;
                }
            }
            else
            {
                MessageBox.Show($"The list is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Load()
        {
            OpenFileDialog dialog = new()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "Text Files|*.txt",
                FilterIndex = 1
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<MoneyEntry> entries = new List<MoneyEntry>();
                string value = "";
                value = System.IO.File.ReadAllText(dialog.FileName);
                string[] lines = value.Split("\n");
                int i = 1;
                if (lines[0] != "BEGIN")
                {
                    MessageBox.Show($"The file {dialog.FileName} is empty or corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    while (lines[i] != "END")
                    {
                        string CategoryEntry = lines[i];
                        i++;
                        DateTime DateEntry = DateTime.Parse(lines[i]);
                        i++;
                        int SumEntry = int.Parse(lines[i]);
                        i++;
                        entries.Add(new MoneyEntry(CategoryEntry, DateEntry, SumEntry));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The file {dialog.FileName} is corrupted\n\nDetails:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                moneyEntryList.Clear();
                moneyEntryList = entries;
                nowOpenedFile = dialog.FileName;
                pathLable.Text = nowOpenedFile;
            }
        }
        private void Autosave()
        {
            if (autosave)
            {
                if (moneyEntryList.Count != 0)
                {
                    if (nowOpenedFile == "")
                    {
                        return;
                    }
                    string value = "BEGIN\n";
                    foreach (var item in moneyEntryList)
                    {
                        value += item.CategoryEntry + "\n";
                        value += item.DateEntry.ToShortDateString() + "\n";
                        value += item.SumEntry + "\n";
                    }
                    value += "END";
                    System.IO.File.WriteAllText(nowOpenedFile, value);
                }
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
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void autosaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autosave = !autosave;
            if (autosave) { autosaveToolStripMenuItem.Checked = true; }
            else { autosaveToolStripMenuItem.Checked = false; }
        }
    }
}