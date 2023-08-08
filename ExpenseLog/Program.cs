using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseLog
{
    internal class Expense
    {
        public Expense(DateTime time,string category,string Description,decimal Cost)
        {
            this.Date = time;
            this.category = category;
            this.Description = Description;
            this.Cost = Cost;
        }
        public DateTime Date { get; set; }
        public string category { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static List<Expense> expenses = new List<Expense>();
        [STAThread]
        static void Main()
        {
 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static void addExpense(DateTime time,string category,string Description,decimal Cost)
        {
            Expense expense = new Expense(time,category,Description,Cost);
            expenses.Add(expense);
        }

        public static void showExpenses()
        {
            Debug.WriteLine("Inside Show Expenses");
            for (int i = 0; i < expenses.Count; i++)
            {
                Debug.WriteLine(expenses[i].Description);
            }
        }
        public static decimal CalculateExpenses()
        {
            decimal total = 0;
            for(int i = 0;i < expenses.Count; i++)
            {
                total += expenses[i].Cost;
            }
            return total;
        }
        public static List<Expense> GetExpenses()
        {
            return expenses;
        }
    }
}
