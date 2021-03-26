using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.ResponsabilityOfChain
{
   public  class OperationManagerHandler: AbstractHandler
    {
        public override decimal Handle(decimal import)
        {
            if (import > 400 && import <=1000)
            {
                return 1;
            }
            else
            {
                return base.Handle(import);
            }
        }
    }
}
