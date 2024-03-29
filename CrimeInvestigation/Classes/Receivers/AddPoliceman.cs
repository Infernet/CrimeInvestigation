﻿using System;

namespace CrimeInvestigation.Classes.Receivers
{
    class AddPoliceman : IReceiver
    {
        public void Run(string[] args)
        {
            if(args.Length==3)
            {
                DataSingleton.GetInstance().Policemen.Add(new Policeman(args[0], args[1], Int32.Parse(args[2])));
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + 
                    "- Добавлен новый сотрудник полиции:\t"+
                    DataSingleton.GetInstance().Ranks[Int32.Parse(args[2])]+" "+args[0]+" "+args[1] );
            }
            else
            {
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Ошибка при попытке добавить нового сотрудника полиции (неверная передача аргументов)");
            }
        }
    }
}
