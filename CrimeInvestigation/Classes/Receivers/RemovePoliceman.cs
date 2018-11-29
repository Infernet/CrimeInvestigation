using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeInvestigation.Classes.Receivers.Interfaces;

namespace CrimeInvestigation.Classes.Receivers
{
    class RemovePoliceman : IReceiver
    {
        public void Run(string[] args)
        {
            if (DataSingleton.GetInstance().CurrentPoliceman != null)
            {
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Удаление полицейского:" + DataSingleton.GetInstance().CurrentPoliceman);
                DataSingleton.GetInstance().Policemen.Remove(DataSingleton.GetInstance().CurrentPoliceman);
            }
            else
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Ошибка при попытке удалить полицейского из списка (удаляемый объект не выбран)");
        }
    }
    }

