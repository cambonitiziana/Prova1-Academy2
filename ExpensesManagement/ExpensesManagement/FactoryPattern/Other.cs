using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.FactoryPattern
{
   public  class Other: Category
    {
        public string description { get; set; }
        public decimal refundImport { get; set; }
        public decimal Import { get ; set ; }

        public Other(decimal n)
        {
            Import = n;
           refundImport = 0.1m * n;
        }
    }
}
