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

        public Form2()
        {
            InitializeComponent();
        }
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
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //file
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
    }
}
