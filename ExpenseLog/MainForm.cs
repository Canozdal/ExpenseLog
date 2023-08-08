using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ExpenseLog
{
      
    public partial class MainForm : Form
    {
        private LoginControl loginControl;
        private LandingControl landingControl; 
        private SignUpControl signUpControl;
        private List<DataItem> expenseList;
        public MainForm()
        {
            InitializeComponent();

            expenseList = new List<DataItem>();
            loginControl = new LoginControl();
            landingControl = new LandingControl();
            signUpControl = new SignUpControl();

            mainPanel.Controls.Add(loginControl);
            loginControl.Dock = DockStyle.Fill;

            loginControl.OnLogin += OnLogin;
            landingControl.OnAddButtonClick += OnAddButtonClick;
            landingControl.OnDeleteButtonClick += OnDeleteButtonClick;
            landingControl.OnEditButtonClick += OnEditButtonClick;
            loginControl.OnSignUp += OnSignUp;

        }
        private void OnLogin(object sender, EventArgs e)
        {
            
            
            messageLabel.Text = loginControl.GetMessage();

            if(loginControl.getUserNameTextBot() == "Can" && loginControl.GetPasswordTextBox() == "1234") { 
                mainPanel.Controls.Remove(loginControl);

                mainPanel.Controls.Add(landingControl);
                landingControl.Dock = DockStyle.Fill;

                landingControl.OnLogout += OnLogout;
                messageLabel.Text = $"Welcome {loginControl.getUserNameTextBot()}";
            }
            else
            {
                messageLabel.Text = "Invalid Credentials";
            }
        }
        private void OnLogout(object sender, EventArgs e)
        {
            messageLabel.Text = landingControl.GetMessage();
            mainPanel.Controls.Remove(landingControl);

            mainPanel.Controls.Add(loginControl);
            loginControl.Dock= DockStyle.Fill;

            landingControl.OnLogout -= OnLogout;
        }
        private void OnSignUp(object sender, EventArgs e)
        {
            messageLabel.Text = "Navigating to Sign Up panel";
            mainPanel.Controls.Remove(loginControl);
            mainPanel.Controls.Add(signUpControl);
            loginControl.Dock= DockStyle.Fill;
            loginControl.OnSignUp -= OnSignUp;
            signUpControl.OnGoBack += OnGoBack;
        }
        private void OnGoBack(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(signUpControl);
            mainPanel.Controls.Add(loginControl);
            loginControl.Dock= DockStyle.Fill;

        }
        private void OnAddButtonClick (object sender, AddButtonEventArgs e)
        {
            DataItem item = new DataItem(e.Name,e.Description,e.Cost);
            expenseList.Add(item);

            messageLabel.Text = $"{expenseList[0].ToString()}";

            landingControl.SetExpenseList(expenseList);
        }
        private void OnDeleteButtonClick(object sender, DeleteButtonEventArgs e)
        {
            DataItem item = searchExpenseItemWithName(e.Name);
            if(item != null)
            {
                expenseList.Remove(item);
                landingControl.SetExpenseList(expenseList);
            }
            else
            {
                messageLabel.Text = "Couldnt find the item";
            }

        }
        private void OnEditButtonClick(object sender, EditButtonEventArgs e)
        {
            for(int i = 0; i < expenseList.Count; i++)
            {
                if (expenseList[i].ConvertToString() == e.OldName)
                {
                    expenseList[i].ChangeItem(e.Name, e.Description, e.Cost);
                    break;
                }
            }
            landingControl.SetExpenseList(expenseList);
        }
        private DataItem searchExpenseItemWithName(string name)
        {
            messageLabel.Text = $"{name}";
            for(int i = 0; i < expenseList.Count; i++)
            {
                if(name == expenseList[i].GetName())
                {
                    return expenseList[i];
                }
            }
            return null;
        }
    }
    public class DataItem
    {
        string name;
        string description;
        string cost;
        DateTime time;
        public DataItem(string name, string description, string cost)
        {
            this.name = name;
            this.description = description;
            this.cost = cost;
            this.time = DateTime.Now;
        }
        public DataItem(string name, string cost)
        {
            this.name = name;
            this.cost = cost;
            this.time = DateTime.Now;
            this.description = "No description added";
        }
        public override string ToString()
        {
            return $"{this.name} {this.description} {this.cost}";
        }
        public string GetName()
        {
            return name ;
        }
        public void ChangeItem(string name, string description, string cost)
        {
            this.name = name;
            this.description = description;
            this.cost = cost;
        }
        public  string ConvertToString()
        {
            return name + " " + description + " " + cost;
        }
    }
}
