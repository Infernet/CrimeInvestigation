namespace CrimeInvestigation.Classes
{
    abstract class AbstractHandler
    {
        public AbstractHandler Successor { get; set; }

        public abstract void HandlerRequest(CriminalCase criminal);
    }
}
