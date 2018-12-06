using System.Collections.Generic;

namespace CrimeInvestigation.Classes.Comparers
{
    class PolicemanByRank : IComparer<Policeman>
    {
        public int Compare(Policeman x, Policeman y)
        {
            if (x.Rank > y.Rank)
                return 1;
            else if (x.Rank < y.Rank)
                return -1;
            return 0;
        }
    }
}
