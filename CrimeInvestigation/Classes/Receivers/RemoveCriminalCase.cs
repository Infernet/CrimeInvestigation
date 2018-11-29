using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeInvestigation.Classes.Receivers;

namespace CrimeInvestigation.Classes.Receivers
{
    class RemoveCriminalCase : IReceiver
    {
        public void Run(string[] args)
        {
            if (DataSingleton.GetInstance().CurrentCriminalCase != null)
            {
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Удаление уголовного дела:"+DataSingleton.GetInstance().CurrentCriminalCase);
                DataSingleton.GetInstance().CriminalCases.Remove(DataSingleton.GetInstance().CurrentCriminalCase);
                DataSingleton.GetInstance().CurrentCriminalCase = null;
            }
            else
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Ошибка при попытке удалить уголовное дело из списка (удаляемый объект не выбран)");
        }
    }
}
