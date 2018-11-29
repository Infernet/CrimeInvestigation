using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes
{
    class Policeman:AbstractHandler
    {
        public string FirstName { get;private set; }
        public string LastName { get;private set; }
        public int Rank { get; set; }

        public Policeman(string fName,string lName,int rank)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Rank = rank;
        }

        public override bool HandlerRequest(CriminalCase criminal)
        {
            Random random = new Random();
            if (random.Next(3, 2) == 3)
                return true;
            else
                return false;
        }
    }
}
