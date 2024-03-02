using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPD211_Team_A
{
    public partial class Form4 : Form
    {
        List<Form1.MoneyEntry> moneyEntryList;
        List<Form1.MoneyEntry> moneyEntryList_filtered;
        public Form4(List<Form1.MoneyEntry> moneyEntryList)
        {
            InitializeComponent();
            this.moneyEntryList = new List<Form1.MoneyEntry>(moneyEntryList);
            moneyEntryList_filtered = new List<Form1.MoneyEntry>(this.moneyEntryList);
            Reset();
        }
        public void Save()
        {
            if (moneyEntryList_filtered.Count != 0)
            {
                SaveFileDialog dialog = new()
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    Filter = "Text Files|*.txt",
                    FilterIndex = 1,
                    FileName = "Custom " + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString()
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    if (dialog.FileName == "")
                    {
                        dialog.FileName = "Custom " + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();
                    }
                    string value = "BEGIN\n";
                    foreach (var it in moneyEntryList_filtered)
                    {
                        Form1.MoneyEntry item = it;
                        value += item.CategoryEntry + "\n";
                        value += item.DateEntry.ToShortDateString() + "\n";
                        value += item.SumEntry + "\n";
                    }
                    value += "END";
                    System.IO.File.WriteAllText(dialog.FileName, value);
                }
            }
            else
            {
                MessageBox.Show($"The list is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (DaysAgoButton.Checked || MonthAgoButton.Checked || YearsAgoButton.Checked)
            {
                moneyEntryList_filtered.Clear();
                DateTime dateTime = DateTime.Now;
                if (DaysAgoButton.Checked) { dateTime = dateTime.AddDays(-(int)AgoNumericUpDown.Value); }
                if (MonthAgoButton.Checked) { dateTime = dateTime.AddMonths(-(int)AgoNumericUpDown.Value); }
                if (YearsAgoButton.Checked) { dateTime = dateTime.AddYears(-(int)AgoNumericUpDown.Value); }
                foreach (var it in moneyEntryList)
                {
                    Form1.MoneyEntry item = it;
                    if (it.DateEntry >= dateTime)
                    {
                        moneyEntryList_filtered.Add(item);
                    }
                }
            }
            if (FromToButton.Checked)
            {
                moneyEntryList_filtered.Clear();
                DateTime from = FromDateTimePicker.Value;
                DateTime to = ToDateTimePicker.Value;
                foreach (var it in moneyEntryList)
                {
                    Form1.MoneyEntry item = it;
                    if (it.DateEntry >= from && it.DateEntry <= to)
                    {
                        moneyEntryList_filtered.Add(item);
                    }
                }
            }
            ListUpdate();
        }

        private void ListUpdate()
        {
            ItemsListView.Items.Clear();
            foreach (var it in moneyEntryList_filtered)
            {
                Form1.MoneyEntry item = it;
                string[] row = { item.CategoryEntry, item.DateEntry.ToShortDateString(), item.SumEntry.ToString() };
                ItemsListView.Items.Add(new ListViewItem(row));
            }
            checkSum();
        }

        private void Reset()
        {
            DaysAgoButton.Checked = false;
            MonthAgoButton.Checked = false;
            YearsAgoButton.Checked = false;
            FromToButton.Checked = false;
            AgoGroupBox.Enabled = false;
            FromToGroupBox.Enabled = false;
            AgoNumericUpDown.Value = 0;
            FromDateTimePicker.Value = DateTime.Now;
            ToDateTimePicker.Value = DateTime.Now;
            moneyEntryList_filtered = new List<Form1.MoneyEntry>(this.moneyEntryList);
            ListUpdate();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DaysAgoButton_CheckedChanged(object sender, EventArgs e)
        {
            AgoGroupBox.Enabled = true;
            FromToGroupBox.Enabled = false;
        }

        private void MonthAgoButton_CheckedChanged(object sender, EventArgs e)
        {
            AgoGroupBox.Enabled = true;
            FromToGroupBox.Enabled = false;
        }

        private void YearsAgoButton_CheckedChanged(object sender, EventArgs e)
        {
            AgoGroupBox.Enabled = true;
            FromToGroupBox.Enabled = false;
        }

        private void FromToButton_CheckedChanged(object sender, EventArgs e)
        {
            AgoGroupBox.Enabled = false;
            FromToGroupBox.Enabled = true;
        }
        private void checkSum()
        {
            int incom = 0;
            int spend = 0;
            int general = 0;
            foreach (var it in moneyEntryList_filtered)
            {
                Form1.MoneyEntry item = it;
                if (item.SumEntry > 0) { incom += item.SumEntry; }
                if (item.SumEntry < 0) { spend += item.SumEntry; }
                general += item.SumEntry;
            }
            label_IncomeSum.Text = incom.ToString();
            label_SpendingSum.Text = spend.ToString();
            label_InGenenalSum.Text = general.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
