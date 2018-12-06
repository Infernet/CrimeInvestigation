using CrimeInvestigation.Classes.Receivers;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandRemovePoliceman : ICommand
    {
        private IReceiver receiver;

        public CommandRemovePoliceman(IReceiver reciever)
        {
            this.receiver = reciever;
        }


        public void Execute()
        {
            receiver.Run();
        }
    }
}
