﻿namespace NPD211_Team_A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ItemsListView = new ListView();
            Category = new ColumnHeader();
            Date = new ColumnHeader();
            Money = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            dayToolStripMenuItem = new ToolStripMenuItem();
            dayToolStripMenuItem1 = new ToolStripMenuItem();
            monthToolStripMenuItem = new ToolStripMenuItem();
            yearToolStripMenuItem = new ToolStripMenuItem();
            customToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListView
            // 
            ItemsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListView.Columns.AddRange(new ColumnHeader[] { Category, Date, Money });
            ItemsListView.Location = new Point(0, 24);
            ItemsListView.Name = "ItemsListView";
            ItemsListView.Size = new Size(453, 538);
            ItemsListView.TabIndex = 8;
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(453, 24);
            menuStrip1.TabIndex = 9;
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
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem, viewToolStripMenuItem1 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = Properties.Resources._352006_add_ic_outline_circle;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            addToolStripMenuItem.Size = new Size(141, 22);
            addToolStripMenuItem.Text = "Add";
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Image = Properties.Resources._352442_remove_outline_ic_circle;
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            removeToolStripMenuItem.Size = new Size(141, 22);
            removeToolStripMenuItem.Text = "Remove";
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.Image = Properties.Resources._352202_view_day_ic;
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.ShortcutKeyDisplayString = "Enter";
            viewToolStripMenuItem1.Size = new Size(141, 22);
            viewToolStripMenuItem1.Text = "View";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dayToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // dayToolStripMenuItem
            // 
            dayToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dayToolStripMenuItem1, monthToolStripMenuItem, yearToolStripMenuItem, customToolStripMenuItem });
            dayToolStripMenuItem.Image = Properties.Resources._352202_view_day_ic;
            dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            dayToolStripMenuItem.Size = new Size(124, 22);
            dayToolStripMenuItem.Text = "Show last";
            // 
            // dayToolStripMenuItem1
            // 
            dayToolStripMenuItem1.Name = "dayToolStripMenuItem1";
            dayToolStripMenuItem1.ShortcutKeyDisplayString = "F1";
            dayToolStripMenuItem1.Size = new Size(135, 22);
            dayToolStripMenuItem1.Text = "Day";
            dayToolStripMenuItem1.Click += dayToolStripMenuItem1_Click;
            // 
            // monthToolStripMenuItem
            // 
            monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            monthToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            monthToolStripMenuItem.Size = new Size(135, 22);
            monthToolStripMenuItem.Text = "Month";
            monthToolStripMenuItem.Click += monthToolStripMenuItem_Click;
            // 
            // yearToolStripMenuItem
            // 
            yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            yearToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            yearToolStripMenuItem.Size = new Size(135, 22);
            yearToolStripMenuItem.Text = "Year";
            yearToolStripMenuItem.Click += yearToolStripMenuItem_Click;
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Image = Properties.Resources._352548_ic_more_three_dots_dots_horiz;
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.ShortcutKeyDisplayString = "F4";
            customToolStripMenuItem.Size = new Size(135, 22);
            customToolStripMenuItem.Text = "Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Image = Properties.Resources._352423_ic_help;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(60, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 10;
            label1.Text = "Balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 9);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 11;
            label2.Text = "0";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 563);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 44);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 607);
            Controls.Add(panel1);
            Controls.Add(ItemsListView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ItemsListView;
        private ColumnHeader Category;
        private ColumnHeader Date;
        private ColumnHeader Money;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem dayToolStripMenuItem;
        private ToolStripMenuItem dayToolStripMenuItem1;
        private ToolStripMenuItem monthToolStripMenuItem;
        private ToolStripMenuItem yearToolStripMenuItem;
        private ToolStripMenuItem customToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}