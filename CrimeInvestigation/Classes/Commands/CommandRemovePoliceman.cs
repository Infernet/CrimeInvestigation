using CrimeInvestigation.Classes.Receivers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandRemovePoliceman : ICommand
    {
        private IReceiver receiver;

        public CommandRemovePoliceman(IReceiver reciever)
        {
            this.receiver = reciever;
        }


        public void Execute()
        {
            receiver.Run();
        }
    }
}
