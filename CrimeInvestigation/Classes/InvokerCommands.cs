using CrimeInvestigation.Classes.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes
{
    class InvokerCommands
    {
        private ICommand Command;

        public InvokerCommands()
        {

        }

        public void SetCommand(ICommand command)
        {
            this.Command = command;
        }

        public void StartCommand()
        {
            if (this.Command != null)
                this.Command.Execute();
        }
    }
}
