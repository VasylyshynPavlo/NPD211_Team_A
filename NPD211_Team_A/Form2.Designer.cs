namespace NPD211_Team_A
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Income = new Label();
            label_Spending = new Label();
            label_IncomeSum = new Label();
            label_SpendingSum = new Label();
            label_General = new Label();
            label_Ingeneral = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            listView_MonthYearAlltime = new ListView();
            Category = new ColumnHeader();
            Date = new ColumnHeader();
            Money = new ColumnHeader();
            button_Close = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Income
            // 
            label_Income.AutoSize = true;
            label_Income.Location = new Point(9, 2);
            label_Income.Margin = new Padding(2, 0, 2, 0);
            label_Income.Name = "label_Income";
            label_Income.Size = new Size(50, 15);
            label_Income.TabIndex = 1;
            label_Income.Text = "Income:";
            // 
            // label_Spending
            // 
            label_Spending.AutoSize = true;
            label_Spending.Location = new Point(9, 20);
            label_Spending.Margin = new Padding(2, 0, 2, 0);
            label_Spending.Name = "label_Spending";
            label_Spending.Size = new Size(60, 15);
            label_Spending.TabIndex = 2;
            label_Spending.Text = "Spending:";
            // 
            // label_IncomeSum
            // 
            label_IncomeSum.AutoSize = true;
            label_IncomeSum.Location = new Point(83, 2);
            label_IncomeSum.Margin = new Padding(2, 0, 2, 0);
            label_IncomeSum.Name = "label_IncomeSum";
            label_IncomeSum.Size = new Size(31, 15);
            label_IncomeSum.TabIndex = 3;
            label_IncomeSum.Text = "Sum";
            // 
            // label_SpendingSum
            // 
            label_SpendingSum.AutoSize = true;
            label_SpendingSum.Location = new Point(83, 20);
            label_SpendingSum.Margin = new Padding(2, 0, 2, 0);
            label_SpendingSum.Name = "label_SpendingSum";
            label_SpendingSum.Size = new Size(31, 15);
            label_SpendingSum.TabIndex = 4;
            label_SpendingSum.Text = "Sum";
            // 
            // label_General
            // 
            label_General.AutoSize = true;
            label_General.Location = new Point(83, 39);
            label_General.Margin = new Padding(2, 0, 2, 0);
            label_General.Name = "label_General";
            label_General.Size = new Size(31, 15);
            label_General.TabIndex = 6;
            label_General.Text = "Sum";
            // 
            // label_Ingeneral
            // 
            label_Ingeneral.AutoSize = true;
            label_Ingeneral.Location = new Point(9, 39);
            label_Ingeneral.Margin = new Padding(2, 0, 2, 0);
            label_Ingeneral.Name = "label_Ingeneral";
            label_Ingeneral.Size = new Size(62, 15);
            label_Ingeneral.TabIndex = 5;
            label_Ingeneral.Text = "In general:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(453, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources._352084_ic_guardar_save;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Image = Properties.Resources._1564526_add_arrow_download_save_guardar_icon;
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources._352328_to_exit_ic_app;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Image = Properties.Resources._352423_ic_help;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(60, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // listView_MonthYearAlltime
            // 
            listView_MonthYearAlltime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_MonthYearAlltime.Columns.AddRange(new ColumnHeader[] { Category, Date, Money });
            listView_MonthYearAlltime.Location = new Point(0, 24);
            listView_MonthYearAlltime.Name = "listView_MonthYearAlltime";
            listView_MonthYearAlltime.Size = new Size(453, 537);
            listView_MonthYearAlltime.TabIndex = 11;
            listView_MonthYearAlltime.UseCompatibleStateImageBehavior = false;
            listView_MonthYearAlltime.View = View.Details;
            // 
            // Category
            // 
            Category.Text = "Category";
            Category.Width = 157;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 120;
            // 
            // Money
            // 
            Money.Text = "Money";
            Money.Width = 170;
            // 
            // button_Close
            // 
            button_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Close.Location = new Point(366, 31);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(75, 23);
            button_Close.TabIndex = 12;
            button_Close.Text = "Close";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label_Income);
            panel1.Controls.Add(button_Close);
            panel1.Controls.Add(label_Spending);
            panel1.Controls.Add(label_Ingeneral);
            panel1.Controls.Add(label_IncomeSum);
            panel1.Controls.Add(label_General);
            panel1.Controls.Add(label_SpendingSum);
            panel1.Location = new Point(0, 559);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 61);
            panel1.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 620);
            Controls.Add(panel1);
            Controls.Add(listView_MonthYearAlltime);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            KeyDown += Form2_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Income;
        private Label label_Spending;
        private Label label_IncomeSum;
        private Label label_SpendingSum;
        private Label label_General;
        private Label label_Ingeneral;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ListView listView_MonthYearAlltime;
        private ColumnHeader Category;
        private ColumnHeader Date;
        private ColumnHeader Money;
        private Button button_Close;
        private Panel panel1;
    }
}