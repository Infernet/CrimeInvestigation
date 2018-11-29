using CrimeInvestigation.Classes.Recivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandAddPoliceman : ICommand
    {
        private IReciever reciever;

        public string FName { get;private set; }
        public string LName { get;private set; }
        public int Rank { get;private set; }

        public CommandAddPoliceman(IReciever reciever,string fName,string lName,int rank)
        {
            this.reciever = reciever;
            this.FName = fName;
            this.LName = lName;
            this.Rank = rank;
        }

        public void Execute()
        {
            reciever.Run(this);
        }
    }
}
