using System.Collections.Generic;

namespace CrimeInvestigation.Classes.Comparers
{
    class CriminalCaseByComplexity : IComparer<CriminalCase>
    {
        public int Compare(CriminalCase x, CriminalCase y)
        {
            if (x.Complexity > y.Complexity)
                return 1;
            else if (x.Complexity < y.Complexity)
                return -1;
            return 0;
        }
    }
}
