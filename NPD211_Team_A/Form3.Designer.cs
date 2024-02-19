using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NPD211_Team_A
{
    partial class Form3
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
            CategoryLbl = new Label();
            comboBox1 = new ComboBox();
            DateLbl = new Label();
            DateDTP = new DateTimePicker();
            SumLbl = new Label();
            SumTB = new TextBox();
            AddCategoryTB = new TextBox();
            AddCategoryBtn = new Button();
            AddBtn = new Button();
            CancelBtn = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CategoryLbl
            // 
            CategoryLbl.AutoSize = true;
            CategoryLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLbl.Location = new Point(12, 39);
            CategoryLbl.Name = "CategoryLbl";
            CategoryLbl.Size = new Size(59, 15);
            CategoryLbl.TabIndex = 0;
            CategoryLbl.Text = "Категорія";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 1;
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DateLbl.Location = new Point(12, 69);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(32, 15);
            DateLbl.TabIndex = 0;
            DateLbl.Text = "Дата";
            // 
            // DateDTP
            // 
            DateDTP.CustomFormat = "dd.MM.yyyy";
            DateDTP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DateDTP.Format = DateTimePickerFormat.Custom;
            DateDTP.Location = new Point(77, 65);
            DateDTP.Name = "DateDTP";
            DateDTP.Size = new Size(170, 23);
            DateDTP.TabIndex = 2;
            // 
            // SumLbl
            // 
            SumLbl.AutoSize = true;
            SumLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SumLbl.Location = new Point(12, 97);
            SumLbl.Name = "SumLbl";
            SumLbl.Size = new Size(36, 15);
            SumLbl.TabIndex = 0;
            SumLbl.Text = "Сума";
            // 
            // SumTB
            // 
            SumTB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SumTB.Location = new Point(77, 94);
            SumTB.Name = "SumTB";
            SumTB.Size = new Size(170, 23);
            SumTB.TabIndex = 3;
            // 
            // AddCategoryTB
            // 
            AddCategoryTB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddCategoryTB.Location = new Point(6, 22);
            AddCategoryTB.Name = "AddCategoryTB";
            AddCategoryTB.Size = new Size(170, 23);
            AddCategoryTB.TabIndex = 3;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddCategoryBtn.Location = new Point(235, 21);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(73, 23);
            AddCategoryBtn.TabIndex = 4;
            AddCategoryBtn.Text = "Додати";
            AddCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.DialogResult = DialogResult.OK;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(253, 36);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(73, 23);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Додати";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.DialogResult = DialogResult.Cancel;
            CancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.Location = new Point(253, 65);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.RightToLeft = RightToLeft.No;
            CancelBtn.Size = new Size(73, 23);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Скасувати";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(338, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Image = Properties.Resources._352423_ic_help;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(60, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddCategoryTB);
            groupBox1.Controls.Add(AddCategoryBtn);
            groupBox1.Location = new Point(12, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 55);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new category";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 187);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(SumTB);
            Controls.Add(DateDTP);
            Controls.Add(comboBox1);
            Controls.Add(SumLbl);
            Controls.Add(DateLbl);
            Controls.Add(CategoryLbl);
            Name = "Form3";
            Text = "Додати";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CategoryLbl;
        private ComboBox comboBox1;
        private Label DateLbl;
        private DateTimePicker DateDTP;
        private Label SumLbl;
        private TextBox SumTB;
        private TextBox AddCategoryTB;
        private Button AddCategoryBtn;
        private Button AddBtn;
        private Button CancelBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox groupBox1;
    }
}