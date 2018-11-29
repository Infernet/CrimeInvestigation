using CrimeInvestigation.Classes.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Receivers
{
    interface IReceiver
    {
        void Run(string [] args=null);
    }
}
