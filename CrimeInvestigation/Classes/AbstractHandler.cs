using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes
{
    abstract class AbstractHandler
    {
        public AbstractHandler Successor { get; set; }

        public abstract bool HandlerRequest(CriminalCase criminal);
    }
}
