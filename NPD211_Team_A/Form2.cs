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
    public partial class Form2 : Form
    {
        List<Form1.MoneyEntry> SelectedMoneyEntries = new List<Form1.MoneyEntry>();

        public Form2(List<Form1.MoneyEntry> selectedMoneyEntries)
        {
            InitializeComponent();
            listView_MonthYearAlltime.Items.Clear();

            SelectedMoneyEntries = selectedMoneyEntries;
            for (int i = 0; i < SelectedMoneyEntries.Count; i++)
            {
                string[] row = { SelectedMoneyEntries[i].CategoryEntry, SelectedMoneyEntries[i].DateEntry.ToString(), SelectedMoneyEntries[i].SumEntry.ToString() };
                listView_MonthYearAlltime.Items.Add(new ListViewItem(row));
            }
            label_IncomeSum.Text = CountIncome().ToString();
            label_SpendingSum.Text = CountSpending().ToString();
            label_General.Text = CountGeneral().ToString();
        }

        public void Save()
        {
            if (SelectedMoneyEntries.Count != 0)
            {
                SaveFileDialog dialog = new()
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    Filter = "Text Files|*.txt",
                    FilterIndex = 1,
                    FileName = "ViewByLastDayMonthYear " + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString()
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    if (dialog.FileName == "")
                    {
                        dialog.FileName = "ViewByLastDayMonthYear " + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();
                    }
                    string value = "BEGIN\n";
                    foreach (var it in SelectedMoneyEntries)
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

        private int CountIncome()
        {
            int income = 0;

            for (int i = 0; i < SelectedMoneyEntries.Count; i++)
            {
                if (SelectedMoneyEntries[i].SumEntry > 0)
                {
                    income += SelectedMoneyEntries[i].SumEntry;
                }
            }

            return income;
        }
        private int CountSpending()
        {
            int spending = 0;

            for (int i = 0; i < SelectedMoneyEntries.Count; i++)
            {
                if (SelectedMoneyEntries[i].SumEntry < 0)
                {
                    spending += SelectedMoneyEntries[i].SumEntry;
                }
            }

            return spending;
        }
        private int CountGeneral()
        {
            return CountIncome() + CountSpending();
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            int columnWidth = listView_MonthYearAlltime.Width / 3;
            for (int i = 0; i < listView_MonthYearAlltime.Columns.Count; i++)
            {
                listView_MonthYearAlltime.Columns[i].Width = columnWidth;
            }
        }
    }
}
