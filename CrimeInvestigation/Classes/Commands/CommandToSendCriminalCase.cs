using CrimeInvestigation.Classes.Receivers;
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

        public CommandToSendCriminalCase(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Run();
        }
    }
}
