using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.FactoryPattern
{
    public interface Category
    {
        //per ogni categoria  creo istanze della categoria speciafica per cui voglio sapere l'importo e il rimborso
        public string description { get; set; }
        public decimal Import { get; set; }
        public decimal refundImport { get ; set; }
       // public decimal refund(decimal n);
    }
}
