using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeInvestigation.Classes.Commands;
using CrimeInvestigation.Classes.Receivers.Interfaces;

namespace CrimeInvestigation.Classes.Receivers
{
    class AddPoliceman : IReceiver
    {
        public AddPoliceman()
        {

        }

        public void Run(string[] args)
        {
            if(args.Length==3)
            {
                DataSingleton.GetInstance().Policemen.Add(new Policeman(args[0], args[1], Int32.Parse(args[2])));
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Добавлено нововый сотрудник полиции:" );
            }
            else
            {
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Ошибка при попытки добавить нового сотрудника полиции (неверная передача аргументов)");
            }
        }
    }
}
