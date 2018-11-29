using CrimeInvestigation.Classes.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandRemoveCriminalCase : ICommand
    {
        private IReceiver receiver;


        public CommandRemoveCriminalCase(IReceiver reciever)
        {
            this.receiver = reciever;
        }
        

        public void Execute()
        {
            receiver.Run();
        }
    }
}
