using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.FactoryPattern
{
    public class Factory
    {
        public static void CategoryRefundFactory(string category, decimal import, string description)
        {
            Category importCategory= null;
            if (category == "Accomodation")
            {
               importCategory = new Accomodation(import);
               importCategory.description = description;
               
            }
            else if (category == "Food")
            {
                importCategory = new Food(import);
                importCategory.description = description;
                
            }
            else if (category == "Travel")
            {
                importCategory = new Travel(import);
                importCategory.description = description;
                
            }
            else if (category == "Other")
            {
                importCategory = new Other(import);
                importCategory.description = description;
                
            }
            else
            {
                Console.WriteLine("Rimborso non disponibile");
                
            }
            

            Console.WriteLine("l'importo del rimborso è pari a {0}", importCategory.refundImport);

        }
    }
}
