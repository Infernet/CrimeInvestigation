using System;

namespace CrimeInvestigation.Classes.Receivers
{
    class RemovePoliceman : IReceiver
    {
        public void Run(string[] args)
        {
            if (DataSingleton.GetInstance().CurrentPoliceman != null)
            {
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Отправлен в отставку полицейский:\t" + DataSingleton.GetInstance().CurrentPoliceman);
                DataSingleton.GetInstance().Policemen.Remove(DataSingleton.GetInstance().CurrentPoliceman);
                DataSingleton.GetInstance().CurrentPoliceman = null;
            }
            else
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Ошибка при попытке удалить полицейского из списка (удаляемый объект не выбран)");
        }
    }
    }

