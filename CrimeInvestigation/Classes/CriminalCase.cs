using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes
{
    class CriminalCase
    {
        public string Name { get;private set; }
        public int Сomplexity { get;private set; }
        public bool Disclosed { get; set; }

        public CriminalCase(string Name,int hard)
        {
            this.Name = Name;
            this.Сomplexity = hard;
            this.Disclosed = false;
        }
    }
}
