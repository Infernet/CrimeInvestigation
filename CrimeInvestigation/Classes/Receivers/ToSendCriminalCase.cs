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
                if (!DataSingleton.GetInstance().CurrentCriminalCase.Disclosed)
                {


                    DataSingleton.GetInstance().Policemen[0].HandlerRequest(DataSingleton.GetInstance().CurrentCriminalCase);
                    if (DataSingleton.GetInstance().CurrentCriminalCase.Disclosed)
                    {
                        DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Успешное раскрытие преступления, полицейский:\t" + DataSingleton.GetInstance().CurrentCriminalCase.FullNamePoliceman);
                        DataSingleton.GetInstance().ChainCreate();
                    }
                    else
                        DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Преступление:\t" + DataSingleton.GetInstance().CurrentCriminalCase + " не было раскрыто");
                }
                else
                    DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Преступление:\t" + DataSingleton.GetInstance().CurrentCriminalCase + " уже раскрыто");
            }
        }
    }
}
