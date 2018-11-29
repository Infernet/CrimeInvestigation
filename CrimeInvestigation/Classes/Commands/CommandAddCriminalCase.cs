using CrimeInvestigation.Classes.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandAddCriminalCase : ICommand
    {
        private IReceiver receiver;

        public string Name { get;private set; }
        public int Complexity { get;private set; }

        public CommandAddCriminalCase(IReceiver reciever,string name,int complexity)
        {
            this.receiver = reciever;
            this.Name = name;
            this.Complexity = complexity;
        }

        public void Execute()
        {
            if (receiver != null)
                receiver.Run(new string[] { this.Name, this.Complexity.ToString() });
        }
    }
}
