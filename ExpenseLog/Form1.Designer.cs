namespace ExpenseLog
{
    partial class Form1
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
            this.pushExpenseButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.showExpenseListBox = new System.Windows.Forms.ListBox();
            this.showExpenseListButton = new System.Windows.Forms.Button();
            this.listBoxItemDescLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pushExpenseButton
            // 
            this.pushExpenseButton.Location = new System.Drawing.Point(632, 233);
            this.pushExpenseButton.Name = "pushExpenseButton";
            this.pushExpenseButton.Size = new System.Drawing.Size(75, 23);
            this.pushExpenseButton.TabIndex = 0;
            this.pushExpenseButton.Text = "Add";
            this.pushExpenseButton.UseVisualStyleBackColor = true;
            this.pushExpenseButton.Click += new System.EventHandler(this.pushExpenseButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(311, 135);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(330, 22);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(311, 172);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 2;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(311, 218);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 22);
            this.categoryTextBox.TabIndex = 3;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(271, 178);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(34, 16);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            this.costLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(230, 135);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(75, 16);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(243, 224);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(62, 16);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(632, 339);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // showExpenseListBox
            // 
            this.showExpenseListBox.FormattingEnabled = true;
            this.showExpenseListBox.ItemHeight = 16;
            this.showExpenseListBox.Location = new System.Drawing.Point(12, 43);
            this.showExpenseListBox.Name = "showExpenseListBox";
            this.showExpenseListBox.Size = new System.Drawing.Size(212, 308);
            this.showExpenseListBox.TabIndex = 9;
            this.showExpenseListBox.SelectedIndexChanged += new System.EventHandler(this.showExpenseListBox_SelectedIndexChanged);
            // 
            // showExpenseListButton
            // 
            this.showExpenseListButton.Location = new System.Drawing.Point(12, 358);
            this.showExpenseListButton.Name = "showExpenseListButton";
            this.showExpenseListButton.Size = new System.Drawing.Size(212, 23);
            this.showExpenseListButton.TabIndex = 10;
            this.showExpenseListButton.Text = "List";
            this.showExpenseListButton.UseVisualStyleBackColor = true;
            this.showExpenseListButton.Click += new System.EventHandler(this.showExpenseListButton_Click);
            // 
            // listBoxItemDescLbl
            // 
            this.listBoxItemDescLbl.AutoSize = true;
            this.listBoxItemDescLbl.Location = new System.Drawing.Point(246, 56);
            this.listBoxItemDescLbl.Name = "listBoxItemDescLbl";
            this.listBoxItemDescLbl.Size = new System.Drawing.Size(40, 16);
            this.listBoxItemDescLbl.TabIndex = 11;
            this.listBoxItemDescLbl.Text = "None";
            this.listBoxItemDescLbl.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxItemDescLbl);
            this.Controls.Add(this.showExpenseListButton);
            this.Controls.Add(this.showExpenseListBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.pushExpenseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pushExpenseButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListBox showExpenseListBox;
        private System.Windows.Forms.Button showExpenseListButton;
        private System.Windows.Forms.Label listBoxItemDescLbl;
    }
}

