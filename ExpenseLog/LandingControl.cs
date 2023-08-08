using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExpenseLog
{
  
    public partial class LandingControl : UserControl
    {
        public event EventHandler OnLogout;
        public event AddButtonEventHandler OnAddButtonClick;
        public event DeleteButtonEventHandler OnDeleteButtonClick;
        public event EditButtonEventHandler OnEditButtonClick;
        private string message = string.Empty;
        public LandingControl()
        {
            InitializeComponent();
        }
        public void SetExpenseList(List<ExpenseLog.DataItem> list)
        {
            this.expenseListBox.Items.Clear(); 
            for(int i = 0; i < list.Count();i++){
                this.expenseListBox.Items.Add(list[i].ToString());
            }
            
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            OnLogout?.Invoke(this, EventArgs.Empty);
            message = "Returning back to Login Page";
        }
        public string GetMessage()
        {
            return message;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            string cost = CostTextBox.Text;
            OnAddButtonClick?.Invoke(this,new AddButtonEventArgs(name, description, cost));
            message = $"Added the item {name} with the description: {description} and the price: {cost}";

        }
        public string GetNameTextBox()
        {
            return NameTextBox.Text;
        }
        public string GetDescriptionTextBox()
        {
            return DescriptionTextBox.Text;
        }
        public string GetCostTextBox()
        {
            return CostTextBox.Text;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            OnDeleteButtonClick?.Invoke(this,new DeleteButtonEventArgs(name));
            message = $"Deleting item {name}";
           
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            string cost = CostTextBox.Text;
            string old_name = expenseListBox.SelectedItem.ToString();

            OnEditButtonClick?.Invoke(this,new EditButtonEventArgs(name, description, cost,old_name));
            message = $"Editing item {old_name}";
        }
    }
    public class AddButtonEventArgs : EventArgs
    {
        public string Name { get; }
        public string Description { get; }

        public string Cost { get; }
        public AddButtonEventArgs(string name, string description, string cost)
        {
            this.Name = name;
            this.Description = description;
            this.Cost = cost;

        }
    }
    public class DeleteButtonEventArgs : EventArgs
    {
        public string Name { get; }

        public DeleteButtonEventArgs(string name)
        {
            this.Name = name;
        }
    }
    public class EditButtonEventArgs: EventArgs
    {
        public string Name { get; }
        public string Description { get; }

        public string Cost { get; }

        public string OldName { get; }
        public EditButtonEventArgs(string name, string description, string cost,string old_name)
        {
            Name = name;
            Description = description;
            Cost = cost;
            OldName = old_name;
        }
    }
    public delegate void AddButtonEventHandler(object sender, AddButtonEventArgs e);
    public delegate void DeleteButtonEventHandler(object sender, DeleteButtonEventArgs e);
    public delegate void EditButtonEventHandler(object sender, EditButtonEventArgs e);
}
