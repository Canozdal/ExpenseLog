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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pushExpenseButton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string category = categoryTextBox.Text;
            string description = descriptionTextBox.Text;
            decimal cost = decimal.Parse(costTextBox.Text);
            Debug.WriteLine(DateTime.Now.ToString());
            Debug.WriteLine(DateTime.Now.ToString("dd/MM/yyyy_HH:mm"));
            Program.addExpense(date, category, description, cost);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.showExpenses();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string FilePath = "../../jsons/expenses_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm") + ".json";
            Debug.WriteLine("Writing to " + FilePath);
            string json = JsonConvert.SerializeObject(Program.GetExpenses(), Formatting.Indented);
            using (StreamWriter file = File.CreateText(FilePath))
            {
                if(json != null)
                {
                    Debug.WriteLine("JSON is not null");
                    file.Write(json);
                    
                }
                file.Close();   
            }
        }

        private void showExpenseListButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Program.GetExpenses().Count; i++)
            {
                showExpenseListBox.Items.Add(Program.GetExpenses()[i].Date.ToString());
            }
            label1.Text = Program.CalculateExpenses().ToString();
        }

        private void showExpenseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
