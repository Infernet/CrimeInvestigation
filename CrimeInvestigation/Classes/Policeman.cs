using System;

namespace CrimeInvestigation.Classes
{
    class Policeman:AbstractHandler
    {
        public string FirstName { get;private set; }
        public string LastName { get;private set; }
        public int Rank { get; set; }

        public Policeman(string fName,string lName,int rank)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Rank = rank;
        }

        public override string ToString()
        {
            return String.Format("{2}  {0} {1}", FirstName, LastName, DataSingleton.GetInstance().Ranks[Rank]);
        }

        public override void HandlerRequest(CriminalCase criminal)
        {
            Random random = new Random();
            //если попытка удачная
            //вероятность успеха (ранг, число рангов - ранг + сложность) успех если результат прока равен правой части
            if (random.Next(this.Rank, (DataSingleton.GetInstance().Ranks.Count - 1) + criminal.Complexity + 1)
                == ((DataSingleton.GetInstance().Ranks.Count - 1) + criminal.Complexity))
            {
                criminal.Disclosed = true;
                criminal.FullNamePoliceman = this.FirstName + " " + this.LastName;
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Полицейский: " + this.ToString() + " раскрыл преступление");
                if ((this.Rank + 1) < DataSingleton.GetInstance().Ranks.Count)
                {
                    this.Rank++;
                    DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Полицейский: " + LastName+ " "+FirstName + " повышен до звания: "+DataSingleton.GetInstance().Ranks[Rank]);
                }
                
            }
            else
            {
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("HH:mm:ss") + "- Полицейский: " + this.ToString() + " не смог раскрыть преступление");
                if (Successor != null)
                    Successor.HandlerRequest(criminal);
            }

                
        }
    }
}
