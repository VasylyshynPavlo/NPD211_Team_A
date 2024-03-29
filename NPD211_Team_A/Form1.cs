using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NPD211_Team_A
{
    public partial class Form1 : Form
    {
        string nowOpenedFile = "";
        bool autosave = false;

        private List<MoneyEntry> moneyEntryList = new List<MoneyEntry>();
        public List<string> Categories { get; set; } = new List<string>();

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
            ViewLastDay();
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLastMonth();
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLastYear();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(moneyEntryList);
            form.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//hotkeys
        {
            //file
            if (e.KeyCode == Keys.S && !e.Alt && e.Control && e.Shift)
            {
                SaveAs();
            }
            if (e.KeyCode == Keys.S && !e.Alt && e.Control && !e.Shift)
            {
                Save();
            }
            if (e.KeyCode == Keys.O && !e.Alt && e.Control && !e.Shift)
            {
                Load();
            }
            //edit
            if (e.KeyCode == Keys.A && !e.Alt && e.Control && !e.Shift) //Add
            {
                Add();
            }
            if (e.KeyCode == Keys.Delete && !e.Alt && !e.Control && !e.Shift) //Delete
            {
                Delete();
            }
            //view
            if (e.KeyCode == Keys.Enter && !e.Alt && !e.Control && !e.Shift) //View selected
            {
                ShowMessegeBoxItem();
            }
            if (e.KeyCode == Keys.F1 && !e.Alt && !e.Control && !e.Shift) // day
            {
                ViewLastDay();
            }
            if (e.KeyCode == Keys.F2 && !e.Alt && !e.Control && !e.Shift) //month
            {
                ViewLastMonth();
            }
            if (e.KeyCode == Keys.F3 && !e.Alt && !e.Control && !e.Shift) //year
            {
                ViewLastYear();
            }
            if (e.KeyCode == Keys.F4 && !e.Alt && !e.Control && !e.Shift) //custom
            {
                //code
                Form4 form = new Form4(moneyEntryList);
                form.ShowDialog();
            }
        }

        private void ShowMessegeBoxItem()
        {
            int selectedIndex = ItemsListView.SelectedIndices.Count > 0 ? ItemsListView.SelectedIndices[0] : -1;

            if (selectedIndex >= 0 && selectedIndex < moneyEntryList.Count)
            {
                MoneyEntry selectedMoneyEntry = moneyEntryList[selectedIndex];

                string message = $"Category: {selectedMoneyEntry.CategoryEntry}\n" +
                                 $"Date: {selectedMoneyEntry.DateEntry}\n" +
                                 $"Sum: {selectedMoneyEntry.SumEntry}";

                MessageBox.Show(message, "Selected Item Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select a money entry from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountBalance()
        {
            int balance = 0;

            foreach (MoneyEntry i in moneyEntryList)
            {
                balance += i.SumEntry;
            }

            BalanceSumLbl.Text = balance.ToString();
        }
        public void AddToList(MoneyEntry moneyEntry)
        {
            moneyEntryList.Add(moneyEntry);
            string[] row = { moneyEntry.CategoryEntry, moneyEntry.DateEntry.ToString(), moneyEntry.SumEntry.ToString() };
            ItemsListView.Items.Add(new ListViewItem(row));
            Autosave();
        }
        private void Add()//For add to list
        {
            Form3 form = new Form3(this);
            form.ShowDialog();
            CountBalance();
        }
        private void Delete()
        {
            if (ItemsListView.SelectedItems.Count != 0)
            {
                for (int i = ItemsListView.Items.Count - 1; i >= 0; i--)
                {
                    if (ItemsListView.Items[i].Selected)
                    {
                        ItemsListView.Items[i].Remove();
                        moneyEntryList.RemoveAt(i);
                    }
                }
                MessageBox.Show("Succesfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CountBalance();
                Autosave();
            }
        }
        private void ViewSelectedItems()
        {
            if (ItemsListView.SelectedItems.Count != 0)
            {
                List<MoneyEntry> list = new List<MoneyEntry>();
                for (int i = 0; i < ItemsListView.Items.Count; i++)
                {
                    if (ItemsListView.Items[i].Selected)
                    {
                        list.Add(moneyEntryList[i]);
                    }
                }
                Form2 form = new Form2(list);
                form.ShowDialog();
            }
        }
        private void ViewLastDay()
        {
            if (ItemsListView.Items.Count != 0)
            {
                List<MoneyEntry> list = new List<MoneyEntry>();
                for (int i = 0; i < ItemsListView.Items.Count; i++)
                {
                    if (moneyEntryList[i].DateEntry.Day == DateTime.UtcNow.Day && moneyEntryList[i].DateEntry.Month == DateTime.UtcNow.Month && moneyEntryList[i].DateEntry.Year == DateTime.UtcNow.Year)
                    {
                        list.Add(moneyEntryList[i]);
                    }
                }
                Form2 form = new Form2(list);
                form.ShowDialog();
            }
        }
        private void ViewLastMonth()
        {
            if (ItemsListView.Items.Count != 0)
            {
                List<MoneyEntry> list = new List<MoneyEntry>();
                for (int i = 0; i < ItemsListView.Items.Count; i++)
                {
                    if (((DateTime.UtcNow.Year * 365 + DateTime.UtcNow.Month * 31 + DateTime.UtcNow.Day) -
                        (moneyEntryList[i].DateEntry.Year * 365 + moneyEntryList[i].DateEntry.Month * 31 + moneyEntryList[i].DateEntry.Day)) <= 31)
                    {
                        list.Add(moneyEntryList[i]);
                    }
                }
                Form2 form = new Form2(list);
                form.ShowDialog();
            }
        }
        private void ViewLastYear()
        {
            if (ItemsListView.Items.Count != 0)
            {
                List<MoneyEntry> list = new List<MoneyEntry>();
                for (int i = 0; i < ItemsListView.Items.Count; i++)
                {
                    if (((DateTime.UtcNow.Year * 365 + DateTime.UtcNow.Month * 31 + DateTime.UtcNow.Day) -
                        (moneyEntryList[i].DateEntry.Year * 365 + moneyEntryList[i].DateEntry.Month * 31 + moneyEntryList[i].DateEntry.Day)) <= 365)
                    {
                        list.Add(moneyEntryList[i]);
                    }
                }
                Form2 form = new Form2(list);
                form.ShowDialog();
            }
        }
        private void InitializeCategoryList()
        {
            foreach (MoneyEntry i in moneyEntryList)
            {
                if (!Categories.Contains(i.CategoryEntry))
                {
                    Categories.Add(i.CategoryEntry);
                }
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
                        value += item.DateEntry.ToString() + "\n";
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
                    FileName = "All " + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString()
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    if (dialog.FileName == "")
                    {
                        dialog.FileName = "All " + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();
                    }
                    string value = "BEGIN\n";
                    foreach (var item in moneyEntryList)
                    {
                        value += item.CategoryEntry + "\n";
                        value += item.DateEntry.ToString() + "\n";
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
                ItemsListView.Items.Clear();
                moneyEntryList = entries;
                InitializeCategoryList();
                foreach (MoneyEntry moneyEntry in moneyEntryList)
                {
                    string[] row = { moneyEntry.CategoryEntry, moneyEntry.DateEntry.ToString(), moneyEntry.SumEntry.ToString() };
                    ItemsListView.Items.Add(new ListViewItem(row));
                }
                CountBalance();
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
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMessegeBoxItem();
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

        private void ItemsListView_Resize(object sender, EventArgs e)
        {
            int columnWidth = ItemsListView.Width / 3;
            for (int i = 0; i < ItemsListView.Columns.Count; i++)
            {
                ItemsListView.Columns[i].Width = columnWidth;
            }
        }
    }
}