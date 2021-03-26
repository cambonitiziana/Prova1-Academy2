using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.ResponsabilityOfChain
{
    public class CEOHandler : AbstractHandler
    {
        public override decimal Handle(decimal import)
        {
            if (import > 1000 && import<2500)
            {
                return 2;
            }
            else
            {
                return base.Handle(import);
            }
        }
    }
}
