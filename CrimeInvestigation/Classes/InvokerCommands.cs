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
        private static InvokerCommands instance;

        private InvokerCommands()
        {
        }

        public static InvokerCommands GetInstance()
        {
            if (instance == null)
                instance = new InvokerCommands();
            return instance;
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