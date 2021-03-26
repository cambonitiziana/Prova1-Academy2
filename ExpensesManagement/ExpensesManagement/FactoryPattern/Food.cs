using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.FactoryPattern
{
    public class Food : Category
    {
        public string description { get; set; }
        public decimal refundImport { get; set; }
        public decimal Import { get; set; }

        public Food(decimal n)
        {
           Import = n;
           refundImport = 0.7m * n;
        }
    }
}
