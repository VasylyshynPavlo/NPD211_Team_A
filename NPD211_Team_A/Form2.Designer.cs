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
            listBox_MonthYearAlltime = new ListBox();
            label_Income = new Label();
            label_Spending = new Label();
            label_IncomeSum = new Label();
            label_SpendingSum = new Label();
            label_General = new Label();
            label_Ingeneral = new Label();
            button_Close = new Button();
            SuspendLayout();
            // 
            // listBox_MonthYearAlltime
            // 
            listBox_MonthYearAlltime.FormattingEnabled = true;
            listBox_MonthYearAlltime.ItemHeight = 25;
            listBox_MonthYearAlltime.Location = new Point(12, 14);
            listBox_MonthYearAlltime.Name = "listBox_MonthYearAlltime";
            listBox_MonthYearAlltime.Size = new Size(425, 429);
            listBox_MonthYearAlltime.TabIndex = 0;
            // 
            // label_Income
            // 
            label_Income.AutoSize = true;
            label_Income.Location = new Point(443, 14);
            label_Income.Name = "label_Income";
            label_Income.Size = new Size(75, 25);
            label_Income.TabIndex = 1;
            label_Income.Text = "Income:";
            // 
            // label_Spending
            // 
            label_Spending.AutoSize = true;
            label_Spending.Location = new Point(443, 39);
            label_Spending.Name = "label_Spending";
            label_Spending.Size = new Size(92, 25);
            label_Spending.TabIndex = 2;
            label_Spending.Text = "Spending:";
            // 
            // label_IncomeSum
            // 
            label_IncomeSum.AutoSize = true;
            label_IncomeSum.Location = new Point(557, 14);
            label_IncomeSum.Name = "label_IncomeSum";
            label_IncomeSum.Size = new Size(48, 25);
            label_IncomeSum.TabIndex = 3;
            label_IncomeSum.Text = "Sum";
            // 
            // label_SpendingSum
            // 
            label_SpendingSum.AutoSize = true;
            label_SpendingSum.Location = new Point(557, 39);
            label_SpendingSum.Name = "label_SpendingSum";
            label_SpendingSum.Size = new Size(48, 25);
            label_SpendingSum.TabIndex = 4;
            label_SpendingSum.Text = "Sum";
            // 
            // label_General
            // 
            label_General.AutoSize = true;
            label_General.Location = new Point(557, 64);
            label_General.Name = "label_General";
            label_General.Size = new Size(48, 25);
            label_General.TabIndex = 6;
            label_General.Text = "Sum";
            // 
            // label_Ingeneral
            // 
            label_Ingeneral.AutoSize = true;
            label_Ingeneral.Location = new Point(443, 64);
            label_Ingeneral.Name = "label_Ingeneral";
            label_Ingeneral.Size = new Size(94, 25);
            label_Ingeneral.TabIndex = 5;
            label_Ingeneral.Text = "In general:";
            // 
            // button_Close
            // 
            button_Close.BackColor = Color.White;
            button_Close.Location = new Point(676, 404);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(112, 34);
            button_Close.TabIndex = 7;
            button_Close.Text = "Close";
            button_Close.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Close);
            Controls.Add(label_General);
            Controls.Add(label_Ingeneral);
            Controls.Add(label_SpendingSum);
            Controls.Add(label_IncomeSum);
            Controls.Add(label_Spending);
            Controls.Add(label_Income);
            Controls.Add(listBox_MonthYearAlltime);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_MonthYearAlltime;
        private Label label_Income;
        private Label label_Spending;
        private Label label_IncomeSum;
        private Label label_SpendingSum;
        private Label label_General;
        private Label label_Ingeneral;
        private Button button_Close;
    }
}