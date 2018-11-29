using CrimeInvestigation.Classes.Recivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandRemovePoliceman : ICommand
    {
        private IReciever reciever;

        public Policeman Policeman { get; private set; }

        public CommandRemovePoliceman(IReciever reciever, Policeman policeman)
        {
            this.reciever = reciever;
            this.Policeman = policeman;
        }


        public void Execute()
        {
            reciever.Run(this);
        }
    }
}
