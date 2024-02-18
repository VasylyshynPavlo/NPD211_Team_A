namespace NPD211_Team_A
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
            ItemsListBox = new ListBox();
            ControlsButtonsGroupBox = new GroupBox();
            ControlsAddButton = new Button();
            ControlsDeleteButton = new Button();
            ControlsViewButton = new Button();
            BalanceTextLable = new Label();
            BalanceValueLabel = new Label();
            BalanceUpdateButton = new Button();
            ViewByGroupBox = new GroupBox();
            ViewByDayButton = new Button();
            ViewByMonthButton = new Button();
            ViewByYearButton = new Button();
            ViewByCustomButton = new Button();
            SaveStatusLabel = new Label();
            SaveButton = new Button();
            ControlsButtonsGroupBox.SuspendLayout();
            ViewByGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(12, 12);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(299, 424);
            ItemsListBox.TabIndex = 0;
            // 
            // ControlsButtonsGroupBox
            // 
            ControlsButtonsGroupBox.Controls.Add(ControlsViewButton);
            ControlsButtonsGroupBox.Controls.Add(ControlsDeleteButton);
            ControlsButtonsGroupBox.Controls.Add(ControlsAddButton);
            ControlsButtonsGroupBox.Location = new Point(317, 12);
            ControlsButtonsGroupBox.Name = "ControlsButtonsGroupBox";
            ControlsButtonsGroupBox.Size = new Size(200, 112);
            ControlsButtonsGroupBox.TabIndex = 1;
            ControlsButtonsGroupBox.TabStop = false;
            ControlsButtonsGroupBox.Text = "Controls";
            // 
            // ControlsAddButton
            // 
            ControlsAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ControlsAddButton.Location = new Point(6, 22);
            ControlsAddButton.Name = "ControlsAddButton";
            ControlsAddButton.Size = new Size(188, 23);
            ControlsAddButton.TabIndex = 2;
            ControlsAddButton.Text = "Add";
            ControlsAddButton.UseVisualStyleBackColor = true;
            // 
            // ControlsDeleteButton
            // 
            ControlsDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ControlsDeleteButton.Location = new Point(6, 50);
            ControlsDeleteButton.Name = "ControlsDeleteButton";
            ControlsDeleteButton.Size = new Size(188, 23);
            ControlsDeleteButton.TabIndex = 4;
            ControlsDeleteButton.Text = "Delete";
            ControlsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ControlsViewButton
            // 
            ControlsViewButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ControlsViewButton.Location = new Point(6, 79);
            ControlsViewButton.Name = "ControlsViewButton";
            ControlsViewButton.Size = new Size(188, 23);
            ControlsViewButton.TabIndex = 5;
            ControlsViewButton.Text = "View";
            ControlsViewButton.UseVisualStyleBackColor = true;
            // 
            // BalanceTextLable
            // 
            BalanceTextLable.AutoSize = true;
            BalanceTextLable.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BalanceTextLable.Location = new Point(317, 127);
            BalanceTextLable.Name = "BalanceTextLable";
            BalanceTextLable.Size = new Size(147, 25);
            BalanceTextLable.TabIndex = 2;
            BalanceTextLable.Text = "Current balance";
            // 
            // BalanceValueLabel
            // 
            BalanceValueLabel.AutoSize = true;
            BalanceValueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BalanceValueLabel.Location = new Point(317, 152);
            BalanceValueLabel.Name = "BalanceValueLabel";
            BalanceValueLabel.Size = new Size(17, 19);
            BalanceValueLabel.TabIndex = 3;
            BalanceValueLabel.Text = "0";
            // 
            // BalanceUpdateButton
            // 
            BalanceUpdateButton.Location = new Point(317, 174);
            BalanceUpdateButton.Name = "BalanceUpdateButton";
            BalanceUpdateButton.Size = new Size(75, 23);
            BalanceUpdateButton.TabIndex = 4;
            BalanceUpdateButton.Text = "Update";
            BalanceUpdateButton.UseVisualStyleBackColor = true;
            // 
            // ViewByGroupBox
            // 
            ViewByGroupBox.Controls.Add(ViewByCustomButton);
            ViewByGroupBox.Controls.Add(ViewByYearButton);
            ViewByGroupBox.Controls.Add(ViewByMonthButton);
            ViewByGroupBox.Controls.Add(ViewByDayButton);
            ViewByGroupBox.Location = new Point(317, 203);
            ViewByGroupBox.Name = "ViewByGroupBox";
            ViewByGroupBox.Size = new Size(200, 140);
            ViewByGroupBox.TabIndex = 5;
            ViewByGroupBox.TabStop = false;
            ViewByGroupBox.Text = "View by";
            // 
            // ViewByDayButton
            // 
            ViewByDayButton.Location = new Point(6, 22);
            ViewByDayButton.Name = "ViewByDayButton";
            ViewByDayButton.Size = new Size(188, 23);
            ViewByDayButton.TabIndex = 0;
            ViewByDayButton.Text = "Day";
            ViewByDayButton.UseVisualStyleBackColor = true;
            // 
            // ViewByMonthButton
            // 
            ViewByMonthButton.Location = new Point(6, 51);
            ViewByMonthButton.Name = "ViewByMonthButton";
            ViewByMonthButton.Size = new Size(188, 23);
            ViewByMonthButton.TabIndex = 1;
            ViewByMonthButton.Text = "Month";
            ViewByMonthButton.UseVisualStyleBackColor = true;
            // 
            // ViewByYearButton
            // 
            ViewByYearButton.Location = new Point(6, 80);
            ViewByYearButton.Name = "ViewByYearButton";
            ViewByYearButton.Size = new Size(188, 23);
            ViewByYearButton.TabIndex = 2;
            ViewByYearButton.Text = "Year";
            ViewByYearButton.UseVisualStyleBackColor = true;
            // 
            // ViewByCustomButton
            // 
            ViewByCustomButton.Location = new Point(6, 109);
            ViewByCustomButton.Name = "ViewByCustomButton";
            ViewByCustomButton.Size = new Size(188, 23);
            ViewByCustomButton.TabIndex = 3;
            ViewByCustomButton.Text = "Custom";
            ViewByCustomButton.UseVisualStyleBackColor = true;
            // 
            // SaveStatusLabel
            // 
            SaveStatusLabel.AutoSize = true;
            SaveStatusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SaveStatusLabel.ForeColor = Color.MediumSeaGreen;
            SaveStatusLabel.Location = new Point(317, 415);
            SaveStatusLabel.Name = "SaveStatusLabel";
            SaveStatusLabel.Size = new Size(45, 19);
            SaveStatusLabel.TabIndex = 6;
            SaveStatusLabel.Text = "Saved";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(442, 413);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 450);
            Controls.Add(SaveButton);
            Controls.Add(SaveStatusLabel);
            Controls.Add(ViewByGroupBox);
            Controls.Add(BalanceUpdateButton);
            Controls.Add(BalanceValueLabel);
            Controls.Add(BalanceTextLable);
            Controls.Add(ControlsButtonsGroupBox);
            Controls.Add(ItemsListBox);
            Name = "Form1";
            Text = "Form1";
            ControlsButtonsGroupBox.ResumeLayout(false);
            ViewByGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ItemsListBox;
        private GroupBox ControlsButtonsGroupBox;
        private Button ControlsViewButton;
        private Button ControlsDeleteButton;
        private Button ControlsAddButton;
        private Label BalanceTextLable;
        private Label BalanceValueLabel;
        private Button BalanceUpdateButton;
        private GroupBox ViewByGroupBox;
        private Button ViewByCustomButton;
        private Button ViewByYearButton;
        private Button ViewByMonthButton;
        private Button ViewByDayButton;
        private Label SaveStatusLabel;
        private Button SaveButton;
    }
}