using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.FactoryPattern
{
    public class Accomodation : Category
    {
        public string description { get; set; }
        public decimal refundImport { get; set; }
        public decimal Import { get; set; }

        public Accomodation(decimal n)
        {
            Import = n;
            refundImport = n;
        }
    }
}
