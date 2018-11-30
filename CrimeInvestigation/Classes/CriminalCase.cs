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
        public int Complexity { get;private set; }
        public bool Disclosed { get; set; }
        public string FullNamePoliceman { get; set; }

        public CriminalCase(string Name,int hard)
        {
            this.Name = Name;
            this.Complexity = hard;
            this.Disclosed = false;
        }

        public override string ToString()
        {
            return String.Format("{0}, Сложность -{1}", Name, DataSingleton.GetInstance().Complexity[Complexity]);
        }
    }
}
