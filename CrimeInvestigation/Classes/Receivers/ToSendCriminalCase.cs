using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrimeInvestigation.Classes.Receivers;

namespace CrimeInvestigation.Classes.Receivers
{
    class ToSendCriminalCase : IReceiver
    {
        public void Run(string[] args)
        {
            if(DataSingleton.GetInstance().CurrentCriminalCase!=null && DataSingleton.GetInstance().Policemen.Count!=0)
            {
                DataSingleton.GetInstance().CurrentPoliceman.HandlerRequest(DataSingleton.GetInstance().CurrentCriminalCase);
                if (DataSingleton.GetInstance().CurrentCriminalCase.Disclosed)
                    DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Успешное раскрытие преступления, полицейский:" + DataSingleton.GetInstance().CurrentCriminalCase.FullNamePoliceman);
                else
                    DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Преступление,"+DataSingleton.GetInstance().CurrentCriminalCase+" не было раскрыто");
            }
        }
    }
}
