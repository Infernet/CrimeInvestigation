using CrimeInvestigation.Classes.Receivers;

namespace CrimeInvestigation.Classes.Commands
{
    class CommandToSendCriminalCase : ICommand
    {
        private IReceiver receiver;

        public CommandToSendCriminalCase(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Run();
        }
    }
}
