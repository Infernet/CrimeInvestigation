using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeInvestigation.Classes.Commands;

namespace CrimeInvestigation.Classes.Recivers
{
    class AddCriminalCase : IReciever
    {
        public AddCriminalCase()
        {

        }

        public void Run(ICommand command)
        {
            CommandAddCriminalCase commandAdd = command as CommandAddCriminalCase;
            if (commandAdd != null)
                DataSingleton.GetInstance().CriminalCases.Add(new CriminalCase(commandAdd.Name, commandAdd.Complexity));
        }
    }
}
