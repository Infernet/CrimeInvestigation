using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return String.Format("Имя -{0}, Фамилия- {1},Звание -{2}", FirstName, LastName, DataSingleton.GetInstance().Ranks[Rank]);
        }

        public override void HandlerRequest(CriminalCase criminal)
        {
            Random random = new Random();
            //если попытка удачная
            //вероятность успеха (ранг, число рангов - ранг + сложность) успех если результат прока равен правой части
            if (random.Next(this.Rank, DataSingleton.GetInstance().Ranks.Count - this.Rank + criminal.Complexity+1) == (DataSingleton.GetInstance().Ranks.Count-this.Rank+criminal.Complexity))
            {
                criminal.Disclosed = true;
                criminal.FullNamePoliceman = this.FirstName + " " + this.LastName;
                
                if((this.Rank+1)<DataSingleton.GetInstance().Ranks.Count)
                    this.Rank++;
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Полицейский: " + this.ToString() + " раскрыл преступление");
            }
            else if (Successor != null)
            {
                DataSingleton.GetInstance().Logs.Add(DateTime.Now.ToString("hh:mm:ss") + "- Полицейский: " + this.ToString() + " не смог раскрыть преступление");
                Successor.HandlerRequest(criminal);
            }
                
        }
    }
}
