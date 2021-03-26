using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.ResponsabilityOfChain
{
   public class ManagerHandler: AbstractHandler
    {
        public override decimal Handle(decimal import)
        {
            if (import <=400)
            {
                return 0;
            }
            else
            {
                return base.Handle(import);
            }

        }
    }
}
