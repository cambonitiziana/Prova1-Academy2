using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesManagement.ResponsabilityOfChain
{
    public abstract class AbstractHandler: IHandler
        
    {

        private IHandler NextHandler;

        public virtual decimal Handle(decimal import) 
        {
            if (this.NextHandler != null) //se non lo può gestire queste classe lo mando all'altra
            {
                return this.NextHandler.Handle(import);
            }
            else
            {
                return 0;
            }
        }

        public IHandler SetNext(IHandler handler) //-> viene passato e resituito un handler
        {
            NextHandler = handler;
            return handler;
        }
    }
}
