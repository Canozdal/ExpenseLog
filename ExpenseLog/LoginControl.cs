using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseLog
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler OnLogin;
        public event EventHandler OnSignUp;
        private string message = "";
        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            OnLogin?.Invoke(this, EventArgs.Empty);
            message = "Data transfer successfull";
        }
        public string getUserNameTextBot()
        {
            return UsernameTextBox.Text;
        }
        public string GetMessage()
        {
            return message;
        }
        public string GetPasswordTextBox()
        {
            return PasswordTextBox.Text;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            OnSignUp?.Invoke(this, EventArgs.Empty);
            message = "Navigated to signup page successfully";
        }
    }
}
