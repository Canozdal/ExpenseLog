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

    public partial class SignUpControl : UserControl
    {
        public event EventHandler OnGoBack;
        public SignUpControl()
        {
            InitializeComponent();
        }

        private void GoBackRegButton_Click(object sender, EventArgs e)
        {
            OnGoBack?.Invoke(this, EventArgs.Empty);
        }
    }
}
