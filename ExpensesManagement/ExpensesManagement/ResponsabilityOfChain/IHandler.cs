using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.ResponsabilityOfChain
{
   public  interface IHandler
    {
        IHandler SetNext(IHandler handler); 
       decimal Handle(decimal import);
    }
}
