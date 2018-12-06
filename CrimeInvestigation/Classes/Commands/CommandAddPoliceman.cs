using CrimeInvestigation.Classes.Receivers;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandAddPoliceman : ICommand
    {
        private IReceiver receiver;

        public string FName { get;private set; }
        public string LName { get;private set; }
        public int Rank { get;private set; }

        public CommandAddPoliceman(IReceiver reciever,string fName,string lName,int rank)
        {
            this.receiver = reciever;
            this.FName = fName;
            this.LName = lName;
            this.Rank = rank;
        }

        public void Execute()
        {
            if (receiver != null)
                receiver.Run(new string[] {this.FName,this.LName,this.Rank.ToString() });
        }
    }
}
