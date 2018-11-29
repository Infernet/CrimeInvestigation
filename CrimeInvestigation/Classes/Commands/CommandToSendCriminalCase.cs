using CrimeInvestigation.Classes.Receivers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandToSendCriminalCase : ICommand
    {
        IReceiver receiver;

        public CommandToSendCriminalCase()
        {

        }

        public void Execute()
        {
            receiver.Run();
        }
    }
}
