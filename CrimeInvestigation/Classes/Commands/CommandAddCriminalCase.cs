using CrimeInvestigation.Classes.Recivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandAddCriminalCase : ICommand
    {
        private IReciever Reciver;

        public string Name { get;private set; }
        public int Complexity { get;private set; }

        public CommandAddCriminalCase(IReciever reciever,string name,int complexity)
        {
            this.Reciver = reciever;
            this.Name = name;
            this.Complexity = complexity;
        }

        public void Execute()
        {
            Reciver.Run(this);
        }
    }
}
