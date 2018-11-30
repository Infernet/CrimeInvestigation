using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeInvestigation.Classes.Commands;
using CrimeInvestigation.Classes.Receivers;

namespace CrimeInvestigation.Classes.Receivers
{
    class AddCriminalCase : IReceiver
    {
        public AddCriminalCase()
        {

        }

        public void Run(string[] args)
        {
            if(args!=null && args.Length==2)
            {
                DataSingleton.GetInstance().CriminalCases.Add(new CriminalCase(args[0], Int32.Parse(args[1]) ));
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss")+"- Добавлено новое уголовное дело:\t" + DataSingleton.GetInstance().CriminalCases[DataSingleton.GetInstance().CriminalCases.Count-1]);
            }
            else
            {
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Ошибка при попытки добавить новое уголовное дело (неверная передача аргументов)");
            }
        }
    }
}
