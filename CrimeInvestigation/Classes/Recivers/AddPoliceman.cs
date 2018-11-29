using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeInvestigation.Classes.Commands;

namespace CrimeInvestigation.Classes.Recivers
{
    class AddPoliceman : IReciever
    {
        public AddPoliceman()
        {

        }

        public void Run(ICommand command)
        {
            CommandAddPoliceman addPoliceman = command as CommandAddPoliceman;
            if (addPoliceman != null)
                DataSingleton.GetInstance().Policemen.Add(new Policeman(addPoliceman.FName, addPoliceman.LName, addPoliceman.Rank));
        }
    }
}
