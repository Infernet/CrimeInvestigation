using CrimeInvestigation.Classes.Recivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandRemoveCriminalCase : ICommand
    {
        private IReciever reciever;

        public CriminalCase CriminalCase { get; private set; }

        public CommandRemoveCriminalCase(IReciever reciever,CriminalCase criminalCase)
        {
            this.reciever = reciever;
            this.CriminalCase = criminalCase;
        }
        

        public void Execute()
        {
            reciever.Run(this);
        }
    }
}
