using CrimeInvestigation.Classes.Receivers;

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
