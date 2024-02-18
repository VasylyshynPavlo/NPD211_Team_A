namespace NPD211_Team_A
{
    partial class Form4
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
            ItemsListView = new ListView();
            Category = new ColumnHeader();
            Date = new ColumnHeader();
            Money = new ColumnHeader();
            panel1 = new Panel();
            label_InGenenalSum = new Label();
            label_SpendingSum = new Label();
            label_IncomeSum = new Label();
            label_Income = new Label();
            label_Spending = new Label();
            label_Ingeneral = new Label();
            CloseButton = new Button();
            GoButton = new Button();
            groupBox1 = new GroupBox();
            ToDateTimePicker = new DateTimePicker();
            FromDateTimePicker = new DateTimePicker();
            ToTextDate = new Label();
            FromTextLable = new Label();
            ChangePanel = new Panel();
            FromToButton = new RadioButton();
            YearsAgoButton = new RadioButton();
            MonthAgoButton = new RadioButton();
            DaysAgoButton = new RadioButton();
            AgoGroupBox = new GroupBox();
            AgoNumericUpDown = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ChangePanel.SuspendLayout();
            AgoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AgoNumericUpDown).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListView
            // 
            ItemsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListView.Columns.AddRange(new ColumnHeader[] { Category, Date, Money });
            ItemsListView.Location = new Point(0, 27);
            ItemsListView.Name = "ItemsListView";
            ItemsListView.Size = new Size(454, 436);
            ItemsListView.TabIndex = 9;
            ItemsListView.UseCompatibleStateImageBehavior = false;
            ItemsListView.View = View.Details;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label_InGenenalSum);
            panel1.Controls.Add(label_SpendingSum);
            panel1.Controls.Add(label_IncomeSum);
            panel1.Controls.Add(label_Income);
            panel1.Controls.Add(label_Spending);
            panel1.Controls.Add(label_Ingeneral);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(GoButton);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(ChangePanel);
            panel1.Controls.Add(AgoGroupBox);
            panel1.Location = new Point(0, 461);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 185);
            panel1.TabIndex = 10;
            // 
            // label_InGenenalSum
            // 
            label_InGenenalSum.AutoSize = true;
            label_InGenenalSum.Location = new Point(94, 160);
            label_InGenenalSum.Margin = new Padding(2, 0, 2, 0);
            label_InGenenalSum.Name = "label_InGenenalSum";
            label_InGenenalSum.Size = new Size(31, 15);
            label_InGenenalSum.TabIndex = 11;
            label_InGenenalSum.Text = "Sum";
            // 
            // label_SpendingSum
            // 
            label_SpendingSum.AutoSize = true;
            label_SpendingSum.Location = new Point(94, 144);
            label_SpendingSum.Margin = new Padding(2, 0, 2, 0);
            label_SpendingSum.Name = "label_SpendingSum";
            label_SpendingSum.Size = new Size(31, 15);
            label_SpendingSum.TabIndex = 10;
            label_SpendingSum.Text = "Sum";
            // 
            // label_IncomeSum
            // 
            label_IncomeSum.AutoSize = true;
            label_IncomeSum.Location = new Point(94, 129);
            label_IncomeSum.Margin = new Padding(2, 0, 2, 0);
            label_IncomeSum.Name = "label_IncomeSum";
            label_IncomeSum.Size = new Size(31, 15);
            label_IncomeSum.TabIndex = 9;
            label_IncomeSum.Text = "Sum";
            // 
            // label_Income
            // 
            label_Income.AutoSize = true;
            label_Income.Location = new Point(12, 129);
            label_Income.Margin = new Padding(2, 0, 2, 0);
            label_Income.Name = "label_Income";
            label_Income.Size = new Size(50, 15);
            label_Income.TabIndex = 6;
            label_Income.Text = "Income:";
            // 
            // label_Spending
            // 
            label_Spending.AutoSize = true;
            label_Spending.Location = new Point(11, 144);
            label_Spending.Margin = new Padding(2, 0, 2, 0);
            label_Spending.Name = "label_Spending";
            label_Spending.Size = new Size(60, 15);
            label_Spending.TabIndex = 7;
            label_Spending.Text = "Spending:";
            // 
            // label_Ingeneral
            // 
            label_Ingeneral.AutoSize = true;
            label_Ingeneral.Location = new Point(12, 159);
            label_Ingeneral.Margin = new Padding(2, 0, 2, 0);
            label_Ingeneral.Name = "label_Ingeneral";
            label_Ingeneral.Size = new Size(62, 15);
            label_Ingeneral.TabIndex = 8;
            label_Ingeneral.Text = "In general:";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(366, 155);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(137, 103);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go";
            GoButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ToDateTimePicker);
            groupBox1.Controls.Add(FromDateTimePicker);
            groupBox1.Controls.Add(ToTextDate);
            groupBox1.Controls.Add(FromTextLable);
            groupBox1.Location = new Point(218, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 84);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "From To";
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.CustomFormat = "dd.MM.yyyy";
            ToDateTimePicker.Format = DateTimePickerFormat.Custom;
            ToDateTimePicker.Location = new Point(124, 45);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(93, 23);
            ToDateTimePicker.TabIndex = 3;
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.CustomFormat = "dd.MM.yyyy";
            FromDateTimePicker.Format = DateTimePickerFormat.Custom;
            FromDateTimePicker.Location = new Point(124, 16);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(93, 23);
            FromDateTimePicker.TabIndex = 2;
            // 
            // ToTextDate
            // 
            ToTextDate.AutoSize = true;
            ToTextDate.Location = new Point(6, 51);
            ToTextDate.Name = "ToTextDate";
            ToTextDate.Size = new Size(19, 15);
            ToTextDate.TabIndex = 1;
            ToTextDate.Text = "To";
            // 
            // FromTextLable
            // 
            FromTextLable.AutoSize = true;
            FromTextLable.Location = new Point(6, 22);
            FromTextLable.Name = "FromTextLable";
            FromTextLable.Size = new Size(35, 15);
            FromTextLable.TabIndex = 0;
            FromTextLable.Text = "From";
            // 
            // ChangePanel
            // 
            ChangePanel.Controls.Add(FromToButton);
            ChangePanel.Controls.Add(YearsAgoButton);
            ChangePanel.Controls.Add(MonthAgoButton);
            ChangePanel.Controls.Add(DaysAgoButton);
            ChangePanel.Location = new Point(12, 9);
            ChangePanel.Name = "ChangePanel";
            ChangePanel.Size = new Size(325, 27);
            ChangePanel.TabIndex = 1;
            // 
            // FromToButton
            // 
            FromToButton.AutoSize = true;
            FromToButton.Location = new Point(253, 3);
            FromToButton.Name = "FromToButton";
            FromToButton.Size = new Size(68, 19);
            FromToButton.TabIndex = 3;
            FromToButton.TabStop = true;
            FromToButton.Text = "From To";
            FromToButton.UseVisualStyleBackColor = true;
            // 
            // YearsAgoButton
            // 
            YearsAgoButton.AutoSize = true;
            YearsAgoButton.Location = new Point(172, 3);
            YearsAgoButton.Name = "YearsAgoButton";
            YearsAgoButton.Size = new Size(75, 19);
            YearsAgoButton.TabIndex = 2;
            YearsAgoButton.TabStop = true;
            YearsAgoButton.Text = "Years ago";
            YearsAgoButton.UseVisualStyleBackColor = true;
            // 
            // MonthAgoButton
            // 
            MonthAgoButton.AutoSize = true;
            MonthAgoButton.Location = new Point(82, 3);
            MonthAgoButton.Name = "MonthAgoButton";
            MonthAgoButton.Size = new Size(84, 19);
            MonthAgoButton.TabIndex = 1;
            MonthAgoButton.TabStop = true;
            MonthAgoButton.Text = "Month ago";
            MonthAgoButton.UseVisualStyleBackColor = true;
            // 
            // DaysAgoButton
            // 
            DaysAgoButton.AutoSize = true;
            DaysAgoButton.Location = new Point(3, 3);
            DaysAgoButton.Name = "DaysAgoButton";
            DaysAgoButton.Size = new Size(73, 19);
            DaysAgoButton.TabIndex = 0;
            DaysAgoButton.TabStop = true;
            DaysAgoButton.Text = "Days ago";
            DaysAgoButton.UseVisualStyleBackColor = true;
            // 
            // AgoGroupBox
            // 
            AgoGroupBox.Controls.Add(AgoNumericUpDown);
            AgoGroupBox.Location = new Point(12, 42);
            AgoGroupBox.Name = "AgoGroupBox";
            AgoGroupBox.Size = new Size(200, 52);
            AgoGroupBox.TabIndex = 0;
            AgoGroupBox.TabStop = false;
            AgoGroupBox.Text = "Ago";
            // 
            // AgoNumericUpDown
            // 
            AgoNumericUpDown.Location = new Point(6, 22);
            AgoNumericUpDown.Name = "AgoNumericUpDown";
            AgoNumericUpDown.Size = new Size(188, 23);
            AgoNumericUpDown.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(453, 24);
            menuStrip1.TabIndex = 11;
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
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 645);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(ItemsListView);
            Name = "Form4";
            Text = "Form4";
            KeyDown += Form4_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ChangePanel.ResumeLayout(false);
            ChangePanel.PerformLayout();
            AgoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AgoNumericUpDown).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ItemsListView;
        private ColumnHeader Category;
        private ColumnHeader Date;
        private ColumnHeader Money;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox AgoGroupBox;
        private Panel ChangePanel;
        private RadioButton FromToButton;
        private RadioButton YearsAgoButton;
        private RadioButton MonthAgoButton;
        private RadioButton DaysAgoButton;
        private NumericUpDown AgoNumericUpDown;
        private GroupBox groupBox1;
        private DateTimePicker ToDateTimePicker;
        private DateTimePicker FromDateTimePicker;
        private Label ToTextDate;
        private Label FromTextLable;
        private Button CloseButton;
        private Button GoButton;
        private Label label_Income;
        private Label label_Spending;
        private Label label_Ingeneral;
        private Label label_InGenenalSum;
        private Label label_SpendingSum;
        private Label label_IncomeSum;
    }
}