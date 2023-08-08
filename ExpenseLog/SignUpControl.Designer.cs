namespace ExpenseLog
{
    partial class SignUpControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserNameRegBox = new System.Windows.Forms.TextBox();
            this.UserNameRegLabel = new System.Windows.Forms.Label();
            this.PasswordRegLabel = new System.Windows.Forms.Label();
            this.PasswordRegBox = new System.Windows.Forms.TextBox();
            this.SignUpRegButton = new System.Windows.Forms.Button();
            this.GoBackRegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameRegBox
            // 
            this.UserNameRegBox.Location = new System.Drawing.Point(310, 159);
            this.UserNameRegBox.Name = "UserNameRegBox";
            this.UserNameRegBox.Size = new System.Drawing.Size(214, 20);
            this.UserNameRegBox.TabIndex = 0;
            // 
            // UserNameRegLabel
            // 
            this.UserNameRegLabel.AutoSize = true;
            this.UserNameRegLabel.Location = new System.Drawing.Point(211, 165);
            this.UserNameRegLabel.Name = "UserNameRegLabel";
            this.UserNameRegLabel.Size = new System.Drawing.Size(55, 13);
            this.UserNameRegLabel.TabIndex = 1;
            this.UserNameRegLabel.Text = "Username";
            // 
            // PasswordRegLabel
            // 
            this.PasswordRegLabel.AutoSize = true;
            this.PasswordRegLabel.Location = new System.Drawing.Point(214, 199);
            this.PasswordRegLabel.Name = "PasswordRegLabel";
            this.PasswordRegLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordRegLabel.TabIndex = 2;
            this.PasswordRegLabel.Text = "Password";
            // 
            // PasswordRegBox
            // 
            this.PasswordRegBox.Location = new System.Drawing.Point(310, 199);
            this.PasswordRegBox.Name = "PasswordRegBox";
            this.PasswordRegBox.Size = new System.Drawing.Size(214, 20);
            this.PasswordRegBox.TabIndex = 3;
            // 
            // SignUpRegButton
            // 
            this.SignUpRegButton.Location = new System.Drawing.Point(310, 251);
            this.SignUpRegButton.Name = "SignUpRegButton";
            this.SignUpRegButton.Size = new System.Drawing.Size(214, 23);
            this.SignUpRegButton.TabIndex = 4;
            this.SignUpRegButton.Text = "Sign Up";
            this.SignUpRegButton.UseVisualStyleBackColor = true;
            // 
            // GoBackRegButton
            // 
            this.GoBackRegButton.Location = new System.Drawing.Point(310, 290);
            this.GoBackRegButton.Name = "GoBackRegButton";
            this.GoBackRegButton.Size = new System.Drawing.Size(214, 23);
            this.GoBackRegButton.TabIndex = 5;
            this.GoBackRegButton.Text = "Go Back";
            this.GoBackRegButton.UseVisualStyleBackColor = true;
            this.GoBackRegButton.Click += new System.EventHandler(this.GoBackRegButton_Click);
            // 
            // SignUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.GoBackRegButton);
            this.Controls.Add(this.SignUpRegButton);
            this.Controls.Add(this.PasswordRegBox);
            this.Controls.Add(this.PasswordRegLabel);
            this.Controls.Add(this.UserNameRegLabel);
            this.Controls.Add(this.UserNameRegBox);
            this.Name = "SignUpControl";
            this.Size = new System.Drawing.Size(698, 356);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameRegBox;
        private System.Windows.Forms.Label UserNameRegLabel;
        private System.Windows.Forms.Label PasswordRegLabel;
        private System.Windows.Forms.TextBox PasswordRegBox;
        private System.Windows.Forms.Button SignUpRegButton;
        private System.Windows.Forms.Button GoBackRegButton;
    }
}
