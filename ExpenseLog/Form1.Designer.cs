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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pushExpenseButton
            // 
            this.pushExpenseButton.Location = new System.Drawing.Point(474, 189);
            this.pushExpenseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pushExpenseButton.Name = "pushExpenseButton";
            this.pushExpenseButton.Size = new System.Drawing.Size(56, 19);
            this.pushExpenseButton.TabIndex = 0;
            this.pushExpenseButton.Text = "Add";
            this.pushExpenseButton.UseVisualStyleBackColor = true;
            this.pushExpenseButton.Click += new System.EventHandler(this.pushExpenseButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(233, 110);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(248, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(233, 140);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(76, 20);
            this.costTextBox.TabIndex = 2;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(233, 177);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(76, 20);
            this.categoryTextBox.TabIndex = 3;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(203, 145);
            this.costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            this.costLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(172, 110);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(182, 182);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(474, 275);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(56, 19);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // showExpenseListBox
            // 
            this.showExpenseListBox.FormattingEnabled = true;
            this.showExpenseListBox.Location = new System.Drawing.Point(9, 35);
            this.showExpenseListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showExpenseListBox.Name = "showExpenseListBox";
            this.showExpenseListBox.Size = new System.Drawing.Size(160, 251);
            this.showExpenseListBox.TabIndex = 9;
            this.showExpenseListBox.SelectedIndexChanged += new System.EventHandler(this.showExpenseListBox_SelectedIndexChanged);
            // 
            // showExpenseListButton
            // 
            this.showExpenseListButton.Location = new System.Drawing.Point(9, 291);
            this.showExpenseListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showExpenseListButton.Name = "showExpenseListButton";
            this.showExpenseListButton.Size = new System.Drawing.Size(159, 19);
            this.showExpenseListButton.TabIndex = 10;
            this.showExpenseListButton.Text = "List";
            this.showExpenseListButton.UseVisualStyleBackColor = true;
            this.showExpenseListButton.Click += new System.EventHandler(this.showExpenseListButton_Click);
            // 
            // listBoxItemDescLbl
            // 
            this.listBoxItemDescLbl.AutoSize = true;
            this.listBoxItemDescLbl.Location = new System.Drawing.Point(184, 46);
            this.listBoxItemDescLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listBoxItemDescLbl.Name = "listBoxItemDescLbl";
            this.listBoxItemDescLbl.Size = new System.Drawing.Size(33, 13);
            this.listBoxItemDescLbl.TabIndex = 11;
            this.listBoxItemDescLbl.Text = "None";
            this.listBoxItemDescLbl.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "0.0";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
    }
}

