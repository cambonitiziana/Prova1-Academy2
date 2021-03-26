using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement
{
    public class Expense
    {
        public string description { get; set; }
        public decimal import { get; set; }
        public DateTime date { get; set; }
        public string category { get; set; }
        public string esito { get; set; }
        public string livello { get; set; }
        public string rimborso { get; set; }

        public Expense(string s, decimal i, DateTime d, string c)
        {
            description = s;
                import = i;
                date = d;
            category = c;
        }
    }
}
