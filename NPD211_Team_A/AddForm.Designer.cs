namespace NPD211_Team_A
{
    partial class AddForm
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
            AddCategoryLbl = new Label();
            AddCategoryTB = new TextBox();
            AddCategoryBtn = new Button();
            AddBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // CategoryLbl
            // 
            CategoryLbl.AutoSize = true;
            CategoryLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLbl.Location = new Point(31, 30);
            CategoryLbl.Name = "CategoryLbl";
            CategoryLbl.Size = new Size(99, 28);
            CategoryLbl.TabIndex = 0;
            CategoryLbl.Text = "Категорія";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 31);
            comboBox1.TabIndex = 1;
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DateLbl.Location = new Point(31, 70);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(54, 28);
            DateLbl.TabIndex = 0;
            DateLbl.Text = "Дата";
            // 
            // DateDTP
            // 
            DateDTP.CustomFormat = "dd:MM:yyyy";
            DateDTP.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            DateDTP.Location = new Point(171, 67);
            DateDTP.Name = "DateDTP";
            DateDTP.Size = new Size(170, 31);
            DateDTP.TabIndex = 2;
            // 
            // SumLbl
            // 
            SumLbl.AutoSize = true;
            SumLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SumLbl.Location = new Point(31, 107);
            SumLbl.Name = "SumLbl";
            SumLbl.Size = new Size(58, 28);
            SumLbl.TabIndex = 0;
            SumLbl.Text = "Сума";
            // 
            // SumTB
            // 
            SumTB.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            SumTB.Location = new Point(171, 104);
            SumTB.Name = "SumTB";
            SumTB.Size = new Size(170, 31);
            SumTB.TabIndex = 3;
            // 
            // AddCategoryLbl
            // 
            AddCategoryLbl.AutoSize = true;
            AddCategoryLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddCategoryLbl.Location = new Point(51, 158);
            AddCategoryLbl.Name = "AddCategoryLbl";
            AddCategoryLbl.Size = new Size(228, 28);
            AddCategoryLbl.TabIndex = 0;
            AddCategoryLbl.Text = "Додати свою категорію";
            // 
            // AddCategoryTB
            // 
            AddCategoryTB.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AddCategoryTB.Location = new Point(51, 206);
            AddCategoryTB.Name = "AddCategoryTB";
            AddCategoryTB.Size = new Size(170, 31);
            AddCategoryTB.TabIndex = 3;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddCategoryBtn.Location = new Point(254, 206);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(87, 31);
            AddCategoryBtn.TabIndex = 4;
            AddCategoryBtn.Text = "Додати";
            AddCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(356, 67);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(116, 31);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Додати";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.Location = new Point(356, 104);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.RightToLeft = RightToLeft.No;
            CancelBtn.Size = new Size(116, 31);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Скасувати";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(AddCategoryBtn);
            Controls.Add(AddCategoryTB);
            Controls.Add(SumTB);
            Controls.Add(DateDTP);
            Controls.Add(comboBox1);
            Controls.Add(AddCategoryLbl);
            Controls.Add(SumLbl);
            Controls.Add(DateLbl);
            Controls.Add(CategoryLbl);
            Name = "AddForm";
            Text = "Додати";
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
        private Label AddCategoryLbl;
        private TextBox AddCategoryTB;
        private Button AddCategoryBtn;
        private Button AddBtn;
        private Button CancelBtn;
    }
}