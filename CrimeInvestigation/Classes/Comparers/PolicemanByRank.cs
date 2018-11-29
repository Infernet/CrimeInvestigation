using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
