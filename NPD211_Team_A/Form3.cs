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
    public partial class Form3 : Form
    {
        Form1 form1;

        public Form3(Form1 form1)
        {
            InitializeComponent();

            if (form1.Categories.Count == 0)
            {
                form1.Categories.AddRange(new string[] { "Salary", "Food", "Transport" });
            }

            this.form1 = form1;
            UpdateCategoryCB();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void UpdateCategoryCB()
        {
            CategoryCB.DataSource = null;
            CategoryCB.DataSource = form1.Categories;
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AddCategoryTB.Text))
            {
                form1.Categories.Add(AddCategoryTB.Text);
                UpdateCategoryCB();
                MessageBox.Show("Succesfully added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Category can not be empty", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void AddBtn_Click(object sender, EventArgs e)
        {

            if (CategoryCB.SelectedIndex != -1 && !string.IsNullOrEmpty(DateDTP.Text) && !string.IsNullOrEmpty(SumTB.Text) && int.TryParse(SumTB.Text, out int sum))
            {
                form1.AddToList(new Form1.MoneyEntry(CategoryCB.Text, DateDTP.Value, sum));
                MessageBox.Show("Succesfully added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect data", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
