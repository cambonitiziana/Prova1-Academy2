using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.FactoryPattern
{
    public class Travel: Category
    {
        public string description { get; set; }
        public decimal refundImport { get; set; }
        public decimal Import { get; set; }

        public Travel(decimal n)
        {
            Import = n;
           refundImport = n+50m;
        }
    }
}
