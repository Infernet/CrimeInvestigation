using CrimeInvestigation.Classes.Receivers;

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
